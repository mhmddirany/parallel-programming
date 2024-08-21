using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projprog.Repositories.Controllers;
using projprog.Repositories.Models;
using projprog.Utilities;

namespace projprog.Forms
{
    public partial class FormPerson : Form
    {
        Invperson currentInvperson = new Invperson { };
        public FormPerson(int serial)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Initialize(serial);
        }

        public async Task UpdateDataGridView()
        {
            try
            {
                UpdatecanClick(canClick.disabled);
                dataGridView.DataSource = await InvpersonController.GetAllInvpersons((int)currentInvperson.Serial);
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

        async void Initialize(int serial)
        {
            UpdatecanClick(canClick.disabled);

            dataGridView.CellClick += (object sender, DataGridViewCellEventArgs e) =>
            {
                dataGridView_CellClick(sender, e);
            };

            Reset(serial);

            try
            {

                Task<List<Village>> villagesTask = VillageController.GetAllVillages();
                Task<List<Nation>> nationsTask = NationController.GetAllNations();
                Task<List<Attr>> attrsTask = AttrController.GetAllAttrs();

                Task[] tasks = new Task[] { villagesTask, nationsTask, attrsTask };

                await Task.WhenAll(tasks);

                var villages = await villagesTask;
                var nations = await nationsTask;
                var attrs = await attrsTask;

                string[] attrLabels = new string[attrs.Count];
                for (int i = 0; i < attrs.Count; i++)
                    attrLabels[i] = attrs[i].Label;

                string[] nationLabels = new string[nations.Count];
                for (int i = 0; i < nations.Count; i++)
                    nationLabels[i] = nations[i].Label;

                string[] villageLabels = new string[villages.Count];
                for (int i = 0; i < villages.Count; i++)
                    villageLabels[i] = villages[i].Label;

                comboBoxAttr.Items.AddRange(attrLabels);
                comboBoxPBirth.Items.AddRange(villageLabels);
                comboBoxResid.Items.AddRange(villageLabels);
                comboBoxNation.Items.AddRange(nationLabels);
                comboBoxGender.Items.AddRange(new string[] { "Male", "Female" });
                comboBoxStatus.Items.AddRange(new string[] { "Married", "Single" });
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }

            UpdateDataGridView();
        }

        void Reset(int serial)
        {
            numericUpDownSerial.Value = serial;
            numericUpDownSerpers.Value = 0;
            textBoxFName.Text = "";
            textBoxLName.Text = "";
            textBoxFather.Text = "";
            textBoxMother.Text = "";
            textBoxReg.Text = "";
            comboBoxNation.Text = "";
            comboBoxPBirth.Text = "";
            comboBoxResid.Text = "";
            dateTimePickerDbirth.Value = DateTime.Now;
            comboBoxAttr.Text = "";
            checkBoxExst.Checked = false;
            textBoxNickname.Text = "";
            textBoxOccupation.Text = "";
            textBoxArch.Text = "";
            comboBoxStatus.Text = "";
            textBoxMobileno.Text = "";
            comboBoxGender.Text = "";

            currentInvperson = new Invperson
            {
                Serial = serial,
                Serpers = 0,
                FName = "",
                LName = "",
                Father = "",
                Mother = "",
                Reg = "",
                Nation = "",
                PBirth = "",
                Resid = "",
                DBirth = DateTime.Now,
                Attr = "",
                Exst = 0,
                Nickname = "",
                Occupation = "",
                Arch = 0,
                Status = "",
                Mobileno = "",
                Gender = ""
            };


        }

        private async Task dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateCurrentInvest(await GetInvpersonFromRow(dataGridView.Rows[e.RowIndex]));
            }
        }

        void UpdateCurrentInvest(Invperson newInvperson)
        {
            currentInvperson = newInvperson;

            numericUpDownSerial.Value = (int)currentInvperson.Serial;
            numericUpDownSerpers.Value = (int)currentInvperson.Serpers;
            textBoxFName.Text = currentInvperson.FName;
            textBoxLName.Text = currentInvperson.LName;
            textBoxFather.Text = currentInvperson.Father;
            textBoxMother.Text = currentInvperson.Mother;
            textBoxReg.Text = currentInvperson.Reg;
            comboBoxNation.Text = currentInvperson.Nation;
            comboBoxPBirth.Text = currentInvperson.PBirth;
            comboBoxResid.Text = currentInvperson.Resid;
            dateTimePickerDbirth.Value = currentInvperson.DBirth != null ? (DateTime)currentInvperson.DBirth : DateTime.Now;
            comboBoxAttr.Text = currentInvperson.Attr;
            checkBoxExst.Checked = (int)currentInvperson.Exst == 1;
            textBoxNickname.Text = currentInvperson.Nickname;
            textBoxOccupation.Text = currentInvperson.Occupation;
            textBoxArch.Text = ((int)currentInvperson.Arch).ToString();
            comboBoxStatus.Text = currentInvperson.Status;
            textBoxMobileno.Text = currentInvperson.Mobileno;
            comboBoxGender.Text = currentInvperson.Gender;
        }

        private async Task<Invperson> GetInvpersonFromRow(DataGridViewRow row)
        {
            return await InvpersonController.GetInvpersonByPrimaries((int)row.Cells[0].Value, (int)row.Cells[1].Value);
        }

        private void UpdatecanClick(canClick canClick)
        {
            switch (canClick)
            {
                case canClick.disabled:
                    buttonCancel.Enabled = buttonDelete.Enabled = buttonRefresh.Enabled = buttonSave.Enabled = buttonUpdate.Enabled = false;
                    numericUpDownSerial.Enabled = numericUpDownSerpers.Enabled = textBoxArch.Enabled = textBoxFather.Enabled = textBoxFName.Enabled = textBoxLName.Enabled = textBoxMobileno.Enabled = textBoxMother.Enabled = textBoxNickname.Enabled = textBoxOccupation.Enabled = comboBoxPBirth.Enabled = textBoxReg.Enabled = comboBoxResid.Enabled = false;
                    dateTimePickerDbirth.Enabled = comboBoxGender.Enabled = comboBoxNation.Enabled = comboBoxAttr.Enabled = comboBoxStatus.Enabled = false;
                    dataGridView.Enabled = false;
                    break;
                case canClick.enabled:
                    buttonCancel.Enabled = buttonDelete.Enabled = buttonRefresh.Enabled = buttonSave.Enabled = buttonUpdate.Enabled = true;
                    numericUpDownSerial.Enabled = numericUpDownSerpers.Enabled = textBoxArch.Enabled = textBoxFather.Enabled = textBoxFName.Enabled = textBoxLName.Enabled = textBoxMobileno.Enabled = textBoxMother.Enabled = textBoxNickname.Enabled = textBoxOccupation.Enabled = comboBoxPBirth.Enabled = textBoxReg.Enabled = comboBoxResid.Enabled = true;
                    dateTimePickerDbirth.Enabled = comboBoxGender.Enabled = comboBoxNation.Enabled = comboBoxAttr.Enabled = comboBoxStatus.Enabled = true;
                    dataGridView.Enabled = true;
                    break;
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatecanClick(canClick.disabled);
                await InvpersonController.CreateInvperson(currentInvperson);
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
                await InvpersonController.RemoveInvperson(currentInvperson);
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

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatecanClick(canClick.disabled);
                await InvpersonController.UpdateInvperson(currentInvperson);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Reset((int)currentInvperson.Serial);
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await UpdateDataGridView();
        }

        private void numericUpDownSerial_ValueChanged(object sender, EventArgs e)
        {
            currentInvperson.Serial = (int)numericUpDownSerial.Value;
        }

        private void numericUpDownSerpers_ValueChanged(object sender, EventArgs e)
        {
            currentInvperson.Serpers = (int)numericUpDownSerpers.Value;
        }

        private void textBoxFName_TextChanged(object sender, EventArgs e)
        {
            currentInvperson.FName = textBoxFName.Text;
        }

        private void textBoxLName_TextChanged(object sender, EventArgs e)
        {
            currentInvperson.LName = textBoxLName.Text;
        }

        private void textBoxFather_TextChanged(object sender, EventArgs e)
        {
            currentInvperson.Father = textBoxFather.Text;
        }

        private void textBoxMother_TextChanged(object sender, EventArgs e)
        {
            currentInvperson.Mother = textBoxMother.Text;
        }

        private void textBoxReg_TextChanged(object sender, EventArgs e)
        {
            currentInvperson.Reg = textBoxReg.Text;
        }

        private void comboBoxNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInvperson.Nation = comboBoxNation.Text;
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInvperson.Status = comboBoxStatus.Text;
        }


        private void comboBoxAttr_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInvperson.Attr = comboBoxAttr.Text;
        }

        private void dateTimePickerDbirth_ValueChanged(object sender, EventArgs e)
        {
            currentInvperson.DBirth = (DateTime)dateTimePickerDbirth.Value;
        }

        private void checkBoxExst_CheckedChanged(object sender, EventArgs e)
        {
            currentInvperson.Exst = checkBoxExst.Checked ? 1 : 0;
        }

        private void textBoxNickname_TextChanged(object sender, EventArgs e)
        {
            currentInvperson.Nickname = textBoxNickname.Text;
        }

        private void textBoxArch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currentInvperson.Arch = int.Parse(textBoxArch.Text);
            }
            catch
            {

            }
        }

        private void textBoxOccupation_TextChanged(object sender, EventArgs e)
        {
            currentInvperson.Occupation = textBoxOccupation.Text;
        }

        private void comboBoxcanClick_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInvperson.Status = comboBoxStatus.Text;
        }

        private void textBoxMobileno_TextChanged(object sender, EventArgs e)
        {
            currentInvperson.Mobileno = textBoxMobileno.Text;
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInvperson.Gender = comboBoxGender.Text;
        }

        private void comboBoxPBirth_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInvperson.PBirth = comboBoxPBirth.Text;
        }

        private void comboBoxResid_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInvperson.Resid = comboBoxResid.Text;
        }

        private void buttonImageFace_Click(object sender, EventArgs e)
        {
            FormFace formFace = new FormFace((int)currentInvperson.Serial, (int)currentInvperson.Serpers);
            formFace.ShowDialog();
        }

        private void buttonImageFP_Click(object sender, EventArgs e)
        {
            FormFP formFP = new FormFP((int)currentInvperson.Serial, (int)currentInvperson.Serpers);
            formFP.ShowDialog();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
