namespace projprog.Forms
{
	partial class FormPerson
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
            dataGridView = new DataGridView();
            numericUpDownSerial = new NumericUpDown();
            numericUpDownSerpers = new NumericUpDown();
            textBoxFName = new TextBox();
            textBoxLName = new TextBox();
            textBoxMother = new TextBox();
            textBoxFather = new TextBox();
            textBoxReg = new TextBox();
            comboBoxNation = new ComboBox();
            comboBoxAttr = new ComboBox();
            dateTimePickerDbirth = new DateTimePicker();
            checkBoxExst = new CheckBox();
            textBoxNickname = new TextBox();
            textBoxOccupation = new TextBox();
            textBoxArch = new TextBox();
            textBoxMobileno = new TextBox();
            comboBoxStatus = new ComboBox();
            comboBoxGender = new ComboBox();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonCancel = new Button();
            panel1 = new Panel();
            buttonImageFP = new Button();
            buttonImageFace = new Button();
            buttonRefresh = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            comboBoxPBirth = new ComboBox();
            comboBoxResid = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerpers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.Gainsboro;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(590, 20);
            dataGridView.Margin = new Padding(6, 5, 6, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(1140, 1000);
            dataGridView.TabIndex = 1;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // numericUpDownSerial
            // 
            numericUpDownSerial.Location = new Point(490, 20);
            numericUpDownSerial.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSerial.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownSerial.Name = "numericUpDownSerial";
            numericUpDownSerial.Size = new Size(90, 31);
            numericUpDownSerial.TabIndex = 2;
            numericUpDownSerial.ValueChanged += numericUpDownSerial_ValueChanged;
            // 
            // numericUpDownSerpers
            // 
            numericUpDownSerpers.Location = new Point(204, 20);
            numericUpDownSerpers.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSerpers.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownSerpers.Name = "numericUpDownSerpers";
            numericUpDownSerpers.Size = new Size(90, 31);
            numericUpDownSerpers.TabIndex = 3;
            numericUpDownSerpers.ValueChanged += numericUpDownSerpers_ValueChanged;
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(303, 93);
            textBoxFName.Margin = new Padding(4, 5, 4, 5);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(275, 31);
            textBoxFName.TabIndex = 4;
            textBoxFName.TextChanged += textBoxFName_TextChanged;
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(17, 93);
            textBoxLName.Margin = new Padding(4, 5, 4, 5);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(275, 31);
            textBoxLName.TabIndex = 5;
            textBoxLName.TextChanged += textBoxLName_TextChanged;
            // 
            // textBoxMother
            // 
            textBoxMother.Location = new Point(17, 167);
            textBoxMother.Margin = new Padding(4, 5, 4, 5);
            textBoxMother.Name = "textBoxMother";
            textBoxMother.Size = new Size(275, 31);
            textBoxMother.TabIndex = 7;
            textBoxMother.TextChanged += textBoxMother_TextChanged;
            // 
            // textBoxFather
            // 
            textBoxFather.Location = new Point(303, 167);
            textBoxFather.Margin = new Padding(4, 5, 4, 5);
            textBoxFather.Name = "textBoxFather";
            textBoxFather.Size = new Size(275, 31);
            textBoxFather.TabIndex = 6;
            textBoxFather.TextChanged += textBoxFather_TextChanged;
            // 
            // textBoxReg
            // 
            textBoxReg.Location = new Point(17, 240);
            textBoxReg.Margin = new Padding(4, 5, 4, 5);
            textBoxReg.Name = "textBoxReg";
            textBoxReg.Size = new Size(561, 31);
            textBoxReg.TabIndex = 8;
            textBoxReg.TextChanged += textBoxReg_TextChanged;
            // 
            // comboBoxNation
            // 
            comboBoxNation.FormattingEnabled = true;
            comboBoxNation.Location = new Point(17, 313);
            comboBoxNation.Margin = new Padding(4, 5, 4, 5);
            comboBoxNation.Name = "comboBoxNation";
            comboBoxNation.Size = new Size(561, 33);
            comboBoxNation.TabIndex = 9;
            comboBoxNation.SelectedIndexChanged += comboBoxNation_SelectedIndexChanged;
            // 
            // comboBoxAttr
            // 
            comboBoxAttr.FormattingEnabled = true;
            comboBoxAttr.Location = new Point(19, 535);
            comboBoxAttr.Margin = new Padding(4, 5, 4, 5);
            comboBoxAttr.Name = "comboBoxAttr";
            comboBoxAttr.Size = new Size(561, 33);
            comboBoxAttr.TabIndex = 14;
            comboBoxAttr.SelectedIndexChanged += comboBoxAttr_SelectedIndexChanged;
            // 
            // dateTimePickerDbirth
            // 
            dateTimePickerDbirth.Location = new Point(17, 608);
            dateTimePickerDbirth.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerDbirth.Name = "dateTimePickerDbirth";
            dateTimePickerDbirth.Size = new Size(561, 31);
            dateTimePickerDbirth.TabIndex = 15;
            dateTimePickerDbirth.ValueChanged += dateTimePickerDbirth_ValueChanged;
            // 
            // checkBoxExst
            // 
            checkBoxExst.AutoSize = true;
            checkBoxExst.ForeColor = Color.Ivory;
            checkBoxExst.Location = new Point(406, 675);
            checkBoxExst.Margin = new Padding(4, 5, 4, 5);
            checkBoxExst.Name = "checkBoxExst";
            checkBoxExst.RightToLeft = RightToLeft.Yes;
            checkBoxExst.Size = new Size(184, 29);
            checkBoxExst.TabIndex = 17;
            checkBoxExst.Text = "هل يوجد رقم داخلي";
            checkBoxExst.UseVisualStyleBackColor = true;
            checkBoxExst.CheckedChanged += checkBoxExst_CheckedChanged;
            // 
            // textBoxNickname
            // 
            textBoxNickname.Location = new Point(304, 908);
            textBoxNickname.Margin = new Padding(4, 5, 4, 5);
            textBoxNickname.Name = "textBoxNickname";
            textBoxNickname.Size = new Size(275, 31);
            textBoxNickname.TabIndex = 18;
            textBoxNickname.TextChanged += textBoxNickname_TextChanged;
            // 
            // textBoxOccupation
            // 
            textBoxOccupation.Location = new Point(13, 982);
            textBoxOccupation.Margin = new Padding(4, 5, 4, 5);
            textBoxOccupation.Name = "textBoxOccupation";
            textBoxOccupation.Size = new Size(275, 31);
            textBoxOccupation.TabIndex = 19;
            textBoxOccupation.TextChanged += textBoxOccupation_TextChanged;
            // 
            // textBoxArch
            // 
            textBoxArch.Location = new Point(173, 723);
            textBoxArch.Margin = new Padding(4, 5, 4, 5);
            textBoxArch.Name = "textBoxArch";
            textBoxArch.Size = new Size(275, 31);
            textBoxArch.TabIndex = 20;
            textBoxArch.TextChanged += textBoxArch_TextChanged;
            // 
            // textBoxMobileno
            // 
            textBoxMobileno.Location = new Point(13, 908);
            textBoxMobileno.Margin = new Padding(4, 5, 4, 5);
            textBoxMobileno.Name = "textBoxMobileno";
            textBoxMobileno.Size = new Size(275, 31);
            textBoxMobileno.TabIndex = 21;
            textBoxMobileno.TextChanged += textBoxMobileno_TextChanged;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(173, 832);
            comboBoxStatus.Margin = new Padding(4, 5, 4, 5);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(275, 33);
            comboBoxStatus.TabIndex = 22;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(304, 982);
            comboBoxGender.Margin = new Padding(4, 5, 4, 5);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(274, 33);
            comboBoxGender.TabIndex = 23;
            comboBoxGender.SelectedIndexChanged += comboBoxGender_SelectedIndexChanged;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.DarkSeaGreen;
            buttonSave.Location = new Point(1624, 5);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(107, 38);
            buttonSave.TabIndex = 24;
            buttonSave.Text = "ادخال";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.BackColor = Color.DarkSeaGreen;
            buttonDelete.Location = new Point(1509, 5);
            buttonDelete.Margin = new Padding(4, 5, 4, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(107, 38);
            buttonDelete.TabIndex = 25;
            buttonDelete.Text = "حذف";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUpdate.BackColor = Color.DarkSeaGreen;
            buttonUpdate.Location = new Point(1393, 5);
            buttonUpdate.Margin = new Padding(4, 5, 4, 5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(107, 38);
            buttonUpdate.TabIndex = 26;
            buttonUpdate.Text = "تعديل";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.BackColor = Color.DarkSeaGreen;
            buttonCancel.Location = new Point(1277, 5);
            buttonCancel.Margin = new Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(107, 38);
            buttonCancel.TabIndex = 27;
            buttonCancel.Text = "الغاء";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(buttonImageFP);
            panel1.Controls.Add(buttonImageFace);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonUpdate);
            panel1.Location = new Point(0, 1030);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1749, 58);
            panel1.TabIndex = 28;
            // 
            // buttonImageFP
            // 
            buttonImageFP.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonImageFP.BackColor = Color.DarkSeaGreen;
            buttonImageFP.Location = new Point(930, 5);
            buttonImageFP.Margin = new Padding(4, 5, 4, 5);
            buttonImageFP.Name = "buttonImageFP";
            buttonImageFP.Size = new Size(107, 38);
            buttonImageFP.TabIndex = 31;
            buttonImageFP.Text = "بصمات";
            buttonImageFP.UseVisualStyleBackColor = false;
            buttonImageFP.Click += buttonImageFP_Click;
            // 
            // buttonImageFace
            // 
            buttonImageFace.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonImageFace.BackColor = Color.DarkSeaGreen;
            buttonImageFace.Location = new Point(1046, 5);
            buttonImageFace.Margin = new Padding(4, 5, 4, 5);
            buttonImageFace.Name = "buttonImageFace";
            buttonImageFace.Size = new Size(107, 38);
            buttonImageFace.TabIndex = 30;
            buttonImageFace.Text = "صور";
            buttonImageFace.UseVisualStyleBackColor = false;
            buttonImageFace.Click += buttonImageFace_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRefresh.BackColor = Color.DarkSeaGreen;
            buttonRefresh.Location = new Point(1161, 5);
            buttonRefresh.Margin = new Padding(4, 5, 4, 5);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(107, 38);
            buttonRefresh.TabIndex = 29;
            buttonRefresh.Text = "تحديث";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(313, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 29;
            label1.Text = "الرقم المتسلسل للملف";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Ivory;
            label3.Location = new Point(13, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 31;
            label3.Text = "الرقم المتسلسل للشخص";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Ivory;
            label2.Location = new Point(531, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 32;
            label2.Text = "الاسم";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Ivory;
            label4.Location = new Point(237, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 33;
            label4.Text = "الشهرة";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Ivory;
            label5.Location = new Point(507, 137);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 34;
            label5.Text = "اسم الاب";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Ivory;
            label6.Location = new Point(227, 137);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 35;
            label6.Text = "اسم الامّ";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Ivory;
            label7.Location = new Point(449, 210);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 25);
            label7.TabIndex = 36;
            label7.Text = "رقم ومكان السجل";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Ivory;
            label8.Location = new Point(516, 283);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 37;
            label8.Text = "الجنسية";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Ivory;
            label9.Location = new Point(489, 357);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 25);
            label9.TabIndex = 38;
            label9.Text = "محل الولادة";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Ivory;
            label10.Location = new Point(487, 430);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(101, 25);
            label10.TabIndex = 39;
            label10.Text = "محل الاقامة";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Ivory;
            label11.Location = new Point(527, 503);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(56, 25);
            label11.TabIndex = 40;
            label11.Text = "الصلة";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Ivory;
            label12.Location = new Point(486, 578);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(104, 25);
            label12.TabIndex = 41;
            label12.Text = "تاريخ الولادة";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Honeydew;
            label13.Location = new Point(531, 875);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(55, 25);
            label13.TabIndex = 42;
            label13.Text = "اللقب";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Ivory;
            label14.Location = new Point(270, 693);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(111, 25);
            label14.TabIndex = 43;
            label14.Text = "الرقم الداخلي";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Honeydew;
            label15.Location = new Point(227, 952);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(58, 25);
            label15.TabIndex = 44;
            label15.Text = "المهنة";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Honeydew;
            label16.Location = new Point(270, 802);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(134, 25);
            label16.TabIndex = 45;
            label16.Text = "الحالة الاجتماعية";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Honeydew;
            label17.Location = new Point(210, 875);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(92, 25);
            label17.TabIndex = 46;
            label17.Text = "رقم الهاتف";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Honeydew;
            label18.Location = new Point(524, 952);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(61, 25);
            label18.TabIndex = 47;
            label18.Text = "الجنس";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxPBirth
            // 
            comboBoxPBirth.FormattingEnabled = true;
            comboBoxPBirth.Location = new Point(17, 387);
            comboBoxPBirth.Margin = new Padding(4, 5, 4, 5);
            comboBoxPBirth.Name = "comboBoxPBirth";
            comboBoxPBirth.Size = new Size(561, 33);
            comboBoxPBirth.TabIndex = 48;
            comboBoxPBirth.SelectedIndexChanged += comboBoxPBirth_SelectedIndexChanged;
            // 
            // comboBoxResid
            // 
            comboBoxResid.FormattingEnabled = true;
            comboBoxResid.Location = new Point(19, 460);
            comboBoxResid.Margin = new Padding(4, 5, 4, 5);
            comboBoxResid.Name = "comboBoxResid";
            comboBoxResid.Size = new Size(561, 33);
            comboBoxResid.TabIndex = 49;
            comboBoxResid.SelectedIndexChanged += comboBoxResid_SelectedIndexChanged;
            // 
            // FormPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1749, 1088);
            Controls.Add(comboBoxResid);
            Controls.Add(comboBoxPBirth);
            Controls.Add(panel1);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBoxGender);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxMobileno);
            Controls.Add(textBoxArch);
            Controls.Add(textBoxOccupation);
            Controls.Add(textBoxNickname);
            Controls.Add(checkBoxExst);
            Controls.Add(dateTimePickerDbirth);
            Controls.Add(comboBoxAttr);
            Controls.Add(comboBoxNation);
            Controls.Add(textBoxReg);
            Controls.Add(textBoxMother);
            Controls.Add(textBoxFather);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxFName);
            Controls.Add(numericUpDownSerpers);
            Controls.Add(numericUpDownSerial);
            Controls.Add(dataGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPerson";
            Text = "FormPerson";
            Load += FormPerson_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerpers).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
		private NumericUpDown numericUpDownSerial;
		private NumericUpDown numericUpDownSerpers;
		private TextBox textBoxFName;
		private TextBox textBoxLName;
		private TextBox textBoxMother;
		private TextBox textBoxFather;
		private TextBox textBoxReg;
		private ComboBox comboBoxNation;
		private ComboBox comboBoxAttr;
		private DateTimePicker dateTimePickerDbirth;
		private CheckBox checkBoxExst;
		private TextBox textBoxNickname;
		private TextBox textBoxOccupation;
		private TextBox textBoxArch;
		private TextBox textBoxMobileno;
		private ComboBox comboBoxStatus;
		private ComboBox comboBoxGender;
		private Button buttonSave;
		private Button buttonDelete;
		private Button buttonUpdate;
		private Button buttonCancel;
		private Panel panel1;
		private Label label1;
		private Label label3;
		private Label label2;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label15;
		private Label label16;
		private Label label17;
		private Label label18;
		private Button buttonRefresh;
		private ComboBox comboBoxPBirth;
		private ComboBox comboBoxResid;
		private Button buttonImageFace;
		private Button buttonImageFP;
	}
}