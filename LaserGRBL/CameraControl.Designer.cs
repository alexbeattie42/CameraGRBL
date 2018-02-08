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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraControl));
            this.m_CameraListTable = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_CameraList = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.m_AcquireButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.m_LogTable = new System.Windows.Forms.TableLayoutPanel();
            this.m_LogList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.m_CameraListTable.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.m_LogTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_CameraListTable
            // 
            this.m_CameraListTable.ColumnCount = 1;
            this.m_CameraListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_CameraListTable.Controls.Add(this.label1, 0, 0);
            this.m_CameraListTable.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.m_CameraListTable.Controls.Add(this.m_CameraList, 0, 1);
            this.m_CameraListTable.Controls.Add(this.flowLayoutPanel1, 0, 8);
            this.m_CameraListTable.Controls.Add(this.label4, 0, 2);
            this.m_CameraListTable.Controls.Add(this.flowLayoutPanel4, 0, 7);
            this.m_CameraListTable.Controls.Add(this.label5, 0, 6);
            this.m_CameraListTable.Controls.Add(this.m_AcquireButton, 0, 11);
            this.m_CameraListTable.Controls.Add(this.label6, 0, 4);
            this.m_CameraListTable.Controls.Add(this.flowLayoutPanel3, 0, 5);
            this.m_CameraListTable.Controls.Add(this.button1, 0, 10);
            this.m_CameraListTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_CameraListTable.Location = new System.Drawing.Point(0, 0);
            this.m_CameraListTable.Name = "m_CameraListTable";
            this.m_CameraListTable.RowCount = 13;
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.Size = new System.Drawing.Size(329, 508);
            this.m_CameraListTable.TabIndex = 5;
            this.m_CameraListTable.Paint += new System.Windows.Forms.PaintEventHandler(this.m_CameraListTable_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(89, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Image Plates";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 129);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(323, 36);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 1;
            // 
            // m_CameraList
            // 
            this.m_CameraList.FormattingEnabled = true;
            this.m_CameraList.IntegralHeight = false;
            this.m_CameraList.Location = new System.Drawing.Point(0, 16);
            this.m_CameraList.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.m_CameraList.Name = "m_CameraList";
            this.m_CameraList.Size = new System.Drawing.Size(329, 93);
            this.m_CameraList.TabIndex = 1;
            this.m_CameraList.SelectedIndexChanged += new System.EventHandler(this.m_CameraList_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 288);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 63);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Folder Selection:";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel4.Controls.Add(this.button3);
            this.flowLayoutPanel4.Controls.Add(this.button4);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 237);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(323, 45);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of Plates:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(100, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Select All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(221, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Clear Selection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Plant Configuration";
            // 
            // m_AcquireButton
            // 
            this.m_AcquireButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_AcquireButton.AutoSize = true;
            this.m_AcquireButton.Enabled = false;
            this.m_AcquireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_AcquireButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_AcquireButton.Location = new System.Drawing.Point(89, 470);
            this.m_AcquireButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.m_AcquireButton.Name = "m_AcquireButton";
            this.m_AcquireButton.Size = new System.Drawing.Size(150, 38);
            this.m_AcquireButton.TabIndex = 3;
            this.m_AcquireButton.Text = "Acquire single image";
            this.m_AcquireButton.UseVisualStyleBackColor = true;
            this.m_AcquireButton.Click += new System.EventHandler(this.m_AcquireButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "File Name:";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBox3);
            this.flowLayoutPanel3.Controls.Add(this.textBox2);
            this.flowLayoutPanel3.Controls.Add(this.comboBox1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 184);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(323, 25);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Snow;
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Date & Time +";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(258, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = ".png";
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PictureBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.m_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_PictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_PictureBox.Location = new System.Drawing.Point(329, 0);
            this.m_PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(553, 508);
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
            this.m_LogTable.Location = new System.Drawing.Point(329, 411);
            this.m_LogTable.Name = "m_LogTable";
            this.m_LogTable.RowCount = 2;
            this.m_LogTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_LogTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_LogTable.Size = new System.Drawing.Size(553, 97);
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
            this.m_LogList.Size = new System.Drawing.Size(553, 84);
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
            // CameraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_LogTable);
            this.Controls.Add(this.m_PictureBox);
            this.Controls.Add(this.m_CameraListTable);
            this.Name = "CameraControl";
            this.Size = new System.Drawing.Size(882, 508);
            this.Load += new System.EventHandler(this.CameraControl_Load);
            this.m_CameraListTable.ResumeLayout(false);
            this.m_CameraListTable.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.m_LogTable.ResumeLayout(false);
            this.m_LogTable.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
    }
}
