using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using projprog.Repositories.Controllers;
using projprog.Repositories.Models;
using projprog.Utilities;

namespace projprog.Forms
{
    public partial class FormVehicle : Form
    {

        Vehicle currentVehicle = new Vehicle { };

        public FormVehicle(int serial)
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
                dataGridView.DataSource = await VehicleController.GetAllVehicles((int)currentVehicle.Serial);
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

                Task[] tasks = new Task[] { villagesTask };

                await Task.WhenAll(tasks);

                var villages = await villagesTask;

                string[] villageLabels = new string[villages.Count];
                for (int i = 0; i < villages.Count; i++)
                    villageLabels[i] = villages[i].Label;

                comboBoxCity.Items.AddRange(villageLabels);
                comboBoxPBirth.Items.AddRange(villageLabels);
                comboBoxCode.Items.AddRange(new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
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
            numericUpDownVid.Value = 0;
            textBoxVNumber.Text = "";
            comboBoxCode.Text = "";
            dateTimePickerProd.Value = DateTime.Now;
            textBoxChassis.Text = "";
            textBoxMotor.Text = "";
            dateTimePickerAquisition.Value = DateTime.Now;
            numericUpDownPreMiseCirc.Value = 0;
            textBoxColor.Text = "";
            textBoxBrand.Text = "";
            textBoxModel.Text = "";
            textBoxUtilis.Text = "";
            textBoxFName.Text = "";
            textBoxLName.Text = "";
            textBoxAddress.Text = "";
            comboBoxCity.Text = "";
            textBoxIqama.Text = "";
            checkBoxInCirculation.Checked = false;
            textBoxMother.Text = "";
            textBoxMobileno.Text = "";
            numericUpDownAge.Value = 0;
            textBoxReg.Text = "";
            comboBoxPBirth.Text = "";


            currentVehicle = new Vehicle
            {
                Serial = serial,
                Vid = 0,
                VNumber = "",
                Code = "",
                Prod = DateTime.Now,
                Chassis = "",
                Motor = "",
                Aquisition = DateTime.Now,
                PreMiseCirc = 0,
                Color = "",
                Brand = "",
                Model = "",
                Utilis = "",
                FName = "",
                LName = "",
                Address = "",
                City = "",
                Iqama = "",
                InCirculation = false,
                Mother = "",
                Mobileno = "",
                Age = 0,
                PBirth = "",
                Reg = "",
            };
        }

        private async Task dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateCurrentVehicle(await GetVehicleFromRow(dataGridView.Rows[e.RowIndex]));
            }
        }

        void UpdateCurrentVehicle(Vehicle newVehicle)
        {
            currentVehicle = newVehicle;

            numericUpDownSerial.Value = (int)currentVehicle.Serial;
            numericUpDownVid.Value = (int)currentVehicle.Vid;
            textBoxVNumber.Text = currentVehicle.VNumber;
            comboBoxCode.Text = currentVehicle.Code;
            dateTimePickerProd.Value = (DateTime)currentVehicle.Prod;
            textBoxChassis.Text = currentVehicle.Chassis;
            textBoxMotor.Text = currentVehicle.Motor;
            dateTimePickerAquisition.Value = (DateTime)currentVehicle.Aquisition;
            numericUpDownPreMiseCirc.Value = (int)currentVehicle.PreMiseCirc;
            textBoxColor.Text = currentVehicle.Color;
            textBoxBrand.Text = currentVehicle.Brand;
            textBoxModel.Text = currentVehicle.Model;
            textBoxUtilis.Text = currentVehicle.Utilis;
            textBoxFName.Text = currentVehicle.FName;
            textBoxLName.Text = currentVehicle.LName;
            textBoxAddress.Text = currentVehicle.Address;
            comboBoxCity.Text = currentVehicle.City;
            textBoxIqama.Text = currentVehicle.Iqama;
            checkBoxInCirculation.Checked = (bool)currentVehicle.InCirculation;
            textBoxMother.Text = currentVehicle.Mother;
            textBoxMobileno.Text = currentVehicle.Mobileno;
            numericUpDownAge.Value = (int)currentVehicle.Age;
            textBoxReg.Text = currentVehicle.Reg;
            comboBoxPBirth.Text = currentVehicle.PBirth;
        }

        private async Task<Vehicle> GetVehicleFromRow(DataGridViewRow row)
        {
            return await VehicleController.GetVehicleByVid((int)row.Cells[0].Value);
        }

        private void UpdatecanClick(canClick canClick)
        {
            switch (canClick)
            {
                case canClick.disabled:
                    buttonCancel.Enabled = buttonDelete.Enabled = buttonRefresh.Enabled = buttonSave.Enabled = buttonUpdate.Enabled = false;

                    numericUpDownSerial.Enabled = false;
                    numericUpDownVid.Enabled = false;
                    textBoxVNumber.Enabled = false;
                    comboBoxCode.Enabled = false;
                    dateTimePickerProd.Enabled = false;
                    textBoxChassis.Enabled = false;
                    textBoxMotor.Enabled = false;
                    dateTimePickerAquisition.Enabled = false;
                    numericUpDownPreMiseCirc.Enabled = false;
                    textBoxColor.Enabled = false;
                    textBoxBrand.Enabled = false;
                    textBoxModel.Enabled = false;
                    textBoxUtilis.Enabled = false;
                    textBoxFName.Enabled = false;
                    textBoxLName.Enabled = false;
                    textBoxAddress.Enabled = false;
                    comboBoxCity.Enabled = false;
                    textBoxIqama.Enabled = false;
                    checkBoxInCirculation.Enabled = false;
                    textBoxMother.Enabled = false;
                    textBoxMobileno.Enabled = false;
                    numericUpDownAge.Enabled = false;
                    textBoxReg.Enabled = false;
                    comboBoxPBirth.Enabled = false;

                    dataGridView.Enabled = false;
                    break;
                case canClick.enabled:
                    buttonCancel.Enabled = buttonDelete.Enabled = buttonRefresh.Enabled = buttonSave.Enabled = buttonUpdate.Enabled = true;
                    numericUpDownSerial.Enabled = true;
                    numericUpDownVid.Enabled = true;
                    textBoxVNumber.Enabled = true;
                    comboBoxCode.Enabled = true;
                    dateTimePickerProd.Enabled = true;
                    textBoxChassis.Enabled = true;
                    textBoxMotor.Enabled = true;
                    dateTimePickerAquisition.Enabled = true;
                    numericUpDownPreMiseCirc.Enabled = true;
                    textBoxColor.Enabled = true;
                    textBoxBrand.Enabled = true;
                    textBoxModel.Enabled = true;
                    textBoxUtilis.Enabled = true;
                    textBoxFName.Enabled = true;
                    textBoxLName.Enabled = true;
                    textBoxAddress.Enabled = true;
                    comboBoxCity.Enabled = true;
                    textBoxIqama.Enabled = true;
                    checkBoxInCirculation.Enabled = true;
                    textBoxMother.Enabled = true;
                    textBoxMobileno.Enabled = true;
                    numericUpDownAge.Enabled = true;
                    textBoxReg.Enabled = true;
                    comboBoxPBirth.Enabled = true;
                    dataGridView.Enabled = true;
                    break;
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatecanClick(canClick.disabled);
                await VehicleController.CreateVehicle(currentVehicle);
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
                await VehicleController.RemoveVehicle(currentVehicle);
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
                await VehicleController.UpdateVehicle(currentVehicle);
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
            Reset((int)currentVehicle.Serial);
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await UpdateDataGridView();
        }

        private void numericUpDownVid_ValueChanged(object sender, EventArgs e)
        {
            currentVehicle.Vid = (int)numericUpDownVid.Value;
        }

        private void numericUpDownSerial_ValueChanged(object sender, EventArgs e)
        {
            currentVehicle.Serial = (int)numericUpDownSerial.Value;
        }

        private void textBoxVNumber_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.VNumber = textBoxVNumber.Text;
        }

        private void comboBoxCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentVehicle.Code = comboBoxCode.Text;
        }

        private void textBoxFName_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.FName = textBoxFName.Text;
        }

        private void textBoxMobileno_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Mobileno = textBoxMobileno.Text;
        }

        private void textBoxMother_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Mother = textBoxMother.Text;
        }

        private void dateTimePickerProd_ValueChanged(object sender, EventArgs e)
        {
            currentVehicle.Prod = dateTimePickerProd.Value;
        }

        private void textBoxLName_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.LName = textBoxLName.Text;
        }

        private void textBoxChassis_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Chassis = textBoxChassis.Text;
        }

        private void numericUpDownAge_ValueChanged(object sender, EventArgs e)
        {
            currentVehicle.Age = (int)numericUpDownAge.Value;
        }

        private void textBoxMotor_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Motor = textBoxMotor.Text;
        }

        private void comboBoxPBirth_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentVehicle.PBirth = comboBoxPBirth.Text;
        }

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Color = textBoxColor.Text;
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Address = textBoxAddress.Text;
        }

        private void textBoxBrand_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Brand = textBoxBrand.Text;
        }

        private void numericUpDownPreMiseCirc_ValueChanged(object sender, EventArgs e)
        {
            currentVehicle.PreMiseCirc = (int)numericUpDownPreMiseCirc.Value;
        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Model = textBoxModel.Text;
        }

        private void textBoxReg_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Reg = textBoxReg.Text;
        }

        private void textBoxUtilis_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Utilis = textBoxUtilis.Text;
        }

        private void checkBoxInCirculation_CheckedChanged(object sender, EventArgs e)
        {
            currentVehicle.InCirculation = checkBoxInCirculation.Checked;
        }

        private void dateTimePickerAquisition_ValueChanged(object sender, EventArgs e)
        {
            currentVehicle.Aquisition = dateTimePickerAquisition.Value;
        }

        private void textBoxIqama_TextChanged(object sender, EventArgs e)
        {
            currentVehicle.Iqama = textBoxIqama.Text;
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentVehicle.City = comboBoxCity.Text;
        }

        private void FormVehicle_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
