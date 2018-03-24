using System;
using System.Text;
using System.Windows.Forms;

namespace LaserGRBL
{
	public partial class JogForm : Form

	{
		GrblCore Core;
       
        public JogForm(GrblCore core)
        {
            InitializeComponent();
            SetCore(core);
            numericUpDown1.Value = Properties.Settings.Default.startDistance;
            numericUpDown2.Value = Properties.Settings.Default.betweenDistance;
            textBox1.Text = Properties.Settings.Default.cameraSettingsLocation;

        }

        internal static void CreateAndShowDialog(GrblCore core)
        {
            using (JogForm sf = new JogForm(core))
                sf.ShowDialog();
        }
        public JogForm()
		{
			InitializeComponent();
		}

		public void SetCore(GrblCore core)
		{
			Core = core;

			TbSpeed.Value = (int)Settings.GetObject("Jog Speed", 1000);
			TbStep.Value = (int)Settings.GetObject("Jog Step", 10);

			TbSpeed_ValueChanged(null, null); //set tooltip
			TbStep_ValueChanged(null, null); //set tooltip
		}

		private void OnJogButtonMouseDown(object sender, MouseEventArgs e)
		{
			Core.Jog((sender as DirectionButton).JogDirection);
		}

		private void TbSpeed_ValueChanged(object sender, EventArgs e)
		{
			TT.SetToolTip(TbSpeed, string.Format("Speed: {0}", TbSpeed.Value));
			LblSpeed.Text = String.Format("F{0}", TbSpeed.Value);
			Settings.SetObject("Jog Speed", TbSpeed.Value);
			Core.JogSpeed = TbSpeed.Value;
			needsave = true;
		}

		private void TbStep_ValueChanged(object sender, EventArgs e)
		{
			TT.SetToolTip(TbStep, string.Format("Step: {0}", TbStep.Value));
			LblStep.Text = TbStep.Value.ToString();
			Settings.SetObject("Jog Step", TbStep.Value);
			Core.JogStep = TbStep.Value;
			needsave = true;
		}

		private void BtnHome_Click(object sender, EventArgs e)
		{
			Core.JogHome();
		}

		bool needsave = false;
		private void OnSliderMouseUP(object sender, MouseEventArgs e)
		{
			if (needsave)
			{
				needsave = false;
				Settings.Save();
			}
		}

        private void JogForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.startDistance = numericUpDown1.Value;
            Properties.Settings.Default.Save();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.betweenDistance = numericUpDown2.Value;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Core.GrblHoming();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Core.EnqueueCommand(Core.buildMotionCommand(0));
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("G91 ");
            sb.Append(Properties.Settings.Default.primaryAxis);
            sb.Append(Properties.Settings.Default.betweenDistance + " ");
            sb.Append("F" + Properties.Settings.Default.speed);
            Console.WriteLine(sb.ToString());
            Core.EnqueueCommand(new GrblCommand(sb.ToString()));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                Properties.Settings.Default.cameraSettingsLocation = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
            }
        }
    }

    public class DirectionButton : UserControls.ImageButton
	{
		private GrblCore.JogDirection mDir = GrblCore.JogDirection.N;

		public GrblCore.JogDirection JogDirection
		{
			get { return mDir; }
			set { mDir = value; }
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			if (Width != Height)
				Width = Height;

			base.OnSizeChanged(e);
		}
	}
}
