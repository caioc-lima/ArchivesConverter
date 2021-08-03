using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchivesConverter.Controls;

namespace ArchivesConverter
{
    public partial class IMAGES_CONVERTER : Form
    {
        String file_name = "";
        String archive_name_full = "";
        String USER = Environment.UserName;

        int ponto;

        public IMAGES_CONVERTER()
        {
            InitializeComponent();
        }

        private void BTN_SELECIONAR_IMAGE_Click(object sender, EventArgs e)
        {
            OpenFileDialog SELECIONAR_ARCHIVE_PDF = new OpenFileDialog();
            SELECIONAR_ARCHIVE_PDF.ShowDialog();

            try
            {
                FileInfo fileInfo = new FileInfo(SELECIONAR_ARCHIVE_PDF.FileName);
                file_name = SELECIONAR_ARCHIVE_PDF.FileName;
                string result = Path.GetFileName(file_name);
                archive_name_full = fileInfo.Name;
                ponto = archive_name_full.IndexOf(".");

                // SHOW
                LABEL_ARCHIVE_SELECTED.Show();
                BTN_REMOVE_ARCHIVE_SELECTED.Show();

                // ACTION
                LABEL_ARCHIVE_SELECTED.Text = result;

                if (LABEL_ARCHIVE_SELECTED.Text != null)
                {
                    // SHOW
                    BTN_IMAGE_ICO.Show();
                    BTN_IMAGE_PNG.Show();
                    BTN_IMAGE_JPEG.Show();
                }
            }
            catch
            {

            }
        }

        private void BTN_REMOVE_ARCHIVE_SELECTED_Click(object sender, EventArgs e)
        {
            // HIDE
            LABEL_ARCHIVE_SELECTED.Hide();
            BTN_IMAGE_ICO.Hide();
            BTN_IMAGE_JPEG.Hide();
            BTN_IMAGE_PNG.Hide();
            BTN_CONVERTER.Hide();

            // ACTION
            LABEL_ARCHIVE_SELECTED.ResetText();

            BTN_IMAGE_ICO.Checked = false;
            BTN_IMAGE_JPEG.Checked = false;
            BTN_IMAGE_PNG.Checked = false;
        }

        private void BTN_IMAGE_PNG_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_IMAGE_PNG.Checked)
            {
                BTN_CONVERTER.Show();
            }
        }
        public void IMAGE_CONVERTER_JPEG()
        {
            Image jpeg = Image.FromFile(file_name);
            jpeg.Save("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

            if (MessageBox.Show("Deseja abrir o arquivo convertido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".jpeg");

                // HIDE
                LABEL_ARCHIVE_SELECTED.Hide();
                BTN_IMAGE_ICO.Hide();
                BTN_IMAGE_JPEG.Hide();
                BTN_IMAGE_PNG.Hide();
                BTN_CONVERTER.Hide();

                // ACTION
                LABEL_ARCHIVE_SELECTED.ResetText();

                BTN_IMAGE_ICO.Checked = false;
                BTN_IMAGE_JPEG.Checked = false;
                BTN_IMAGE_PNG.Checked = false;

            }
            else
            {
                // HIDE
                LABEL_ARCHIVE_SELECTED.Hide();
                BTN_IMAGE_ICO.Hide();
                BTN_IMAGE_JPEG.Hide();
                BTN_IMAGE_PNG.Hide();
                BTN_CONVERTER.Hide();

                // ACTION
                LABEL_ARCHIVE_SELECTED.ResetText();

                BTN_IMAGE_ICO.Checked = false;
                BTN_IMAGE_JPEG.Checked = false;
                BTN_IMAGE_PNG.Checked = false;
            }

            Variables variables = new Variables();

            variables.ARQUIVO = archive_name_full.Substring(0, ponto);
            variables.DE = archive_name_full.Substring(ponto);
            variables.Para = ".jpeg";
            variables.Destino = "C:\\Users\\" + USER + "\\Downloads\\";

            if (Add.NEW_CONVERTER(variables))
            {
                // Conversão armazenada com sucesso
            }
            else
            {
                // Conversão não armazenada
                MessageBox.Show("Não foi possível armazenar a conversão", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void IMAGE_CONVERTER_PNG()
        {
            Image png = Image.FromFile(file_name);
            png.Save("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".png", System.Drawing.Imaging.ImageFormat.Png);

            if (MessageBox.Show("Deseja abrir o arquivo convertido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".png");

                // HIDE
                LABEL_ARCHIVE_SELECTED.Hide();
                BTN_IMAGE_ICO.Hide();
                BTN_IMAGE_JPEG.Hide();
                BTN_IMAGE_PNG.Hide();
                BTN_CONVERTER.Hide();

                // ACTION
                LABEL_ARCHIVE_SELECTED.ResetText();

                BTN_IMAGE_ICO.Checked = false;
                BTN_IMAGE_JPEG.Checked = false;
                BTN_IMAGE_PNG.Checked = false;
            }
            else
            {
                // HIDE
                LABEL_ARCHIVE_SELECTED.Hide();
                BTN_IMAGE_ICO.Hide();
                BTN_IMAGE_JPEG.Hide();
                BTN_IMAGE_PNG.Hide();
                BTN_CONVERTER.Hide();

                // ACTION
                LABEL_ARCHIVE_SELECTED.ResetText();

                BTN_IMAGE_ICO.Checked = false;
                BTN_IMAGE_JPEG.Checked = false;
                BTN_IMAGE_PNG.Checked = false;
            }

            Variables variables = new Variables();

            variables.ARQUIVO = archive_name_full.Substring(0, ponto);
            variables.DE = archive_name_full.Substring(ponto);
            variables.Para = ".png";
            variables.Destino = "C:\\Users\\" + USER + "\\Downloads\\";

            if (Add.NEW_CONVERTER(variables))
            {
                // Conversão armazenada com sucesso
            }
            else
            {
                // Conversão não armazenada
                MessageBox.Show("Não foi possível armazenar a conversão", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void IMAGE_CONVERTER_ICO()
        {
            Image ico = Image.FromFile(file_name);
            ico.Save("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".ico", System.Drawing.Imaging.ImageFormat.Icon);

            if (MessageBox.Show("Deseja abrir o arquivo convertido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".icon");

                // HIDE
                LABEL_ARCHIVE_SELECTED.Hide();
                BTN_IMAGE_ICO.Hide();
                BTN_IMAGE_JPEG.Hide();
                BTN_IMAGE_PNG.Hide();
                BTN_CONVERTER.Hide();

                // ACTION
                LABEL_ARCHIVE_SELECTED.ResetText();

                BTN_IMAGE_ICO.Checked = false;
                BTN_IMAGE_JPEG.Checked = false;
                BTN_IMAGE_PNG.Checked = false;
            }
            else
            {
                // HIDE
                LABEL_ARCHIVE_SELECTED.Hide();
                BTN_IMAGE_ICO.Hide();
                BTN_IMAGE_JPEG.Hide();
                BTN_IMAGE_PNG.Hide();
                BTN_CONVERTER.Hide();

                // ACTION
                LABEL_ARCHIVE_SELECTED.ResetText();

                BTN_IMAGE_ICO.Checked = false;
                BTN_IMAGE_JPEG.Checked = false;
                BTN_IMAGE_PNG.Checked = false;
            }

            Variables variables = new Variables();

            variables.ARQUIVO = archive_name_full.Substring(0, ponto);
            variables.DE = archive_name_full.Substring(ponto);
            variables.Para = ".ico";
            variables.Destino = "C:\\Users\\" + USER + "\\Downloads\\";

            if (Add.NEW_CONVERTER(variables))
            {
                // Conversão armazenada com sucesso
            }
            else
            {
                // Conversão não armazenada
                MessageBox.Show("Não foi possível armazenar a conversão", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_IMAGE_ICO_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_IMAGE_ICO.Checked)
            {
                BTN_CONVERTER.Show();
            }
        }

        private void BTN_CONVERTER_Click(object sender, EventArgs e)
        {
            if (BTN_IMAGE_PNG.Checked)
            {
                IMAGE_CONVERTER_PNG();
            }
            else if(BTN_IMAGE_ICO.Checked)
            {
                IMAGE_CONVERTER_ICO();
            }
            else if (BTN_IMAGE_JPEG.Checked)
            {
                IMAGE_CONVERTER_JPEG();
            }
        }

        private void BTN_IMAGE_JPEG_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_IMAGE_JPEG.Checked)
            {
                BTN_CONVERTER.Show();
            }
        }
    }
}
