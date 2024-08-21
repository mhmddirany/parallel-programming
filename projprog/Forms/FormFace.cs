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
using static System.Net.Mime.MediaTypeNames;

namespace projprog.Forms
{
    public partial class FormFace : Form
    {
        ImageFace imageFace;

        public FormFace(int serial, int serpers)
        {
            InitializeComponent();
            Initialize(serial, serpers);
        }

        private async void Initialize(int serial, int serpers)
        {
            try
            {
                ImageFace currentImageFace = await ImageFaceController.GetImageFaceByPrimaries(serial, serpers);
                if (currentImageFace != null)
                {
                    imageFace = currentImageFace;
                    pictureBoxLeft.Image = BlobConversion.ConvertBlobToImage(imageFace.faceLeft);
                    pictureBoxCenter.Image = BlobConversion.ConvertBlobToImage(imageFace.faceFront);
                    pictureBoxRight.Image = BlobConversion.ConvertBlobToImage(imageFace.faceRight);
                    numericUpDownSerial.Value = serial;
                    numericUpDownSerpers.Value = serpers;
                }
                else
                {
                    imageFace = new ImageFace { Serial = serial, Serpers = serpers };
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

                    imageFace.faceRight = blob;
                    await ImageFaceController.UpsertImageFace(imageFace);
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
                imageFace.faceRight = null;
                pictureBoxRight.Image = null;
                await ImageFaceController.UpsertImageFace(imageFace);
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);

            }
        }

        private async void buttonUpdateCenter_Click(object sender, EventArgs e)
        {
            string imageLocation;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBoxCenter.ImageLocation = imageLocation;

                    byte[] blob = BlobConversion.ConvertImageToBlob(imageLocation);

                    imageFace.faceFront = blob;
                    await ImageFaceController.UpsertImageFace(imageFace);
                }
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);
            }
        }

        private async void buttonDeleteCenter_Click(object sender, EventArgs e)
        {
            try
            {
                imageFace.faceFront = null;
                pictureBoxCenter.Image = null;
                await ImageFaceController.UpsertImageFace(imageFace);
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);

            }
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

                    imageFace.faceLeft = blob;
                    await ImageFaceController.UpsertImageFace(imageFace);
                }
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
                imageFace.faceLeft = null;
                pictureBoxLeft.Image = null;
                await ImageFaceController.UpsertImageFace(imageFace);
            }
            catch (Exception ex)
            {
                ErrorViewer.ShowError(ex.Message);

            }

        }



        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormFace_Load(object sender, EventArgs e)
        {

        }
    }
}
