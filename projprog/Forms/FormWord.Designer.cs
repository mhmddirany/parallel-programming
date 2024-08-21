namespace projprog.Forms
{
	partial class FormWord
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
            checkedListBoxWorld = new CheckedListBox();
            textBoxSearch = new TextBox();
            label1 = new Label();
            numericUpDownSerial = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = SystemColors.Menu;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(517, 20);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(609, 578);
            dataGridView.TabIndex = 0;
            // 
            // checkedListBoxWorld
            // 
            checkedListBoxWorld.BackColor = Color.DarkSeaGreen;
            checkedListBoxWorld.FormattingEnabled = true;
            checkedListBoxWorld.Location = new Point(17, 142);
            checkedListBoxWorld.Margin = new Padding(4, 5, 4, 5);
            checkedListBoxWorld.Name = "checkedListBoxWorld";
            checkedListBoxWorld.Size = new Size(490, 452);
            checkedListBoxWorld.TabIndex = 1;
            checkedListBoxWorld.SelectedIndexChanged += checkedListBoxWorld_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(17, 93);
            textBoxSearch.Margin = new Padding(4, 5, 4, 5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(490, 31);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(318, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 47;
            label1.Text = " المتسلسل";
            // 
            // numericUpDownSerial
            // 
            numericUpDownSerial.Enabled = false;
            numericUpDownSerial.Location = new Point(419, 20);
            numericUpDownSerial.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSerial.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownSerial.Name = "numericUpDownSerial";
            numericUpDownSerial.Size = new Size(90, 31);
            numericUpDownSerial.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(467, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 48;
            label2.Text = "بحث";
            // 
            // FormWord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1143, 618);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownSerial);
            Controls.Add(textBoxSearch);
            Controls.Add(checkedListBoxWorld);
            Controls.Add(dataGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormWord";
            Text = "FormWord";
            Load += FormWord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSerial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
		private CheckedListBox checkedListBoxWorld;
		private TextBox textBoxSearch;
		private Label label1;
		private NumericUpDown numericUpDownSerial;
		private Label label2;
	}
}