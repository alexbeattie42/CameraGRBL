using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynchronousGrab;

using System.Drawing.Imaging;

namespace LaserGRBL
{
    public partial class CameraControl : UserControl
    {
        public GrblCore Core;
        private VimbaHelper m_VimbaHelper = null;
        private CameraInfo selectedItem;
        private static Decimal startDistance = Properties.Settings.Default.startDistance;
        private static Decimal betweenDistance = Properties.Settings.Default.betweenDistance;
       
        private int currentIndex = 0;
        public static bool runningCycle = false;
        private bool home = false;
        private bool firstPlate = true;
        
        
     
        
            
        private static readonly int MAX_NUM_PLATES = 8;

        CheckBox[] boxes = new CheckBox[MAX_NUM_PLATES];

        public VimbaHelper VimbaHelper { get => m_VimbaHelper; set => m_VimbaHelper = value; }
        public  CameraInfo SelectedItem { get => selectedItem; set => selectedItem = value; }

        public CameraControl()
        {
            InitializeComponent();
           

        }
        private void CameraControl_Load(object sender, EventArgs e)
        {
        
            Console.WriteLine("Camera Loaded");


            numericUpDown1.Maximum = MAX_NUM_PLATES;
        numericUpDown1.Value = Properties.Settings.Default.numPlates;
            


            textBox1.Text = Properties.Settings.Default.fileLocation;;
            textBox2.Text = Properties.Settings.Default.fileName;;
            updateCheckboxs();
            //m_CameraListTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
           
            
        }
        private void updateCheckboxs()
        {
            CheckBox box;
            flowLayoutPanel1.Controls.Clear();
            if (numericUpDown1.Value <= MAX_NUM_PLATES)
            {
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    box = new CheckBox();
                    box.Tag = "box" + i.ToString();
                    box.Text = (i + 1).ToString();
                    
                    box.AutoSize = true;
                    box.Checked = true;
                    flowLayoutPanel1.Controls.Add(box);
                    boxes[i] = box;


                }
            }
            else
            {
                LogError("Number of plates exceeds maximum value");
            }
        }
        public void SetCore(GrblCore core)
        {
            Core = core;
            Core.MachineStatusChanged += OnMachineStatus;
        }
        void OnMachineStatus()
        {
            Console.WriteLine("Machine Position" + Core.MachinePosition);
           

            //LogMessage("Machine Status Changed");
            if (Core.MachineStatus == GrblCore.MacStatus.Idle && runningCycle)
            {
                LogMessage("Status Idle");
                if (firstPlate && FindCheckedBox(currentIndex))
                {
                    Core.EnqueueCommand(Core.buildMotionCommand(currentIndex));
                    firstPlate = false;
                }
               
                
                else if (currentIndex >= numericUpDown1.Value || !FindCheckedBox(currentIndex))
                {
                    runningCycle = false;
                    currentIndex = 0;
                    CapSaveImage();
                    Core.GrblHoming();
                }
                else
                {
                    CapSaveImage();
                    Core.EnqueueCommand(Core.buildMotionCommand(currentIndex));

                }

            }
            else if (Core.MachineStatus == GrblCore.MacStatus.Home)
            {
                LogMessage("Home");
                Core.homeMachinePos = (decimal)Core.MachinePosition.Y;
                home = true;
            }
            else 
            {
                home = false;
            }

        }
        //Add log message to logging list box
        public void LogMessage(string message)
        {
            if (null == message)
            {
                throw new ArgumentNullException("message");
            }

            int index = m_LogList.Items.Add(string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}: {1}", DateTime.Now, message));
            m_LogList.TopIndex = index;
        }

        //Add an error log message and show an error message box
        public void LogError(string message)
        {
            LogMessage(message);

            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void UpdateCameraList()
        {
            //Remember the old selection (if there was any)y
            CameraInfo oldSelectedItem = m_CameraList.SelectedItem as CameraInfo;
            m_CameraList.Items.Clear();

            List<CameraInfo> cameras = VimbaHelper.CameraList;

            CameraInfo newSelectedItem = null;
            foreach (CameraInfo cameraInfo in cameras)
            {
                m_CameraList.Items.Add(cameraInfo);

                if (null == newSelectedItem)
                {
                    //At least select the first camera
                    newSelectedItem = cameraInfo;
                }
                else if (null != oldSelectedItem)
                {
                    //If the previous selected camera is still available
                    //then prefer this camera.
                    if (string.Compare(newSelectedItem.ID, cameraInfo.ID, StringComparison.Ordinal) == 0)
                    {
                        newSelectedItem = cameraInfo;
                    }
                }
            }

            //If available select a camera.
            if (null != newSelectedItem)
            {
                m_CameraList.SelectedItem = newSelectedItem;
            }
        }

        public void OnCameraListChanged(object sender, EventArgs args)
        {
            //Start an async invoke in case this method was not
            //called by the GUI thread.
            if (InvokeRequired == true)
            {
                BeginInvoke(new CameraListChangedHandler(this.OnCameraListChanged), sender, args);
                return;
            }

            if (null != VimbaHelper)
            {
                try
                {
                    UpdateCameraList();

                    LogMessage("Camera list updated.");
                }
                catch (Exception exception)
                {
                    LogError("Could not update camera list. Reason: " + exception.Message);
                }
            }
        }
        private void m_AcquireButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Determine selected camera
                CameraInfo selectedItem = m_CameraList.SelectedItem as CameraInfo;
                if (null == selectedItem)
                {
                    throw new NullReferenceException("No camera selected.");
                }

                //Acquire an image synchronously (snap) from selected camera

                Image image = VimbaHelper.AcquireSingleImage(selectedItem.ID);

                //Display image
                m_PictureBox.Image = image;

                LogMessage("Image acquired synchronously.");
            }
            catch (Exception exception)
            {
                LogError("Could not acquire image. Reason: " + exception.Message);
            }
        }

        //Toggle mode between zoomed and 1:1 image display
        private void ToogleDisplayMode()
        {
            if (PictureBoxSizeMode.Zoom == m_PictureBox.SizeMode)
            {
                m_PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                m_PictureBox.Dock = DockStyle.None;
            }
            else
            {
                m_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                m_PictureBox.Dock = DockStyle.Fill;
            }
        }

        private void m_PictureBox_DoubleClick(object sender, EventArgs e)
        {
            ToogleDisplayMode();
        }

        private void m_DisplayPanel_DoubleClick(object sender, EventArgs e)
        {
            ToogleDisplayMode();
        }

        private void m_CameraList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CameraInfo cameraInfo = m_CameraList.SelectedItem as CameraInfo;
            if (null == cameraInfo)
            {
                //Disable button if no camera is selected
                m_AcquireButton.Enabled = false;
            }
            else
            {
                //Enable button if a camera is selected
                m_AcquireButton.Enabled = true;
                SelectedItem = cameraInfo;
            }
        }
        private bool FindCheckedBox(int index)
        {
            bool found = false;
            while (!found && index < numericUpDown1.Value)
            {
        
                    if (boxes[index].Checked)
                    {
                    Console.WriteLine("Box " +(index+1) + " checked");
                        found = true;
                        currentIndex = index;
                    return true;
                    }
                    else
                    {
                        index++;
                    }
                
            }
            Console.WriteLine("No more boxes checked");
            return false;
    
        }
        public void CapSaveImage()
        {
       

            try
            {
                //Determine selected camera


                if (null == SelectedItem)
                {
                    throw new NullReferenceException("No camera selected.");
                }

                //Acquire an image synchronously (snap) from selected camera
                Image image = VimbaHelper.AcquireSingleImage(SelectedItem.ID);

                //Display image
                m_PictureBox.Image = image;

                StringBuilder sb = new StringBuilder();
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd--H-mm-ss");
                ImageFormat fileType = ImageFormat.Png;
                
                sb.Append(textBox1.Text + "\"");
                sb.Append(currentDate + "--");
                sb.Append(textBox2.Text);
                sb.Append(fileType.ToString().ToLower());



               // Console.WriteLine("File Name: " + sb.ToString());
                image.Save(sb.ToString(), fileType);
                Console.WriteLine("Image written to: " + sb.ToString());
                LogMessage("Image acquired synchonously.");

                // System.Threading.Thread.Sleep(200);
                

            }
            catch (Exception exception)
            {
                LogError("Could not acquire image. Reason: " + exception.Message);
            }
        }

        private void m_CameraListTable_Paint(object sender, PaintEventArgs e)
        {

        }
        public GrblCommand firstMove = new GrblCommand(string.Format("G91 Y13 F4000 "));
        private void button1_Click(object sender, EventArgs e)
        {
            runningCycle = true;
            currentIndex = 0;
            FindCheckedBox(currentIndex);
            
            if (home)
            {
                firstPlate = false;
                Core.EnqueueCommand(Core.buildMotionCommand(currentIndex));
            }
            else
            {
                Core.GrblHoming();
                firstPlate = true;
                
            }
            
           // CapSaveImage();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            
            Properties.Settings.Default.numPlates = numericUpDown1.Value;
            Properties.Settings.Default.Save();
            updateCheckboxs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.fileLocation = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.fileName = textBox2.Text;
            Properties.Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(CheckBox box in boxes)
            {
                box.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (CheckBox box in boxes)
            {
                box.Checked = true ;
            }
        }
    }
}
