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
        private static VimbaHelper m_VimbaHelper = null;
        private static CameraInfo selectedItem;
        public static float startDistance = 14;
        public static float betweenDistance = 5;
        public CameraControl()
        {
            InitializeComponent();
        }
        private void CameraControl_Load(object sender, EventArgs e)
        {
            try
            {
                //Start up Vimba API
                VimbaHelper vimbaHelper = new VimbaHelper();
                vimbaHelper.Startup(this.OnCameraListChanged);
                Text += String.Format(" Vimba .NET API Version {0}", vimbaHelper.GetVersion());
                m_VimbaHelper = vimbaHelper;

                try
                {
                    UpdateCameraList();
                }
                catch (Exception exception)
                {
                    LogError("Could not update camera list. Reason: " + exception.Message);
                }
            }
            catch (Exception exception)
            {
                LogError("Could not startup Vimba API. Reason: " + exception.Message);
            }
        }
        //Add log message to logging list box
        private void LogMessage(string message)
        {
            if (null == message)
            {
                throw new ArgumentNullException("message");
            }

            int index = m_LogList.Items.Add(string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}: {1}", DateTime.Now, message));
            m_LogList.TopIndex = index;
        }

        //Add an error log message and show an error message box
        private void LogError(string message)
        {
            LogMessage(message);

            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UpdateCameraList()
        {
            //Remember the old selection (if there was any)y
            CameraInfo oldSelectedItem = m_CameraList.SelectedItem as CameraInfo;
            m_CameraList.Items.Clear();

            List<CameraInfo> cameras = m_VimbaHelper.CameraList;

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

        private void OnCameraListChanged(object sender, EventArgs args)
        {
            //Start an async invoke in case this method was not
            //called by the GUI thread.
            if (InvokeRequired == true)
            {
                BeginInvoke(new CameraListChangedHandler(this.OnCameraListChanged), sender, args);
                return;
            }

            if (null != m_VimbaHelper)
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

                Image image = m_VimbaHelper.AcquireSingleImage(selectedItem.ID);

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
                selectedItem = cameraInfo;
            }
        }
        public static void CapSaveImage()
        {
            //string currentDate = DateTime.Now.ToString("h:mm:ss");

            try
            {
                //Determine selected camera


                if (null == selectedItem)
                {
                    throw new NullReferenceException("No camera selected.");
                }

                //Acquire an image synchronously (snap) from selected camera
                Image image = m_VimbaHelper.AcquireSingleImage(selectedItem.ID);

                //Display image
                //m_PictureBox.Image = image;

                string currentDate = DateTime.Now.ToString("h-mm-ss");
                string fileName = "./Images/" + currentDate + ".png";
                Console.WriteLine();
                Console.WriteLine(fileName);
                image.Save(fileName, ImageFormat.Png);
                //LogError("Image acquired synchonously.");

                // System.Threading.Thread.Sleep(200);
                // usrSerial.WriteLine("D");

            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not acquire image. Reason: " + exception.Message);
            }
        }
    }
}
