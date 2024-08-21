namespace projprog.Forms
{
	partial class FormVehicle
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
            labelStatus = new Label();
            panel1 = new Panel();
            buttonRefresh = new Button();
            buttonCancel = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            label2 = new Label();
            numericUpDownVid = new NumericUpDown();
            label4 = new Label();
            textBoxVNumber = new TextBox();
            label5 = new Label();
            label3 = new Label();
            numericUpDownSerial = new NumericUpDown();
            comboBoxCode = new ComboBox();
            label6 = new Label();
            textBoxFName = new TextBox();
            label17 = new Label();
            textBoxMobileno = new TextBox();
            label7 = new Label();
            textBoxMother = new TextBox();
            label8 = new Label();
            textBoxLName = new TextBox();
            numericUpDownAge = new NumericUpDown();
            label9 = new Label();
            comboBoxPBirth = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            textBoxAddress = new TextBox();
            label12 = new Label();
            textBoxReg = new TextBox();
            label13 = new Label();
            dateTimePickerProd = new DateTimePicker();
            label14 = new Label();
            textBoxChassis = new TextBox();
            label15 = new Label();
            textBoxMotor = new TextBox();
            label16 = new Label();
            textBoxColor = new TextBox();
            label18 = new Label();
            textBoxUtilis = new TextBox();
            label19 = new Label();
            textBoxModel = new TextBox();
            label20 = new Label();
            textBoxBrand = new TextBox();
            label21 = new Label();
            dateTimePickerAquisition = new DateTimePicker();
            comboBoxCity = new ComboBox();
            label22 = new Label();
            label23 = new Label();
            numericUpDownPreMiseCirc = new NumericUpDown();
            checkBoxInCirculation = new CheckBox();
            label24 = new Label();
            textBoxIqama = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreMiseCirc).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.Gainsboro;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(602, 20);
            dataGridView.Margin = new Padding(6, 5, 6, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(1182, 850);
            dataGridView.TabIndex = 85;
            // 
            // labelStatus
            // 
            labelStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.Lime;
            labelStatus.BorderStyle = BorderStyle.FixedSingle;
            labelStatus.Cursor = Cursors.SizeNS;
            labelStatus.Location = new Point(17, -97);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(62, 27);
            labelStatus.TabIndex = 28;
            labelStatus.Text = "Ready";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(labelStatus);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 880);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1803, 58);
            panel1.TabIndex = 29;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRefresh.BackColor = Color.DarkSeaGreen;
            buttonRefresh.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            buttonRefresh.ForeColor = Color.FromArgb(64, 64, 64);
            buttonRefresh.Location = new Point(844, 12);
            buttonRefresh.Margin = new Padding(4, 5, 4, 5);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(107, 38);
            buttonRefresh.TabIndex = 36;
            buttonRefresh.Text = "تحديث";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.BackColor = Color.DarkSeaGreen;
            buttonCancel.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            buttonCancel.ForeColor = Color.FromArgb(64, 64, 64);
            buttonCancel.Location = new Point(957, 12);
            buttonCancel.Margin = new Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(107, 38);
            buttonCancel.TabIndex = 35;
            buttonCancel.Text = "الغاء";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.DarkSeaGreen;
            buttonSave.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            buttonSave.FlatAppearance.BorderSize = 2;
            buttonSave.ForeColor = Color.FromArgb(64, 64, 64);
            buttonSave.Location = new Point(1304, 12);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(107, 38);
            buttonSave.TabIndex = 32;
            buttonSave.Text = "ادخال";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.BackColor = Color.DarkSeaGreen;
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            buttonDelete.ForeColor = Color.FromArgb(64, 64, 64);
            buttonDelete.Location = new Point(1189, 12);
            buttonDelete.Margin = new Padding(4, 5, 4, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(107, 38);
            buttonDelete.TabIndex = 33;
            buttonDelete.Text = "حذف";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUpdate.BackColor = Color.DarkSeaGreen;
            buttonUpdate.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            buttonUpdate.ForeColor = Color.FromArgb(64, 64, 64);
            buttonUpdate.Location = new Point(1073, 12);
            buttonUpdate.Margin = new Padding(4, 5, 4, 5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(107, 38);
            buttonUpdate.TabIndex = 34;
            buttonUpdate.Text = "تعديل";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(313, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 31;
            label2.Text = "الرقم المتسلسل للسيارة";
            // 
            // numericUpDownVid
            // 
            numericUpDownVid.Location = new Point(490, 20);
            numericUpDownVid.Margin = new Padding(4, 5, 4, 5);
            numericUpDownVid.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownVid.Name = "numericUpDownVid";
            numericUpDownVid.Size = new Size(90, 31);
            numericUpDownVid.TabIndex = 30;
            numericUpDownVid.ValueChanged += numericUpDownVid_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(493, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 35;
            label4.Text = "رقم السيارة";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // textBoxVNumber
            // 
            textBoxVNumber.BackColor = Color.White;
            textBoxVNumber.Location = new Point(303, 93);
            textBoxVNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxVNumber.Name = "textBoxVNumber";
            textBoxVNumber.Size = new Size(275, 31);
            textBoxVNumber.TabIndex = 34;
            textBoxVNumber.TextChanged += textBoxVNumber_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(251, 63);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 37;
            label5.Text = "الرمز";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(62, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 33;
            label3.Text = "الرقم المتسلسل ";
            // 
            // numericUpDownSerial
            // 
            numericUpDownSerial.Location = new Point(204, 20);
            numericUpDownSerial.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSerial.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownSerial.Name = "numericUpDownSerial";
            numericUpDownSerial.Size = new Size(90, 31);
            numericUpDownSerial.TabIndex = 32;
            numericUpDownSerial.ValueChanged += numericUpDownSerial_ValueChanged;
            // 
            // comboBoxCode
            // 
            comboBoxCode.FormattingEnabled = true;
            comboBoxCode.Location = new Point(17, 93);
            comboBoxCode.Margin = new Padding(4, 5, 4, 5);
            comboBoxCode.Name = "comboBoxCode";
            comboBoxCode.Size = new Size(275, 33);
            comboBoxCode.TabIndex = 38;
            comboBoxCode.SelectedIndexChanged += comboBoxCode_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(531, 137);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 40;
            label6.Text = "الاسم";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(303, 167);
            textBoxFName.Margin = new Padding(4, 5, 4, 5);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(275, 31);
            textBoxFName.TabIndex = 39;
            textBoxFName.TextChanged += textBoxFName_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.Location = new Point(210, 137);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(92, 25);
            label17.TabIndex = 48;
            label17.Text = "رقم الهاتف";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxMobileno
            // 
            textBoxMobileno.Location = new Point(17, 167);
            textBoxMobileno.Margin = new Padding(4, 5, 4, 5);
            textBoxMobileno.Name = "textBoxMobileno";
            textBoxMobileno.Size = new Size(275, 31);
            textBoxMobileno.TabIndex = 47;
            textBoxMobileno.TextChanged += textBoxMobileno_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(513, 210);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 50;
            label7.Text = "اسم الامّ";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxMother
            // 
            textBoxMother.Location = new Point(303, 240);
            textBoxMother.Margin = new Padding(4, 5, 4, 5);
            textBoxMother.Name = "textBoxMother";
            textBoxMother.Size = new Size(275, 31);
            textBoxMother.TabIndex = 49;
            textBoxMother.TextChanged += textBoxMother_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(523, 283);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 52;
            label8.Text = "الشهرة";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(303, 313);
            textBoxLName.Margin = new Padding(4, 5, 4, 5);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(275, 31);
            textBoxLName.TabIndex = 51;
            textBoxLName.TextChanged += textBoxLName_TextChanged;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(303, 387);
            numericUpDownAge.Margin = new Padding(4, 5, 4, 5);
            numericUpDownAge.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(277, 31);
            numericUpDownAge.TabIndex = 53;
            numericUpDownAge.ValueChanged += numericUpDownAge_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(533, 357);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 25);
            label9.TabIndex = 54;
            label9.Text = "العمر";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxPBirth
            // 
            comboBoxPBirth.FormattingEnabled = true;
            comboBoxPBirth.Location = new Point(303, 460);
            comboBoxPBirth.Margin = new Padding(4, 5, 4, 5);
            comboBoxPBirth.Name = "comboBoxPBirth";
            comboBoxPBirth.Size = new Size(275, 33);
            comboBoxPBirth.TabIndex = 56;
            comboBoxPBirth.SelectedIndexChanged += comboBoxPBirth_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(489, 430);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 25);
            label10.TabIndex = 55;
            label10.Text = "محل الولادة";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(520, 503);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(66, 25);
            label11.TabIndex = 58;
            label11.Text = "العنوان";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(303, 533);
            textBoxAddress.Margin = new Padding(4, 5, 4, 5);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(275, 31);
            textBoxAddress.TabIndex = 57;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(461, 650);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(128, 25);
            label12.TabIndex = 60;
            label12.Text = "رقم قيد النفوس";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxReg
            // 
            textBoxReg.Location = new Point(303, 680);
            textBoxReg.Margin = new Padding(4, 5, 4, 5);
            textBoxReg.Name = "textBoxReg";
            textBoxReg.Size = new Size(275, 31);
            textBoxReg.TabIndex = 59;
            textBoxReg.TextChanged += textBoxReg_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(203, 210);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(101, 25);
            label13.TabIndex = 62;
            label13.Text = "تاريخ الصنع";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePickerProd
            // 
            dateTimePickerProd.Location = new Point(17, 240);
            dateTimePickerProd.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerProd.Name = "dateTimePickerProd";
            dateTimePickerProd.Size = new Size(275, 31);
            dateTimePickerProd.TabIndex = 61;
            dateTimePickerProd.ValueChanged += dateTimePickerProd_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(211, 283);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(90, 25);
            label14.TabIndex = 64;
            label14.Text = "رقم الهيكل";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxChassis
            // 
            textBoxChassis.Location = new Point(17, 313);
            textBoxChassis.Margin = new Padding(4, 5, 4, 5);
            textBoxChassis.Name = "textBoxChassis";
            textBoxChassis.Size = new Size(275, 31);
            textBoxChassis.TabIndex = 63;
            textBoxChassis.TextChanged += textBoxChassis_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(206, 357);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(97, 25);
            label15.TabIndex = 66;
            label15.Text = "رقم المحرك";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxMotor
            // 
            textBoxMotor.Location = new Point(17, 387);
            textBoxMotor.Margin = new Padding(4, 5, 4, 5);
            textBoxMotor.Name = "textBoxMotor";
            textBoxMotor.Size = new Size(275, 31);
            textBoxMotor.TabIndex = 65;
            textBoxMotor.TextChanged += textBoxMotor_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(249, 430);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(50, 25);
            label16.TabIndex = 68;
            label16.Text = "اللون";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(17, 460);
            textBoxColor.Margin = new Padding(4, 5, 4, 5);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(275, 31);
            textBoxColor.TabIndex = 67;
            textBoxColor.TextChanged += textBoxColor_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(206, 650);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(97, 25);
            label18.TabIndex = 74;
            label18.Text = "المواصفات";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxUtilis
            // 
            textBoxUtilis.Location = new Point(17, 680);
            textBoxUtilis.Margin = new Padding(4, 5, 4, 5);
            textBoxUtilis.Name = "textBoxUtilis";
            textBoxUtilis.Size = new Size(275, 31);
            textBoxUtilis.TabIndex = 73;
            textBoxUtilis.TextChanged += textBoxUtilis_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.Location = new Point(250, 577);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(49, 25);
            label19.TabIndex = 72;
            label19.Text = "النوع";
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(17, 607);
            textBoxModel.Margin = new Padding(4, 5, 4, 5);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(275, 31);
            textBoxModel.TabIndex = 71;
            textBoxModel.TextChanged += textBoxModel_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.ButtonHighlight;
            label20.Location = new Point(243, 503);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(57, 25);
            label20.TabIndex = 70;
            label20.Text = "الطراز";
            label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(17, 533);
            textBoxBrand.Margin = new Padding(4, 5, 4, 5);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(275, 31);
            textBoxBrand.TabIndex = 69;
            textBoxBrand.TextChanged += textBoxBrand_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = SystemColors.ButtonHighlight;
            label21.Location = new Point(206, 723);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(99, 25);
            label21.TabIndex = 76;
            label21.Text = "تاريخ الشراء";
            label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePickerAquisition
            // 
            dateTimePickerAquisition.Location = new Point(17, 753);
            dateTimePickerAquisition.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerAquisition.Name = "dateTimePickerAquisition";
            dateTimePickerAquisition.Size = new Size(275, 31);
            dateTimePickerAquisition.TabIndex = 75;
            dateTimePickerAquisition.ValueChanged += dateTimePickerAquisition_ValueChanged;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(17, 827);
            comboBoxCity.Margin = new Padding(4, 5, 4, 5);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(275, 33);
            comboBoxCity.TabIndex = 78;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = SystemColors.ButtonHighlight;
            label22.Location = new Point(236, 797);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(64, 25);
            label22.TabIndex = 77;
            label22.Text = "المدينة";
            label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = SystemColors.ButtonHighlight;
            label23.Location = new Point(446, 577);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(146, 25);
            label23.TabIndex = 80;
            label23.Text = "الوضع في الخدمة";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownPreMiseCirc
            // 
            numericUpDownPreMiseCirc.Location = new Point(303, 608);
            numericUpDownPreMiseCirc.Margin = new Padding(4, 5, 4, 5);
            numericUpDownPreMiseCirc.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownPreMiseCirc.Name = "numericUpDownPreMiseCirc";
            numericUpDownPreMiseCirc.Size = new Size(277, 31);
            numericUpDownPreMiseCirc.TabIndex = 81;
            numericUpDownPreMiseCirc.ValueChanged += numericUpDownPreMiseCirc_ValueChanged;
            // 
            // checkBoxInCirculation
            // 
            checkBoxInCirculation.AutoSize = true;
            checkBoxInCirculation.ForeColor = SystemColors.ButtonHighlight;
            checkBoxInCirculation.Location = new Point(411, 728);
            checkBoxInCirculation.Margin = new Padding(4, 5, 4, 5);
            checkBoxInCirculation.Name = "checkBoxInCirculation";
            checkBoxInCirculation.RightToLeft = RightToLeft.Yes;
            checkBoxInCirculation.Size = new Size(179, 29);
            checkBoxInCirculation.TabIndex = 82;
            checkBoxInCirculation.Text = "موضوعة في السير";
            checkBoxInCirculation.UseVisualStyleBackColor = true;
            checkBoxInCirculation.CheckedChanged += checkBoxInCirculation_CheckedChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = SystemColors.ButtonHighlight;
            label24.Location = new Point(524, 797);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(62, 25);
            label24.TabIndex = 84;
            label24.Text = "الاقامة";
            label24.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxIqama
            // 
            textBoxIqama.Location = new Point(303, 827);
            textBoxIqama.Margin = new Padding(4, 5, 4, 5);
            textBoxIqama.Name = "textBoxIqama";
            textBoxIqama.Size = new Size(275, 31);
            textBoxIqama.TabIndex = 83;
            textBoxIqama.TextChanged += textBoxIqama_TextChanged;
            // 
            // FormVehicle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1803, 938);
            Controls.Add(panel1);
            Controls.Add(label24);
            Controls.Add(textBoxIqama);
            Controls.Add(checkBoxInCirculation);
            Controls.Add(numericUpDownPreMiseCirc);
            Controls.Add(label23);
            Controls.Add(comboBoxCity);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(dateTimePickerAquisition);
            Controls.Add(label18);
            Controls.Add(textBoxUtilis);
            Controls.Add(label19);
            Controls.Add(textBoxModel);
            Controls.Add(label20);
            Controls.Add(textBoxBrand);
            Controls.Add(label16);
            Controls.Add(textBoxColor);
            Controls.Add(label15);
            Controls.Add(textBoxMotor);
            Controls.Add(label14);
            Controls.Add(textBoxChassis);
            Controls.Add(label13);
            Controls.Add(dateTimePickerProd);
            Controls.Add(label12);
            Controls.Add(textBoxReg);
            Controls.Add(label11);
            Controls.Add(textBoxAddress);
            Controls.Add(comboBoxPBirth);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(numericUpDownAge);
            Controls.Add(label8);
            Controls.Add(textBoxLName);
            Controls.Add(label7);
            Controls.Add(textBoxMother);
            Controls.Add(label17);
            Controls.Add(textBoxMobileno);
            Controls.Add(label6);
            Controls.Add(textBoxFName);
            Controls.Add(comboBoxCode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxVNumber);
            Controls.Add(label3);
            Controls.Add(numericUpDownSerial);
            Controls.Add(label2);
            Controls.Add(numericUpDownVid);
            Controls.Add(dataGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormVehicle";
            Text = "FormVehicle";
            Load += FormVehicle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreMiseCirc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
		private Label labelStatus;
		private Panel panel1;
		private Button buttonRefresh;
		private Button buttonCancel;
		private Button buttonSave;
		private Button buttonDelete;
		private Button buttonUpdate;
		private Label label2;
		private NumericUpDown numericUpDownVid;
		private Label label4;
		private TextBox textBoxVNumber;
		private Label label5;
		private Label label3;
		private NumericUpDown numericUpDownSerial;
		private ComboBox comboBoxCode;
		private Label label6;
		private TextBox textBoxFName;
		private Label label17;
		private TextBox textBoxMobileno;
		private Label label7;
		private TextBox textBoxMother;
		private Label label8;
		private TextBox textBoxLName;
		private NumericUpDown numericUpDownAge;
		private Label label9;
		private ComboBox comboBoxPBirth;
		private Label label10;
		private Label label11;
		private TextBox textBoxAddress;
		private Label label12;
		private TextBox textBoxReg;
		private Label label13;
		private DateTimePicker dateTimePickerProd;
		private Label label14;
		private TextBox textBoxChassis;
		private Label label15;
		private TextBox textBoxMotor;
		private Label label16;
		private TextBox textBoxColor;
		private Label label18;
		private TextBox textBoxUtilis;
		private Label label19;
		private TextBox textBoxModel;
		private Label label20;
		private TextBox textBoxBrand;
		private Label label21;
		private DateTimePicker dateTimePickerAquisition;
		private ComboBox comboBoxCity;
		private Label label22;
		private Label label23;
		private NumericUpDown numericUpDownPreMiseCirc;
		private CheckBox checkBoxInCirculation;
		private Label label24;
		private TextBox textBoxIqama;
	}
}