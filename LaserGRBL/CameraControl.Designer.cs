namespace LaserGRBL
{
    partial class CameraControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_CameraListTable = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.m_AcquireButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_CameraList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.m_LogTable = new System.Windows.Forms.TableLayoutPanel();
            this.m_LogList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.m_CameraListTable.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.m_LogTable.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_CameraListTable
            // 
            this.m_CameraListTable.ColumnCount = 1;
            this.m_CameraListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_CameraListTable.Controls.Add(this.button1, 0, 9);
            this.m_CameraListTable.Controls.Add(this.flowLayoutPanel3, 0, 6);
            this.m_CameraListTable.Controls.Add(this.label1, 0, 0);
            this.m_CameraListTable.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.m_CameraListTable.Controls.Add(this.m_CameraList, 0, 1);
            this.m_CameraListTable.Controls.Add(this.flowLayoutPanel1, 0, 7);
            this.m_CameraListTable.Controls.Add(this.label4, 0, 2);
            this.m_CameraListTable.Controls.Add(this.flowLayoutPanel4, 0, 5);
            this.m_CameraListTable.Controls.Add(this.label5, 0, 4);
            this.m_CameraListTable.Controls.Add(this.m_AcquireButton, 0, 10);
            this.m_CameraListTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_CameraListTable.Location = new System.Drawing.Point(0, 0);
            this.m_CameraListTable.Name = "m_CameraListTable";
            this.m_CameraListTable.RowCount = 12;
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.Size = new System.Drawing.Size(222, 460);
            this.m_CameraListTable.TabIndex = 5;
            this.m_CameraListTable.Paint += new System.Windows.Forms.PaintEventHandler(this.m_CameraListTable_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(3, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Run Cycle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // m_AcquireButton
            // 
            this.m_AcquireButton.AutoSize = true;
            this.m_AcquireButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_AcquireButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_AcquireButton.Enabled = false;
            this.m_AcquireButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_AcquireButton.Location = new System.Drawing.Point(0, 422);
            this.m_AcquireButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.m_AcquireButton.Name = "m_AcquireButton";
            this.m_AcquireButton.Size = new System.Drawing.Size(222, 38);
            this.m_AcquireButton.TabIndex = 3;
            this.m_AcquireButton.Text = "Acquire single image";
            this.m_AcquireButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Controls.Add(this.button4);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 256);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(216, 35);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Select All";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Clear Selection";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cameras:";
            // 
            // m_CameraList
            // 
            this.m_CameraList.FormattingEnabled = true;
            this.m_CameraList.IntegralHeight = false;
            this.m_CameraList.Location = new System.Drawing.Point(0, 16);
            this.m_CameraList.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.m_CameraList.Name = "m_CameraList";
            this.m_CameraList.Size = new System.Drawing.Size(220, 93);
            this.m_CameraList.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of Plates:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(100, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 297);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(216, 63);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "File Selection:";
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PictureBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.m_PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_PictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_PictureBox.Location = new System.Drawing.Point(222, 0);
            this.m_PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(439, 460);
            this.m_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_PictureBox.TabIndex = 6;
            this.m_PictureBox.TabStop = false;
            // 
            // m_LogTable
            // 
            this.m_LogTable.ColumnCount = 1;
            this.m_LogTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_LogTable.Controls.Add(this.m_LogList, 0, 1);
            this.m_LogTable.Controls.Add(this.label2, 0, 0);
            this.m_LogTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_LogTable.Location = new System.Drawing.Point(222, 363);
            this.m_LogTable.Name = "m_LogTable";
            this.m_LogTable.RowCount = 2;
            this.m_LogTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_LogTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_LogTable.Size = new System.Drawing.Size(439, 97);
            this.m_LogTable.TabIndex = 7;
            // 
            // m_LogList
            // 
            this.m_LogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_LogList.FormattingEnabled = true;
            this.m_LogList.IntegralHeight = false;
            this.m_LogList.Location = new System.Drawing.Point(0, 13);
            this.m_LogList.Margin = new System.Windows.Forms.Padding(0);
            this.m_LogList.Name = "m_LogList";
            this.m_LogList.Size = new System.Drawing.Size(439, 84);
            this.m_LogList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log messages:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 129);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(216, 71);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 226);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(216, 24);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Plant Configuration";
            // 
            // CameraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_LogTable);
            this.Controls.Add(this.m_PictureBox);
            this.Controls.Add(this.m_CameraListTable);
            this.Name = "CameraControl";
            this.Size = new System.Drawing.Size(661, 460);
            this.Load += new System.EventHandler(this.CameraControl_Load);
            this.m_CameraListTable.ResumeLayout(false);
            this.m_CameraListTable.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.m_LogTable.ResumeLayout(false);
            this.m_LogTable.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel m_CameraListTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_AcquireButton;
        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.TableLayoutPanel m_LogTable;
        private System.Windows.Forms.ListBox m_LogList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox m_CameraList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label5;
    }
}
