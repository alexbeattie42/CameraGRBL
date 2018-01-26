﻿/*
 * Created by SharpDevelop.
 * User: Diego
 * Date: 05/12/2016
 * Time: 23:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LaserGRBL
{
	/// <summary>
	/// Description of PreviewForm.
	/// </summary>
	public partial class PreviewForm : System.Windows.Forms.UserControl
	{
		GrblCore Core;

		public PreviewForm()
		{
			InitializeComponent();
		}

		public void SetCore(GrblCore core)
		{
			Core = core;
			

			
			TimerUpdate();
		}

		public void TimerUpdate()
		{
			
			SuspendLayout();
			BtnReset.Enabled = Core.CanResetGrbl;
			BtnHoming.Visible = Core.Configuration.HomingEnabled;
			BtnHoming.Enabled = Core.CanDoHoming;
			BtnUnlock.Enabled = Core.CanUnlock;
			BtnStop.Enabled = Core.CanFeedHold;
			BtnResume.Enabled = Core.CanResumeHold;
			//BtnZeroing.Enabled = Core.CanDoZeroing;

			

			ResumeLayout();
		}

		void BtnGoHomeClick(object sender, EventArgs e)
		{
			Core.GrblHoming();
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			Core.GrblReset();
		}
		void BtnStopClick(object sender, EventArgs e)
		{
			Core.FeedHold();
		}
		void BtnResumeClick(object sender, EventArgs e)
		{
			Core.CycleStartResume();
		}

		private void BtnUnlockClick(object sender, EventArgs e)
		{
			Core.GrblUnlock();
		}

		private void addCustomButtonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustomButtonForm.CreateAndShowDialog();
		
		}

		

		private class CustomButtonIB : UserControls.ImageButton
		{
			private GrblCore Core;
			private LaserGRBL.CustomButton cb;
			PreviewForm form;
			private ToolTip tt;
			private ContextMenuStrip cms;
			private bool mDrawDisabled = true;

			public CustomButtonIB(GrblCore Core, LaserGRBL.CustomButton cb, PreviewForm form)
			{
				// TODO: Complete member initialization
				this.Core = Core;
				this.cb = cb;
				this.form = form;
				this.tt = new ToolTip();

				Image = cb.Image;
				Tag = cb;

				//ContextMenuStrip = MNRemEditCB;
				SizingMode = UserControls.ImageButton.SizingModes.FixedSize;
				BorderStyle = BorderStyle.FixedSingle;
				Size = new Size(49, 49);
				Margin = new Padding(2);
				tt.SetToolTip(this, cb.ToolTip);


				cms = new ContextMenuStrip();
				

				this.ContextMenuStrip = cms;
			}


			protected override void Dispose(bool disposing)
			{
				tt.SetToolTip(this, null);
				base.Dispose(disposing);
			}

			public CustomButton CustomButton
			{ get { return Tag as CustomButton; } }

			internal void RefreshEnabled()
			{
				bool disabled = !CustomButton.EnabledNow(Core);
				if (mDrawDisabled != disabled)
				{
					mDrawDisabled = disabled;
					Refresh();
				}
			}

			protected override bool DrawDisabled()
			{
				return mDrawDisabled;
			}

			protected override void OnClick(EventArgs e)
			{
				if (mDrawDisabled || !CustomButton.EnabledNow(Core))
					return;

				Core.ExecuteCustombutton(cb.GCode);
				base.OnClick(e);
			}

			

		}

		private class MyFlowPanel : FlowLayoutPanel
		{
			public MyFlowPanel()
			{
				ResizeRedraw = true;
			}

			protected override void OnControlAdded(ControlEventArgs e)
			{
				base.OnControlAdded(e);
				Invalidate();
			}
			protected override void OnControlRemoved(ControlEventArgs e)
			{
				base.OnControlRemoved(e);
				Invalidate();
			}

			protected override void OnPaintBackground(PaintEventArgs e)
			{
				e.Graphics.Clear(BackColor);
				if (Controls.Count == 0)
				{
					SizeF size = e.Graphics.MeasureString("Right click here to add custom buttons", Font);
					e.Graphics.DrawString("Right click here to add custom buttons", Font, Brushes.DarkGray, (Width - size.Width) / 2, (Height - size.Height) / 2);
				}
			}
		}


	
		private void BtnZeroing_Click(object sender, EventArgs e)
		{
			Core.SetNewZero();
		}

        private void BtnUnlock_Click(object sender, EventArgs e)
        {
            Core.GrblUnlock();
        }
    }

}
