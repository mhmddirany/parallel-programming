using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projprog.Repositories.Controllers;
using projprog.Repositories.Models;
using projprog.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projprog.Forms
{
	public enum canClick { disabled, enabled }

    public partial class FormInvest : Form
    {
        Invest currentInvest = new Invest { };

        public FormInvest()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            Initialize();
        }

        async void Initialize()
        {
            try
            {
                UpdatecanClick(canClick.enabled);
                await UpdateDataGridView();     // to get the info from the controller (see its code below)
                dataGridView.CellClick += dataGridView_CellClick;
                comboBoxCrime.DropDownStyle = ComboBoxStyle.DropDown;

                List<Worldkey> worldkeys = await WorldkeyController.GetAllWorldkeys();
                string[] worldKeyLabels = new string[worldkeys.Count];
                for (int i = 0; i < worldkeys.Count; i++)
                    worldKeyLabels[i] = worldkeys[i].Label;

                comboBoxCrime.Items.AddRange(worldKeyLabels);
                comboBoxCrime.SelectedIndex = 0;

                Reset();
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }
        }

        void Reset()        // this represents the "الغاء"
        {
            numericUpDownSerial.Value = 0;
            dateTimePickerDFile.Value = DateTime.Now;
            dateTimePickerDMahdar.Value = DateTime.Now;
            comboBoxCrime.Text = "";
            checkBoxMadbout.Checked = false;
            checkBoxResume.Checked = false;
            richTextBoxRem.Text = "";

            currentInvest = new Invest
            {
                Serial = 0,
                DFile = DateTime.Now,
                DMahdar = DateTime.Now,
                Crime = "",
                Madbout = "N",
                Resume = "N",
                Rem = ""
            };


        }

        void UpdateCurrentInvest(Invest newInvest)
        {
            currentInvest = newInvest;

            numericUpDownSerial.Value = (int)currentInvest.Serial;
            dateTimePickerDFile.Value = (DateTime)currentInvest.DFile;
            dateTimePickerDMahdar.Value = (DateTime)currentInvest.DMahdar;
            comboBoxCrime.Text = currentInvest.Crime;
            checkBoxMadbout.Checked = currentInvest.Madbout == "Y";
            checkBoxResume.Checked = currentInvest.Resume == "Y";
            richTextBoxRem.Text = currentInvest.Rem;
        }

        public async Task UpdateDataGridView()
        {
            try
            {
                UpdatecanClick(canClick.disabled);
                dataGridView.DataSource = await InvestController.GetAllInvests();
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }
            finally
            {
                UpdatecanClick(canClick.enabled);
            }
        }

        private Invest GetInvestFromRow(DataGridViewRow row)
        {
            return new Invest
            {
                Serial = (int)row.Cells[0].Value,
                DFile = (DateTime)row.Cells[1].Value,
                DMahdar = (DateTime)row.Cells[2].Value,
                Crime = (string)row.Cells[3].Value,
                Madbout = (string)row.Cells[4].Value,
                Resume = (string)row.Cells[5].Value,
                Rem = (string)row.Cells[6].Value,
            };
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateCurrentInvest(GetInvestFromRow(dataGridView.Rows[e.RowIndex]));
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatecanClick(canClick.disabled);
                await InvestController.CreateInvest(currentInvest);
                await UpdateDataGridView();
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }
            finally
            {
                UpdatecanClick(canClick.enabled);
            }
        }

        private void dateTimePickerDFile_ValueChanged(object sender, EventArgs e)
        {
            currentInvest.DFile = dateTimePickerDFile.Value;
        }

        private void dateTimePickerDMahdar_ValueChanged(object sender, EventArgs e)
        {
            currentInvest.DMahdar = dateTimePickerDMahdar.Value;
        }

        private void comboBoxCrime_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInvest.Crime = comboBoxCrime.Text;
        }

        private void checkBoxResume_CheckedChanged(object sender, EventArgs e)
        {
            currentInvest.Resume = checkBoxResume.Checked ? "Y" : "N";
        }

        private void checkBoxMadbout_CheckedChanged(object sender, EventArgs e)
        {
            currentInvest.Madbout = checkBoxMadbout.Checked ? "Y" : "N";
        }

        private void richTextBoxRem_TextChanged(object sender, EventArgs e)
        {
            currentInvest.Rem = richTextBoxRem.Text;
        }

        private void numericUpDownSerial_ValueChanged(object sender, EventArgs e)
        {
            currentInvest.Serial = (int)numericUpDownSerial.Value;
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatecanClick(canClick.disabled);
                await InvestController.UpdateInvest(currentInvest);
                await UpdateDataGridView();
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }
            finally
            {
                UpdatecanClick(canClick.enabled);
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatecanClick(canClick.disabled);
                await InvestController.RemoveInvest(currentInvest);
                await UpdateDataGridView();
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }
            finally
            {
                UpdatecanClick(canClick.enabled);
            }
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await UpdateDataGridView();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void UpdatecanClick(canClick canClick)
        {
            switch (canClick)
            {
                case canClick.disabled:
                    button9.Enabled = buttonCancel.Enabled = buttonDelete.Enabled = buttonPeople.Enabled = buttonRefresh.Enabled = buttonSave.Enabled = buttonUpdate.Enabled = buttonVehicles.Enabled = button9.Enabled = comboBoxCrime.Enabled = false;
                    numericUpDownSerial.Enabled = dateTimePickerDFile.Enabled = dateTimePickerDMahdar.Enabled = richTextBoxRem.Enabled = checkBoxMadbout.Enabled = checkBoxResume.Enabled = false;
                    //comboBoxCrime.Enabled =
                    dataGridView.Enabled = false;
                    break;

                case canClick.enabled:
                    button9.Enabled = buttonCancel.Enabled = buttonDelete.Enabled = buttonPeople.Enabled = buttonRefresh.Enabled = buttonSave.Enabled = buttonUpdate.Enabled = buttonVehicles.Enabled = button9.Enabled = true;
                    numericUpDownSerial.Enabled = dateTimePickerDFile.Enabled = dateTimePickerDMahdar.Enabled = richTextBoxRem.Enabled = checkBoxMadbout.Enabled = checkBoxResume.Enabled = comboBoxCrime.Enabled = true;
                    //
                    dataGridView.Enabled = true;
                    break;
            }
        }

        private void buttonPeople_Click(object sender, EventArgs e)
        {
            if (currentInvest.Serial <= 0)
            {
                ErrorViewer.ShowError("No investigation selected!");
                return;
            }

            FormPerson formPerson = new FormPerson((int)currentInvest.Serial);
            formPerson.ShowDialog();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonVehicles_Click(object sender, EventArgs e)
        {
            if (currentInvest.Serial <= 0)
            {
                ErrorViewer.ShowError("No investigation selected!");
                return;
            }

            FormVehicle formVehicle = new FormVehicle((int)currentInvest.Serial);
            formVehicle.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (currentInvest.Serial <= 0)
            {
                ErrorViewer.ShowError("No investigation selected!");
                return;
            }

            FormWord formWord = new FormWord((int)currentInvest.Serial);
            formWord.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelcanClick_Click(object sender, EventArgs e)
        {

        }

        private void FormInvest_Load(object sender, EventArgs e)
        {

        }
    }
}
