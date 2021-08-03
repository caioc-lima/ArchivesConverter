using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using SautinSoft;
using ArchivesConverter.Controls;

namespace ArchivesConverter
{
    public partial class PDF_CONVERTER : Form
    {

        String file_name = "";
        String archive_name_full = "";
        String USER = "";
        String DOCX = "";

        int ponto;

        public PDF_CONVERTER()
        {
            InitializeComponent();
        }

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");

        private void BTN_SELECIONAR_PDF_Click(object sender, EventArgs e)
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

                if(LABEL_ARCHIVE_SELECTED.Text != null)
                {
                    //MessageBox.Show("arquivo carregado");

                    // SHOW
                    BTN_PDF_DOCX.Show();
                    BTN_PDF_EXCEL.Show();
                    BTN_PDF_HTML.Show();
                    BTN_PDF_IMAGE.Show();
                    BTN_PDF_TEXT.Show();
                    BTN_PDF_XML.Show();
                }
            }
            catch
            {

            }
        }

        private void BTN_REMOVE_ARCHIVE_SELECTED_Click(object sender, EventArgs e)
        {
            // HIDE
            BTN_PDF_DOCX.Hide();
            BTN_PDF_EXCEL.Hide();
            BTN_PDF_HTML.Hide();
            BTN_PDF_IMAGE.Hide();
            BTN_PDF_TEXT.Hide();
            BTN_PDF_XML.Hide();
            BTN_TIFF.Hide();
            BTN_JPEG.Hide();
            LABEL_ARCHIVE_SELECTED.Hide();
            BTN_CONVERTER.Hide();
            BTN_REMOVE_ARCHIVE_SELECTED.Hide();

            // CHECKED FALSE
            BTN_PDF_DOCX.Checked = false;
            BTN_PDF_EXCEL.Checked = false;
            BTN_PDF_HTML.Checked = false;
            BTN_PDF_IMAGE.Checked = false;
            BTN_PDF_TEXT.Checked = false;
            BTN_PDF_XML.Checked = false;
            BTN_JPEG.Checked = false;
            BTN_TIFF.Checked = false;

            // ACTION
            LABEL_ARCHIVE_SELECTED.ResetText();

        }

        private void BTN_PDF_DOCX_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_PDF_DOCX.Checked)
            {
                //MessageBox.Show("DOCX selecionado");
                BTN_CONVERTER.Show();

                BTN_TIFF.Hide();
                BTN_JPEG.Hide();
                BTN_JPEG.Checked = false;
                BTN_TIFF.Checked = false;
            }
        }
        public static void RemoveHeadersAndFooters(string caminho_file)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Open(caminho_file, true))
            {
                var docPart = doc.MainDocumentPart;

                if (docPart.HeaderParts.Count() > 0 || docPart.FooterParts.Count() > 0)
                {
                    docPart.DeleteParts(docPart.HeaderParts);
                    docPart.DeleteParts(docPart.FooterParts);
                }
            }
        }
        private void CONVERTER_PDF_DOCX()
        {
            SautinSoft.PdfFocus pdf = new SautinSoft.PdfFocus();
            pdf.OpenPdf(file_name);

            if (pdf.PageCount > 0)
            {
                pdf.WordOptions.Format = SautinSoft.PdfFocus.CWordOptions.eWordDocument.Docx;

                USER = Environment.UserName;
                
                pdf.ToWord("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".docx");

                DOCX = "C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".docx";

                RemoveHeadersAndFooters(DOCX);

                if (MessageBox.Show("Deseja abrir o arquivo convertido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                      
                        
                    System.Diagnostics.Process.Start("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".docx");
                  
                    // HIDE
                    BTN_PDF_DOCX.Hide();
                    BTN_PDF_EXCEL.Hide();
                    BTN_PDF_HTML.Hide();
                    BTN_PDF_IMAGE.Hide();
                    BTN_PDF_TEXT.Hide();
                    BTN_PDF_XML.Hide();
                    BTN_TIFF.Hide();
                    BTN_JPEG.Hide();

                    LABEL_ARCHIVE_SELECTED.Hide();
                    BTN_CONVERTER.Hide();
                    BTN_REMOVE_ARCHIVE_SELECTED.Hide();

                    // CHECKED FALSE
                    BTN_PDF_DOCX.Checked = false;
                    BTN_PDF_EXCEL.Checked = false;
                    BTN_PDF_HTML.Checked = false;
                    BTN_PDF_IMAGE.Checked = false;
                    BTN_PDF_TEXT.Checked = false;
                    BTN_PDF_XML.Checked = false;
                    BTN_JPEG.Checked = false;
                    BTN_TIFF.Checked = false;

                    // ACTION
                    LABEL_ARCHIVE_SELECTED.ResetText();
                }
                else
                {
                    // HIDE
                    BTN_PDF_DOCX.Hide();
                    BTN_PDF_EXCEL.Hide();
                    BTN_PDF_HTML.Hide();
                    BTN_PDF_IMAGE.Hide();
                    BTN_PDF_TEXT.Hide();
                    BTN_PDF_XML.Hide();
                    BTN_TIFF.Hide();
                    BTN_JPEG.Hide();
                    LABEL_ARCHIVE_SELECTED.Hide();
                    BTN_CONVERTER.Hide();
                    BTN_REMOVE_ARCHIVE_SELECTED.Hide();

                    // CHECKED FALSE
                    BTN_PDF_DOCX.Checked = false;
                    BTN_PDF_EXCEL.Checked = false;
                    BTN_PDF_HTML.Checked = false;
                    BTN_PDF_IMAGE.Checked = false;
                    BTN_PDF_TEXT.Checked = false;
                    BTN_PDF_XML.Checked = false;
                    BTN_JPEG.Checked = false;
                    BTN_TIFF.Checked = false;

                    // ACTION
                    LABEL_ARCHIVE_SELECTED.ResetText();
                }
            }

            Variables variables = new Variables();

            variables.ARQUIVO = archive_name_full.Substring(0, ponto);
            variables.DE = archive_name_full.Substring(ponto);
            variables.Para = ".docx";
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

        private void BTN_CONVERTER_Click(object sender, EventArgs e)
        {
            if (BTN_PDF_DOCX.Checked)
            {
                // tudo certo ate aqui
                CONVERTER_PDF_DOCX();
            }
            else if (BTN_JPEG.Checked)
            {
                CONVERTER_PDF_IMAGE_JPEG();
            }
            else if (BTN_TIFF.Checked)
            {
                CONVERTER_PDF_IMAGE_TIFF();
            }
            else if (BTN_PDF_HTML.Checked)
            {
                //CONVERTER_HTML_IMAGE();
            }
            else if (BTN_PDF_EXCEL.Checked)
            {
                CONVERTER_PDF_EXCEL();
            }
            else if (BTN_PDF_XML.Checked)
            {
                CONVERTER_PDF_XML();
            }
            else if (BTN_PDF_TEXT.Checked)
            {
                CONVERTER_PDF_TEXT();
            }
        }

        private void BTN_PDF_IMAGE_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_PDF_IMAGE.Checked)
            {
                //MessageBox.Show("IMAGE selecionado");
                BTN_JPEG.Show();
                BTN_TIFF.Show();
            }
        }

        private void CONVERTER_PDF_IMAGE_JPEG()
        {
            USER = Environment.UserName;



        }

        private void CONVERTER_PDF_IMAGE_TIFF()
        {

            USER = Environment.UserName;

            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            f.OpenPdf(file_name);

            if (f.PageCount > 0)
            {
                //Save to multipage TIFF file with 300 dpi
                f.ImageOptions.Dpi = 300;
                f.ToMultipageTiff("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".tiff");

                if (MessageBox.Show("Deseja abrir o arquivo convertido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".tiff");

                    // HIDE
                    BTN_PDF_DOCX.Hide();
                    BTN_PDF_EXCEL.Hide();
                    BTN_PDF_HTML.Hide();
                    BTN_PDF_IMAGE.Hide();
                    BTN_PDF_TEXT.Hide();
                    BTN_PDF_XML.Hide();
                    BTN_TIFF.Hide();
                    BTN_JPEG.Hide();
                    LABEL_ARCHIVE_SELECTED.Hide();
                    BTN_CONVERTER.Hide();
                    BTN_REMOVE_ARCHIVE_SELECTED.Hide();

                    // CHECKED FALSE
                    BTN_PDF_DOCX.Checked = false;
                    BTN_PDF_EXCEL.Checked = false;
                    BTN_PDF_HTML.Checked = false;
                    BTN_PDF_IMAGE.Checked = false;
                    BTN_PDF_TEXT.Checked = false;
                    BTN_PDF_XML.Checked = false;
                    BTN_JPEG.Checked = false;
                    BTN_TIFF.Checked = false;

                    // ACTION
                    LABEL_ARCHIVE_SELECTED.ResetText();
                }
                else
                {
                    // HIDE
                    BTN_PDF_DOCX.Hide();
                    BTN_PDF_EXCEL.Hide();
                    BTN_PDF_HTML.Hide();
                    BTN_PDF_IMAGE.Hide();
                    BTN_PDF_TEXT.Hide();
                    BTN_PDF_XML.Hide();
                    BTN_TIFF.Hide();
                    BTN_JPEG.Hide();
                    LABEL_ARCHIVE_SELECTED.Hide();
                    BTN_CONVERTER.Hide();
                    BTN_REMOVE_ARCHIVE_SELECTED.Hide();

                    // CHECKED FALSE
                    BTN_PDF_DOCX.Checked = false;
                    BTN_PDF_EXCEL.Checked = false;
                    BTN_PDF_HTML.Checked = false;
                    BTN_PDF_IMAGE.Checked = false;
                    BTN_PDF_TEXT.Checked = false;
                    BTN_PDF_XML.Checked = false;
                    BTN_JPEG.Checked = false;
                    BTN_TIFF.Checked = false;

                    // ACTION
                    LABEL_ARCHIVE_SELECTED.ResetText();
                }
            }

            Variables variables = new Variables();

            variables.ARQUIVO = archive_name_full.Substring(0, ponto);
            variables.DE = archive_name_full.Substring(ponto);
            variables.Para = ".tiff";
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

        private void BTN_PDF_HTML_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void BTN_PDF_EXCEL_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_PDF_EXCEL.Checked)
            {
                //MessageBox.Show("EXCEL selecionado");
                BTN_CONVERTER.Show();
                BTN_TIFF.Hide();
                BTN_JPEG.Hide();
                BTN_JPEG.Checked = false;
                BTN_TIFF.Checked = false;
            }
        }

        private void CONVERTER_PDF_EXCEL()
        {
            USER = Environment.UserName;

            SautinSoft.PdfFocus EXCEL = new PdfFocus();
            EXCEL.OpenPdf(file_name);

            SautinSoft.PdfFocus f = new PdfFocus();
            f.OpenPdf(file_name);

            if (f.PageCount > 0)
                f.ToExcel("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".xls");

            if (MessageBox.Show("Deseja abrir o arquivo convertido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".xls");
                
                // HIDE
                BTN_PDF_DOCX.Hide();
                BTN_PDF_EXCEL.Hide();
                BTN_PDF_HTML.Hide();
                BTN_PDF_IMAGE.Hide();
                BTN_PDF_TEXT.Hide();
                BTN_PDF_XML.Hide();
                BTN_TIFF.Hide();
                BTN_JPEG.Hide();
                LABEL_ARCHIVE_SELECTED.Hide();
                BTN_CONVERTER.Hide();
                BTN_REMOVE_ARCHIVE_SELECTED.Hide();

                // CHECKED FALSE
                BTN_PDF_DOCX.Checked = false;
                BTN_PDF_EXCEL.Checked = false;
                BTN_PDF_HTML.Checked = false;
                BTN_PDF_IMAGE.Checked = false;
                BTN_PDF_TEXT.Checked = false;
                BTN_PDF_XML.Checked = false;
                BTN_JPEG.Checked = false;
                BTN_TIFF.Checked = false;

                // ACTION
                LABEL_ARCHIVE_SELECTED.ResetText();
            }
            else
            {
                // HIDE
                BTN_PDF_DOCX.Hide();
                BTN_PDF_EXCEL.Hide();
                BTN_PDF_HTML.Hide();
                BTN_PDF_IMAGE.Hide();
                BTN_PDF_TEXT.Hide();
                BTN_PDF_XML.Hide();
                BTN_TIFF.Hide();
                BTN_JPEG.Hide();
                LABEL_ARCHIVE_SELECTED.Hide();
                BTN_CONVERTER.Hide();
                BTN_REMOVE_ARCHIVE_SELECTED.Hide();

                // CHECKED FALSE
                BTN_PDF_DOCX.Checked = false;
                BTN_PDF_EXCEL.Checked = false;
                BTN_PDF_HTML.Checked = false;
                BTN_PDF_IMAGE.Checked = false;
                BTN_PDF_TEXT.Checked = false;
                BTN_PDF_XML.Checked = false;
                BTN_JPEG.Checked = false;
                BTN_TIFF.Checked = false;

                // ACTION
                LABEL_ARCHIVE_SELECTED.ResetText();
            }

            Variables variables = new Variables();

            variables.ARQUIVO = archive_name_full.Substring(0, ponto);
            variables.DE = archive_name_full.Substring(ponto);
            variables.Para = ".xls";
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

        private void BTN_PDF_XML_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_PDF_XML.Checked)
            {
                //MessageBox.Show("XML selecionado");
                BTN_CONVERTER.Show();
                BTN_TIFF.Hide();
                BTN_JPEG.Hide();
                BTN_JPEG.Checked = false;
                BTN_TIFF.Checked = false;
            }
        }

        private void CONVERTER_PDF_XML()
        {
            USER = Environment.UserName;

            SautinSoft.PdfFocus XML = new SautinSoft.PdfFocus();
            XML.XmlOptions.ConvertNonTabularDataToSpreadsheet = false;

            XML.OpenPdf(file_name);
            XML.ToXml("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".xml");

            if (MessageBox.Show("Deseja abrir o arquivo convertido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".xml");

                // HIDE
                BTN_PDF_DOCX.Hide();
                BTN_PDF_EXCEL.Hide();
                BTN_PDF_HTML.Hide();
                BTN_PDF_IMAGE.Hide();
                BTN_PDF_TEXT.Hide();
                BTN_PDF_XML.Hide();
                BTN_TIFF.Hide();
                BTN_JPEG.Hide();
                LABEL_ARCHIVE_SELECTED.Hide();
                BTN_CONVERTER.Hide();
                BTN_REMOVE_ARCHIVE_SELECTED.Hide();

                // CHECKED FALSE
                BTN_PDF_DOCX.Checked = false;
                BTN_PDF_EXCEL.Checked = false;
                BTN_PDF_HTML.Checked = false;
                BTN_PDF_IMAGE.Checked = false;
                BTN_PDF_TEXT.Checked = false;
                BTN_PDF_XML.Checked = false;
                BTN_JPEG.Checked = false;
                BTN_TIFF.Checked = false;

                // ACTION
                LABEL_ARCHIVE_SELECTED.ResetText();
            }
            else
            {
                // HIDE
                BTN_PDF_DOCX.Hide();
                BTN_PDF_EXCEL.Hide();
                BTN_PDF_HTML.Hide();
                BTN_PDF_IMAGE.Hide();
                BTN_PDF_TEXT.Hide();
                BTN_PDF_XML.Hide();
                BTN_TIFF.Hide();
                BTN_JPEG.Hide();
                LABEL_ARCHIVE_SELECTED.Hide();
                BTN_CONVERTER.Hide();
                BTN_REMOVE_ARCHIVE_SELECTED.Hide();

                // CHECKED FALSE
                BTN_PDF_DOCX.Checked = false;
                BTN_PDF_EXCEL.Checked = false;
                BTN_PDF_HTML.Checked = false;
                BTN_PDF_IMAGE.Checked = false;
                BTN_PDF_TEXT.Checked = false;
                BTN_PDF_XML.Checked = false;
                BTN_JPEG.Checked = false;
                BTN_TIFF.Checked = false;

                // ACTION
                LABEL_ARCHIVE_SELECTED.ResetText();
            }

            Variables variables = new Variables();

            variables.ARQUIVO = archive_name_full.Substring(0, ponto);
            variables.DE = archive_name_full.Substring(ponto);
            variables.Para = ".xml";
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

        private void BTN_PDF_TEXT_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_PDF_TEXT.Checked)
            {
                //MessageBox.Show("TEXT selecionado");
                BTN_CONVERTER.Show();
                BTN_TIFF.Hide();
                BTN_JPEG.Hide();
                BTN_JPEG.Checked = false;
                BTN_TIFF.Checked = false;
            }

        }
        private void CONVERTER_PDF_TEXT()
        {
            USER = Environment.UserName;

            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();

            f.OpenPdf(file_name);

            if (f.PageCount > 0)
            {
                f.ToText("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".txt");

                if (MessageBox.Show("Deseja abrir o arquivo convertido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("C:\\Users\\" + USER + "\\Downloads\\" + archive_name_full.Substring(0, ponto) + ".txt");

                    // HIDE
                    BTN_PDF_DOCX.Hide();
                    BTN_PDF_EXCEL.Hide();
                    BTN_PDF_HTML.Hide();
                    BTN_PDF_IMAGE.Hide();
                    BTN_PDF_TEXT.Hide();
                    BTN_PDF_XML.Hide();
                    LABEL_ARCHIVE_SELECTED.Hide();
                    BTN_CONVERTER.Hide();
                    BTN_TIFF.Hide();
                    BTN_JPEG.Hide();

                    BTN_REMOVE_ARCHIVE_SELECTED.Hide();

                    // CHECKED FALSE
                    BTN_PDF_DOCX.Checked = false;
                    BTN_PDF_EXCEL.Checked = false;
                    BTN_PDF_HTML.Checked = false;
                    BTN_PDF_IMAGE.Checked = false;
                    BTN_PDF_TEXT.Checked = false;
                    BTN_PDF_XML.Checked = false;
                    BTN_JPEG.Checked = false;
                    BTN_TIFF.Checked = false;

                    // ACTION
                    LABEL_ARCHIVE_SELECTED.ResetText();
                }
                else
                {
                    // HIDE
                    BTN_PDF_DOCX.Hide();
                    BTN_PDF_EXCEL.Hide();
                    BTN_PDF_HTML.Hide();
                    BTN_PDF_IMAGE.Hide();
                    BTN_PDF_TEXT.Hide();
                    BTN_PDF_XML.Hide();
                    BTN_TIFF.Hide();
                    BTN_JPEG.Hide();
                    LABEL_ARCHIVE_SELECTED.Hide();
                    BTN_CONVERTER.Hide();
                    BTN_REMOVE_ARCHIVE_SELECTED.Hide();

                    // CHECKED FALSE
                    BTN_PDF_DOCX.Checked = false;
                    BTN_PDF_EXCEL.Checked = false;
                    BTN_PDF_HTML.Checked = false;
                    BTN_PDF_IMAGE.Checked = false;
                    BTN_PDF_TEXT.Checked = false;
                    BTN_PDF_XML.Checked = false;
                    BTN_JPEG.Checked = false;
                    BTN_TIFF.Checked = false;

                    // ACTION
                    LABEL_ARCHIVE_SELECTED.ResetText();
                }
            }

            Variables variables = new Variables();

            variables.ARQUIVO = archive_name_full.Substring(0, ponto);
            variables.DE = archive_name_full.Substring(ponto);
            variables.Para = ".txt";
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTN_JPEG_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_JPEG.Checked)
            {
                //MessageBox.Show("IMAGE selecionado");
                BTN_CONVERTER.Show();
            }
        }

        private void BTN_TIFF_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_TIFF.Checked)
            {
                //MessageBox.Show("IMAGE selecionado");
                BTN_CONVERTER.Show();
            }
        }
    }
}
