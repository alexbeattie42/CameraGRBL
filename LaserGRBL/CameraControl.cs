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
        public static Decimal startDistance = Properties.Settings.Default.startDistance;
        public static Decimal betweenDistance = Properties.Settings.Default.betweenDistance;
     
        
            
        private static readonly int MAX_NUM_PLATES = 8;
        
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
            checkBox1.Checked = Properties.Settings.Default.addDate;
            checkBox2.Checked = Properties.Settings.Default.addTime;


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
                    box.Tag = i.ToString();
                    box.Text = (i + 1).ToString();
                    box.AutoSize = true;
                    box.Checked = true;
                    flowLayoutPanel1.Controls.Add(box);


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
            LogMessage("Machine Status Changed");
            if (Core.MachineStatus == GrblCore.MacStatus.Idle)
            {
                
                LogMessage("Status Idle");
                Console.WriteLine("StatusIdle");
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
        public void CapSaveImage()
        {
            //string currentDate = DateTime.Now.ToString("h:mm:ss");

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
                //m_PictureBox.Image = image;

                string currentDate = DateTime.Now.ToString("h-mm-ss");
                string fileName = "./Images/" + currentDate + ".png";
                Console.WriteLine();
                Console.WriteLine(fileName);
                image.Save(fileName, ImageFormat.Png);
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
            Core.EnqueueCommand(firstMove);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.addDate = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.addTime = checkBox2.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
