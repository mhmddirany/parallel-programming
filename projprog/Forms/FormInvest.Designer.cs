namespace projprog.Forms
{
	partial class FormInvest
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
            comboBoxCrime = new ComboBox();
            dataGridView = new DataGridView();
            dateTimePickerDFile = new DateTimePicker();
            dateTimePickerDMahdar = new DateTimePicker();
            richTextBoxRem = new RichTextBox();
            checkBoxResume = new CheckBox();
            checkBoxMadbout = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonCancel = new Button();
            buttonPeople = new Button();
            buttonRefresh = new Button();
            buttonVehicles = new Button();
            button9 = new Button();
            numericUpDownSerial = new NumericUpDown();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxCrime
            // 
            comboBoxCrime.FormattingEnabled = true;
            comboBoxCrime.Location = new Point(19, 165);
            comboBoxCrime.Margin = new Padding(6, 5, 6, 5);
            comboBoxCrime.Name = "comboBoxCrime";
            comboBoxCrime.Size = new Size(465, 33);
            comboBoxCrime.TabIndex = 4;
            comboBoxCrime.SelectedIndexChanged += comboBoxCrime_SelectedIndexChanged;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(619, 20);
            dataGridView.Margin = new Padding(6, 5, 6, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(971, 877);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // dateTimePickerDFile
            // 
            dateTimePickerDFile.Location = new Point(19, 68);
            dateTimePickerDFile.Margin = new Padding(6, 5, 6, 5);
            dateTimePickerDFile.Name = "dateTimePickerDFile";
            dateTimePickerDFile.Size = new Size(465, 31);
            dateTimePickerDFile.TabIndex = 1;
            dateTimePickerDFile.ValueChanged += dateTimePickerDFile_ValueChanged;
            // 
            // dateTimePickerDMahdar
            // 
            dateTimePickerDMahdar.Location = new Point(19, 117);
            dateTimePickerDMahdar.Margin = new Padding(6, 5, 6, 5);
            dateTimePickerDMahdar.Name = "dateTimePickerDMahdar";
            dateTimePickerDMahdar.Size = new Size(465, 31);
            dateTimePickerDMahdar.TabIndex = 2;
            dateTimePickerDMahdar.ValueChanged += dateTimePickerDMahdar_ValueChanged;
            // 
            // richTextBoxRem
            // 
            richTextBoxRem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            richTextBoxRem.BackColor = Color.DarkSeaGreen;
            richTextBoxRem.Location = new Point(19, 238);
            richTextBoxRem.Margin = new Padding(6, 5, 6, 5);
            richTextBoxRem.Name = "richTextBoxRem";
            richTextBoxRem.Size = new Size(593, 354);
            richTextBoxRem.TabIndex = 5;
            richTextBoxRem.Text = "";
            richTextBoxRem.TextChanged += richTextBoxRem_TextChanged;
            // 
            // checkBoxResume
            // 
            checkBoxResume.AutoSize = true;
            checkBoxResume.ForeColor = SystemColors.ButtonHighlight;
            checkBoxResume.Location = new Point(397, 12);
            checkBoxResume.Margin = new Padding(6, 5, 6, 5);
            checkBoxResume.Name = "checkBoxResume";
            checkBoxResume.Size = new Size(159, 29);
            checkBoxResume.TabIndex = 6;
            checkBoxResume.Text = "هل يوجد ملخص";
            checkBoxResume.UseVisualStyleBackColor = true;
            checkBoxResume.CheckedChanged += checkBoxResume_CheckedChanged;
            // 
            // checkBoxMadbout
            // 
            checkBoxMadbout.AutoSize = true;
            checkBoxMadbout.ForeColor = SystemColors.ButtonHighlight;
            checkBoxMadbout.Location = new Point(164, 11);
            checkBoxMadbout.Margin = new Padding(6, 5, 6, 5);
            checkBoxMadbout.Name = "checkBoxMadbout";
            checkBoxMadbout.Size = new Size(188, 29);
            checkBoxMadbout.TabIndex = 7;
            checkBoxMadbout.Text = "هل يوجد مضبوطات";
            checkBoxMadbout.UseVisualStyleBackColor = true;
            checkBoxMadbout.CheckedChanged += checkBoxMadbout_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(529, 25);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 9;
            label1.Text = "المتسلسل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(511, 78);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 10;
            label2.Text = "تاريخ الادخال";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(501, 127);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 11;
            label3.Text = "تاريخ المعاملة";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(561, 170);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 13;
            label5.Text = "الجرم";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(473, 208);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 25);
            label6.TabIndex = 14;
            label6.Text = "موضوع المعاملة";
            label6.Click += label6_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.DarkSeaGreen;
            buttonSave.Location = new Point(1481, 5);
            buttonSave.Margin = new Padding(6, 5, 6, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(109, 37);
            buttonSave.TabIndex = 15;
            buttonSave.Text = "ادخال";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.BackColor = Color.DarkSeaGreen;
            buttonDelete.Location = new Point(1241, 5);
            buttonDelete.Margin = new Padding(6, 5, 6, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(109, 37);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "حذف";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUpdate.BackColor = Color.DarkSeaGreen;
            buttonUpdate.Location = new Point(1361, 5);
            buttonUpdate.Margin = new Padding(6, 5, 6, 5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(109, 37);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "تعديل";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.BackColor = Color.DarkSeaGreen;
            buttonCancel.Location = new Point(1001, 5);
            buttonCancel.Margin = new Padding(6, 5, 6, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 37);
            buttonCancel.TabIndex = 20;
            buttonCancel.Text = "الغاء";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonPeople
            // 
            buttonPeople.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPeople.BackColor = Color.DarkSeaGreen;
            buttonPeople.Location = new Point(881, 5);
            buttonPeople.Margin = new Padding(6, 5, 6, 5);
            buttonPeople.Name = "buttonPeople";
            buttonPeople.Size = new Size(109, 37);
            buttonPeople.TabIndex = 19;
            buttonPeople.Text = "اشخاص";
            buttonPeople.UseVisualStyleBackColor = false;
            buttonPeople.Click += buttonPeople_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRefresh.BackColor = Color.DarkSeaGreen;
            buttonRefresh.Location = new Point(1121, 5);
            buttonRefresh.Margin = new Padding(6, 5, 6, 5);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(109, 37);
            buttonRefresh.TabIndex = 18;
            buttonRefresh.Text = "تحديث";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonVehicles
            // 
            buttonVehicles.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonVehicles.BackColor = Color.DarkSeaGreen;
            buttonVehicles.Location = new Point(641, 5);
            buttonVehicles.Margin = new Padding(6, 5, 6, 5);
            buttonVehicles.Name = "buttonVehicles";
            buttonVehicles.Size = new Size(109, 37);
            buttonVehicles.TabIndex = 23;
            buttonVehicles.Text = "سيارات";
            buttonVehicles.UseVisualStyleBackColor = false;
            buttonVehicles.Click += buttonVehicles_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.BackColor = Color.DarkSeaGreen;
            button9.Location = new Point(761, 5);
            button9.Margin = new Padding(6, 5, 6, 5);
            button9.Name = "button9";
            button9.Size = new Size(109, 37);
            button9.TabIndex = 21;
            button9.Text = "تصنيف";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // numericUpDownSerial
            // 
            numericUpDownSerial.Location = new Point(19, 22);
            numericUpDownSerial.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSerial.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownSerial.Name = "numericUpDownSerial";
            numericUpDownSerial.Size = new Size(467, 31);
            numericUpDownSerial.TabIndex = 24;
            numericUpDownSerial.ValueChanged += numericUpDownSerial_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonVehicles);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(checkBoxMadbout);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(checkBoxResume);
            panel1.Controls.Add(buttonPeople);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 907);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1609, 58);
            panel1.TabIndex = 26;
            // 
            // FormInvest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1609, 965);
            Controls.Add(panel1);
            Controls.Add(numericUpDownSerial);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBoxRem);
            Controls.Add(comboBoxCrime);
            Controls.Add(dateTimePickerDMahdar);
            Controls.Add(dateTimePickerDFile);
            Controls.Add(dataGridView);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormInvest";
            Text = "FormInvest";
            Load += FormInvest_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
		private DateTimePicker dateTimePickerDFile;
		private DateTimePicker dateTimePickerDMahdar;
		private RichTextBox richTextBoxRem;
		private CheckBox checkBoxResume;
		private CheckBox checkBoxMadbout;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label5;
		private Label label6;
		private Button buttonSave;
		private Button buttonDelete;
		private Button buttonUpdate;
		private Button buttonCancel;
		private Button buttonPeople;
		private Button buttonRefresh;
		private Button buttonVehicles;
		private Button button9;
		private NumericUpDown numericUpDownSerial;
		private Panel panel1;
        public ComboBox comboBoxCrime;
    }
}