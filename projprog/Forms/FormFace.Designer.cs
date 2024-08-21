namespace projprog.Forms
{
	partial class FormFace
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label1 = new Label();
            numericUpDownSerpers = new NumericUpDown();
            numericUpDownSerial = new NumericUpDown();
            buttonDeleteCenter = new Button();
            buttonDeleteLeft = new Button();
            buttonUpdateCenter = new Button();
            buttonUpdateLeft = new Button();
            pictureBoxLeft = new PictureBox();
            pictureBoxCenter = new PictureBox();
            buttonDeleteRight = new Button();
            buttonUpdateRight = new Button();
            pictureBoxRight = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerpers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCenter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRight).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 647);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 46;
            label3.Text = "الرقم المتسلسل للشخص";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(699, 650);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 45;
            label1.Text = "الرقم المتسلسل للملف";
            // 
            // numericUpDownSerpers
            // 
            numericUpDownSerpers.Enabled = false;
            numericUpDownSerpers.Location = new Point(559, 643);
            numericUpDownSerpers.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSerpers.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownSerpers.Name = "numericUpDownSerpers";
            numericUpDownSerpers.Size = new Size(90, 31);
            numericUpDownSerpers.TabIndex = 44;
            // 
            // numericUpDownSerial
            // 
            numericUpDownSerial.Enabled = false;
            numericUpDownSerial.Location = new Point(876, 647);
            numericUpDownSerial.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSerial.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownSerial.Name = "numericUpDownSerial";
            numericUpDownSerial.Size = new Size(90, 31);
            numericUpDownSerial.TabIndex = 43;
            // 
            // buttonDeleteCenter
            // 
            buttonDeleteCenter.BackColor = Color.DarkSeaGreen;
            buttonDeleteCenter.Location = new Point(660, 552);
            buttonDeleteCenter.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteCenter.Name = "buttonDeleteCenter";
            buttonDeleteCenter.Size = new Size(107, 38);
            buttonDeleteCenter.TabIndex = 42;
            buttonDeleteCenter.Text = "حذف";
            buttonDeleteCenter.UseVisualStyleBackColor = false;
            buttonDeleteCenter.Click += buttonDeleteCenter_Click;
            // 
            // buttonDeleteLeft
            // 
            buttonDeleteLeft.BackColor = Color.DarkSeaGreen;
            buttonDeleteLeft.Location = new Point(223, 552);
            buttonDeleteLeft.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteLeft.Name = "buttonDeleteLeft";
            buttonDeleteLeft.Size = new Size(107, 38);
            buttonDeleteLeft.TabIndex = 41;
            buttonDeleteLeft.Text = "حذف";
            buttonDeleteLeft.UseVisualStyleBackColor = false;
            buttonDeleteLeft.Click += buttonDeleteLeft_Click;
            // 
            // buttonUpdateCenter
            // 
            buttonUpdateCenter.BackColor = Color.DarkSeaGreen;
            buttonUpdateCenter.Location = new Point(544, 552);
            buttonUpdateCenter.Margin = new Padding(4, 5, 4, 5);
            buttonUpdateCenter.Name = "buttonUpdateCenter";
            buttonUpdateCenter.Size = new Size(107, 38);
            buttonUpdateCenter.TabIndex = 40;
            buttonUpdateCenter.Text = "تعديل";
            buttonUpdateCenter.UseVisualStyleBackColor = false;
            buttonUpdateCenter.Click += buttonUpdateCenter_Click;
            // 
            // buttonUpdateLeft
            // 
            buttonUpdateLeft.BackColor = Color.DarkSeaGreen;
            buttonUpdateLeft.Location = new Point(107, 552);
            buttonUpdateLeft.Margin = new Padding(4, 5, 4, 5);
            buttonUpdateLeft.Name = "buttonUpdateLeft";
            buttonUpdateLeft.Size = new Size(107, 38);
            buttonUpdateLeft.TabIndex = 39;
            buttonUpdateLeft.Text = "تعديل";
            buttonUpdateLeft.UseVisualStyleBackColor = false;
            buttonUpdateLeft.Click += buttonUpdateLeft_Click;
            // 
            // pictureBoxLeft
            // 
            pictureBoxLeft.BackColor = SystemColors.ControlLight;
            pictureBoxLeft.InitialImage = null;
            pictureBoxLeft.Location = new Point(17, 42);
            pictureBoxLeft.Margin = new Padding(4, 5, 4, 5);
            pictureBoxLeft.Name = "pictureBoxLeft";
            pictureBoxLeft.Size = new Size(429, 500);
            pictureBoxLeft.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLeft.TabIndex = 38;
            pictureBoxLeft.TabStop = false;
            // 
            // pictureBoxCenter
            // 
            pictureBoxCenter.BackColor = SystemColors.ControlLight;
            pictureBoxCenter.InitialImage = null;
            pictureBoxCenter.Location = new Point(454, 42);
            pictureBoxCenter.Margin = new Padding(4, 5, 4, 5);
            pictureBoxCenter.Name = "pictureBoxCenter";
            pictureBoxCenter.Size = new Size(429, 500);
            pictureBoxCenter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCenter.TabIndex = 37;
            pictureBoxCenter.TabStop = false;
            // 
            // buttonDeleteRight
            // 
            buttonDeleteRight.BackColor = Color.DarkSeaGreen;
            buttonDeleteRight.Location = new Point(1097, 552);
            buttonDeleteRight.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteRight.Name = "buttonDeleteRight";
            buttonDeleteRight.Size = new Size(107, 38);
            buttonDeleteRight.TabIndex = 50;
            buttonDeleteRight.Text = "حذف";
            buttonDeleteRight.UseVisualStyleBackColor = false;
            buttonDeleteRight.Click += buttonDeleteRight_Click;
            // 
            // buttonUpdateRight
            // 
            buttonUpdateRight.BackColor = Color.DarkSeaGreen;
            buttonUpdateRight.Location = new Point(981, 552);
            buttonUpdateRight.Margin = new Padding(4, 5, 4, 5);
            buttonUpdateRight.Name = "buttonUpdateRight";
            buttonUpdateRight.Size = new Size(107, 38);
            buttonUpdateRight.TabIndex = 49;
            buttonUpdateRight.Text = "تعديل";
            buttonUpdateRight.UseVisualStyleBackColor = false;
            buttonUpdateRight.Click += buttonUpdateRight_Click;
            // 
            // pictureBoxRight
            // 
            pictureBoxRight.BackColor = SystemColors.ControlLight;
            pictureBoxRight.InitialImage = null;
            pictureBoxRight.Location = new Point(891, 42);
            pictureBoxRight.Margin = new Padding(4, 5, 4, 5);
            pictureBoxRight.Name = "pictureBoxRight";
            pictureBoxRight.Size = new Size(429, 500);
            pictureBoxRight.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRight.TabIndex = 48;
            pictureBoxRight.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(609, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 51;
            label2.Text = "FRONT FACE";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(241, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 52;
            label4.Text = "LEFT FACE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(1074, 12);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 53;
            label5.Text = "RIGHT FACE";
            label5.Click += label5_Click;
            // 
            // FormFace
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1337, 767);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(buttonDeleteRight);
            Controls.Add(buttonUpdateRight);
            Controls.Add(pictureBoxRight);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(numericUpDownSerpers);
            Controls.Add(numericUpDownSerial);
            Controls.Add(buttonDeleteCenter);
            Controls.Add(buttonDeleteLeft);
            Controls.Add(buttonUpdateCenter);
            Controls.Add(buttonUpdateLeft);
            Controls.Add(pictureBoxLeft);
            Controls.Add(pictureBoxCenter);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormFace";
            Text = "FormFace";
            Load += FormFace_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerpers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCenter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
		private Label label1;
		private NumericUpDown numericUpDownSerpers;
		private NumericUpDown numericUpDownSerial;
		private Button buttonDeleteCenter;
		private Button buttonDeleteLeft;
		private Button buttonUpdateCenter;
		private Button buttonUpdateLeft;
		private PictureBox pictureBoxLeft;
		private PictureBox pictureBoxCenter;
		private Button buttonDeleteRight;
		private Button buttonUpdateRight;
		private PictureBox pictureBoxRight;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}