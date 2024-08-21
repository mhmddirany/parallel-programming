namespace projprog.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBox1 = new PictureBox();
            Lebanese = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(300, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 427);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Lebanese
            // 
            Lebanese.AutoSize = true;
            Lebanese.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Lebanese.Location = new Point(28, 90);
            Lebanese.Name = "Lebanese";
            Lebanese.Size = new Size(256, 56);
            Lebanese.TabIndex = 1;
            Lebanese.Text = "Lebanese";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 28F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(98, 146);
            label1.Name = "label1";
            label1.Size = new Size(108, 73);
            label1.TabIndex = 2;
            label1.Text = "FBI";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Tempus Sans ITC", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(60, 281);
            button1.Name = "button1";
            button1.Size = new Size(196, 113);
            button1.TabIndex = 3;
            button1.Text = "Investigate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Lebanese);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Lebanese;
        private Label label1;
        private Button button1;
    }
}