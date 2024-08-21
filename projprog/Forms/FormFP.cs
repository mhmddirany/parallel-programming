using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using projprog.Repositories.Controllers;
using projprog.Repositories.Models;
using projprog.Utilities;

namespace projprog.Forms
{
    public partial class FormFP : Form
    {
        ImageFP imageFP;

        public FormFP(int serial, int serpers)
        {
            InitializeComponent();
            Initialize(serial, serpers);
        }

        private async void Initialize(int serial, int serpers)
        {
            try
            {
                
                ImageFP currentImageFP = await ImageFPController.GetImageFPByPrimaries(serial, serpers);
                if (currentImageFP != null)
                {
                    imageFP = currentImageFP;
                    pictureBoxLeft.Image = BlobConversion.ConvertBlobToImage(imageFP.fpLeft);
                    pictureBoxRight.Image = BlobConversion.ConvertBlobToImage(imageFP.fpRight);
                    numericUpDownSerial.Value = serial;
                    numericUpDownSerpers.Value = serpers;
                }
                else
                {
                    imageFP = new ImageFP { Serial = serial, Serpers = serpers };
                }


            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }

           
        }

        private void pictureBoxRight_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {

        }

        private async void buttonUpdateLeft_Click(object sender, EventArgs e)
        {
            
            string imageLocation;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBoxLeft.ImageLocation = imageLocation;

                    byte[] blob = BlobConversion.ConvertImageToBlob(imageLocation);

                    imageFP.fpLeft = blob;
                    await ImageFPController.UpsertImageFP(imageFP);
                }
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }
           
        }

        private async void buttonUpdateRight_Click(object sender, EventArgs e)
        {
            
            string imageLocation;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBoxRight.ImageLocation = imageLocation;

                    byte[] blob = BlobConversion.ConvertImageToBlob(imageLocation);

                    imageFP.fpRight = blob;
                    await ImageFPController.UpsertImageFP(imageFP);
                }
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }
            
        }

        private async void buttonDeleteRight_Click(object sender, EventArgs e)
        {
            
            try
            {
                imageFP.fpRight = null;
                pictureBoxRight.Image = null;
                await ImageFPController.UpsertImageFP(imageFP);
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);

            }
            
        }

        private async void buttonDeleteLeft_Click(object sender, EventArgs e)
        {
            
            try
            {
                imageFP.fpLeft = null;
                pictureBoxLeft.Image = null;
                await ImageFPController.UpsertImageFP(imageFP);
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }

        }

        private void FormFP_Load(object sender, EventArgs e)
        {

        }
    }
}
