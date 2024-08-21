namespace projprog.Forms
{
	partial class FormFP
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
            pictureBoxRight = new PictureBox();
            pictureBoxLeft = new PictureBox();
            buttonUpdateLeft = new Button();
            buttonUpdateRight = new Button();
            buttonDeleteLeft = new Button();
            buttonDeleteRight = new Button();
            label3 = new Label();
            label1 = new Label();
            numericUpDownSerpers = new NumericUpDown();
            numericUpDownSerial = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerpers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxRight
            // 
            pictureBoxRight.BackColor = Color.Gainsboro;
            pictureBoxRight.InitialImage = null;
            pictureBoxRight.Location = new Point(499, 45);
            pictureBoxRight.Margin = new Padding(4, 5, 4, 5);
            pictureBoxRight.Name = "pictureBoxRight";
            pictureBoxRight.Size = new Size(429, 500);
            pictureBoxRight.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRight.TabIndex = 0;
            pictureBoxRight.TabStop = false;
            pictureBoxRight.Click += pictureBoxRight_Click;
            // 
            // pictureBoxLeft
            // 
            pictureBoxLeft.BackColor = Color.Gainsboro;
            pictureBoxLeft.InitialImage = null;
            pictureBoxLeft.Location = new Point(17, 45);
            pictureBoxLeft.Margin = new Padding(4, 5, 4, 5);
            pictureBoxLeft.Name = "pictureBoxLeft";
            pictureBoxLeft.Size = new Size(429, 500);
            pictureBoxLeft.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLeft.TabIndex = 1;
            pictureBoxLeft.TabStop = false;
            pictureBoxLeft.Click += pictureBoxLeft_Click;
            // 
            // buttonUpdateLeft
            // 
            buttonUpdateLeft.BackColor = Color.DarkSeaGreen;
            buttonUpdateLeft.Location = new Point(236, 580);
            buttonUpdateLeft.Margin = new Padding(4, 5, 4, 5);
            buttonUpdateLeft.Name = "buttonUpdateLeft";
            buttonUpdateLeft.Size = new Size(107, 38);
            buttonUpdateLeft.TabIndex = 2;
            buttonUpdateLeft.Text = "تعديل";
            buttonUpdateLeft.UseVisualStyleBackColor = false;
            buttonUpdateLeft.Click += buttonUpdateLeft_Click;
            // 
            // buttonUpdateRight
            // 
            buttonUpdateRight.BackColor = Color.DarkSeaGreen;
            buttonUpdateRight.Location = new Point(716, 575);
            buttonUpdateRight.Margin = new Padding(4, 5, 4, 5);
            buttonUpdateRight.Name = "buttonUpdateRight";
            buttonUpdateRight.Size = new Size(107, 38);
            buttonUpdateRight.TabIndex = 3;
            buttonUpdateRight.Text = "تعديل";
            buttonUpdateRight.UseVisualStyleBackColor = false;
            buttonUpdateRight.Click += buttonUpdateRight_Click;
            // 
            // buttonDeleteLeft
            // 
            buttonDeleteLeft.BackColor = Color.DarkSeaGreen;
            buttonDeleteLeft.Location = new Point(120, 580);
            buttonDeleteLeft.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteLeft.Name = "buttonDeleteLeft";
            buttonDeleteLeft.Size = new Size(107, 38);
            buttonDeleteLeft.TabIndex = 4;
            buttonDeleteLeft.Text = "حذف";
            buttonDeleteLeft.UseVisualStyleBackColor = false;
            buttonDeleteLeft.Click += buttonDeleteLeft_Click;
            // 
            // buttonDeleteRight
            // 
            buttonDeleteRight.BackColor = Color.DarkSeaGreen;
            buttonDeleteRight.Location = new Point(581, 575);
            buttonDeleteRight.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteRight.Name = "buttonDeleteRight";
            buttonDeleteRight.Size = new Size(107, 38);
            buttonDeleteRight.TabIndex = 5;
            buttonDeleteRight.Text = "حذف";
            buttonDeleteRight.UseVisualStyleBackColor = false;
            buttonDeleteRight.Click += buttonDeleteRight_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(307, 623);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 35;
            label3.Text = "الرقم المتسلسل للشخص";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(607, 623);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 34;
            label1.Text = "الرقم المتسلسل للملف";
            // 
            // numericUpDownSerpers
            // 
            numericUpDownSerpers.Enabled = false;
            numericUpDownSerpers.Location = new Point(499, 620);
            numericUpDownSerpers.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSerpers.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownSerpers.Name = "numericUpDownSerpers";
            numericUpDownSerpers.Size = new Size(90, 31);
            numericUpDownSerpers.TabIndex = 33;
            // 
            // numericUpDownSerial
            // 
            numericUpDownSerial.Enabled = false;
            numericUpDownSerial.Location = new Point(784, 623);
            numericUpDownSerial.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSerial.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownSerial.Name = "numericUpDownSerial";
            numericUpDownSerial.Size = new Size(90, 31);
            numericUpDownSerial.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(691, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 37;
            label2.Text = "ابهام ايمن";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(176, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 38;
            label4.Text = "ابهام ايسر";
            // 
            // FormFP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(944, 678);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(numericUpDownSerpers);
            Controls.Add(numericUpDownSerial);
            Controls.Add(buttonDeleteRight);
            Controls.Add(buttonDeleteLeft);
            Controls.Add(buttonUpdateRight);
            Controls.Add(buttonUpdateLeft);
            Controls.Add(pictureBoxLeft);
            Controls.Add(pictureBoxRight);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormFP";
            Text = "FormFP";
            Load += FormFP_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerpers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxRight;
		private PictureBox pictureBoxLeft;
		private Button buttonUpdateLeft;
		private Button buttonUpdateRight;
		private Button buttonDeleteLeft;
		private Button buttonDeleteRight;
		private Label label3;
		private Label label1;
		private NumericUpDown numericUpDownSerpers;
		private NumericUpDown numericUpDownSerial;
        private Label label2;
        private Label label4;
    }
}