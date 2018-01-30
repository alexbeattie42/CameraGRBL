﻿/*
 * Created by SharpDevelop.
 * User: Diego
 * Date: 05/12/2016
 * Time: 23:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LaserGRBL
{
	partial class PreviewForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.MNAddCB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCustomButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            this.BtnReset = new LaserGRBL.UserControls.ImageButton();
            this.BtnStop = new LaserGRBL.UserControls.ImageButton();
            this.BtnResume = new LaserGRBL.UserControls.ImageButton();
            this.BtnHoming = new LaserGRBL.UserControls.ImageButton();
            this.BtnUnlock = new LaserGRBL.UserControls.ImageButton();
            this.MNRemEditCB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.MNAddCB.SuspendLayout();
            this.MNRemEditCB.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // MNAddCB
            // 
            this.MNAddCB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomButtonToolStripMenuItem});
            this.MNAddCB.Name = "CMM";
            resources.ApplyResources(this.MNAddCB, "MNAddCB");
            // 
            // addCustomButtonToolStripMenuItem
            // 
            this.addCustomButtonToolStripMenuItem.Name = "addCustomButtonToolStripMenuItem";
            resources.ApplyResources(this.addCustomButtonToolStripMenuItem, "addCustomButtonToolStripMenuItem");
            this.addCustomButtonToolStripMenuItem.Click += new System.EventHandler(this.addCustomButtonToolStripMenuItem_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.AltImage = null;
            resources.ApplyResources(this.BtnReset, "BtnReset");
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnReset.Coloration = System.Drawing.Color.Empty;
            this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.TT.SetToolTip(this.BtnReset, resources.GetString("BtnReset.ToolTip"));
            this.BtnReset.UseAltImage = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.AltImage = ((System.Drawing.Image)(resources.GetObject("BtnStop.AltImage")));
            resources.ApplyResources(this.BtnStop, "BtnStop");
            this.BtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnStop.Coloration = System.Drawing.Color.Empty;
            this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnStop, resources.GetString("BtnStop.ToolTip"));
            this.BtnStop.UseAltImage = false;
            // 
            // BtnResume
            // 
            this.BtnResume.AltImage = null;
            resources.ApplyResources(this.BtnResume, "BtnResume");
            this.BtnResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnResume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnResume.Coloration = System.Drawing.Color.Empty;
            this.BtnResume.Image = ((System.Drawing.Image)(resources.GetObject("BtnResume.Image")));
            this.BtnResume.Name = "BtnResume";
            this.BtnResume.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnResume, resources.GetString("BtnResume.ToolTip"));
            this.BtnResume.UseAltImage = false;
            // 
            // BtnHoming
            // 
            this.BtnHoming.AltImage = null;
            resources.ApplyResources(this.BtnHoming, "BtnHoming");
            this.BtnHoming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnHoming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnHoming.Coloration = System.Drawing.Color.Empty;
            this.BtnHoming.Image = ((System.Drawing.Image)(resources.GetObject("BtnHoming.Image")));
            this.BtnHoming.Name = "BtnHoming";
            this.BtnHoming.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.TT.SetToolTip(this.BtnHoming, resources.GetString("BtnHoming.ToolTip"));
            this.BtnHoming.UseAltImage = false;
            this.BtnHoming.Click += new System.EventHandler(this.BtnHoming_Click);
            // 
            // BtnUnlock
            // 
            this.BtnUnlock.AltImage = null;
            resources.ApplyResources(this.BtnUnlock, "BtnUnlock");
            this.BtnUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnUnlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnUnlock.Coloration = System.Drawing.Color.Empty;
            this.BtnUnlock.Image = ((System.Drawing.Image)(resources.GetObject("BtnUnlock.Image")));
            this.BtnUnlock.Name = "BtnUnlock";
            this.BtnUnlock.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.TT.SetToolTip(this.BtnUnlock, resources.GetString("BtnUnlock.ToolTip"));
            this.BtnUnlock.UseAltImage = false;
            this.BtnUnlock.Click += new System.EventHandler(this.BtnUnlock_Click);
            // 
            // MNRemEditCB
            // 
            this.MNRemEditCB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveButton,
            this.editButtonToolStripMenuItem});
            this.MNRemEditCB.Name = "CMM";
            resources.ApplyResources(this.MNRemEditCB, "MNRemEditCB");
            // 
            // RemoveButton
            // 
            this.RemoveButton.Name = "RemoveButton";
            resources.ApplyResources(this.RemoveButton, "RemoveButton");
            // 
            // editButtonToolStripMenuItem
            // 
            this.editButtonToolStripMenuItem.Name = "editButtonToolStripMenuItem";
            resources.ApplyResources(this.editButtonToolStripMenuItem, "editButtonToolStripMenuItem");
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.BtnReset, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.BtnResume, 5, 0);
            this.tableLayoutPanel8.Controls.Add(this.BtnStop, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.BtnUnlock, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.BtnHoming, 2, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.TabStop = true;
            // 
            // PreviewForm
            // 
            this.Controls.Add(this.tableLayoutPanel8);
            resources.ApplyResources(this, "$this");
            this.Name = "PreviewForm";
            this.MNAddCB.ResumeLayout(false);
            this.MNRemEditCB.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.ToolTip TT;
		private System.Windows.Forms.ContextMenuStrip MNAddCB;
		private System.Windows.Forms.ToolStripMenuItem addCustomButtonToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MNRemEditCB;
		private System.Windows.Forms.ToolStripMenuItem RemoveButton;
		private System.Windows.Forms.ToolStripMenuItem editButtonToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private UserControls.ImageButton BtnReset;
        private UserControls.ImageButton BtnStop;
        //private UserControls.ImageButton BtnUnlock;
        private UserControls.ImageButton BtnHoming;
        private UserControls.ImageButton BtnResume;
        private UserControls.ImageButton BtnUnlock;
    }
}
