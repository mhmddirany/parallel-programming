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

namespace projprog.Forms
{
    public partial class FormWord : Form
    {
        List<string?> checkListItems = new List<string?>();
        List<string?> currentCheckListItems = new List<string?>();

        public FormWord(int s)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Initialize();
            numericUpDownSerial.Value = s;
        }

        async void Initialize()
        {
            await GetCheckListItems();
            currentCheckListItems.Clear();
            currentCheckListItems.AddRange(checkListItems);
            UpdateCheckListItems();
        }

        async Task GetCheckListItems()
        {
            try
            {
                List<Worldkey> worlds = await WorldkeyController.GetAllWorldkeys();
                foreach (Worldkey w in worlds)
                {
                    checkListItems.Add(w.Label);
                }
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }
        }

        List<string> FilterCheckListItems(string search)
        {
            List<string> filteredItems = new List<string>();
            foreach (string item in checkListItems)
            {
                if (item.Contains(search))
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems;
        }

        void UpdateCheckListItems()
        {
            foreach (string item in currentCheckListItems)
            {
                checkedListBoxWorld.Items.Add(item);
            }
        }

        private async void checkedListBoxWorld_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Invest> invests = new List<Invest>();
                foreach (var item in checkedListBoxWorld.CheckedItems)
                {
                    if (item != null)
                    {
                        string world = item as string;
                        List<Invest>? values = await InvestController.GetInvestsByWorld(world);
                        if (values != null)
                        {
                            invests.AddRange(values);
                        }
                    }
                }

                dataGridView.DataSource = invests;
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            currentCheckListItems.Clear();
            currentCheckListItems.AddRange(FilterCheckListItems(textBoxSearch.Text));
            UpdateCheckListItems();
        }


        private void FormWord_Load(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
