using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivesConverter
{
    public partial class Form1 : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Form1()
        {
            InitializeComponent();

            
            var fileInfo = new FileInfo("C:\\Archive Converter\\data\\");
            fileInfo.Attributes = FileAttributes.Hidden;
            
        }
        private void BTN_SLIDE_Click(object sender, EventArgs e)
        {
            if (PANEL_MENU_LATERAL.Width == 250)
            {
                PANEL_MENU_LATERAL.Width = 55;
                //PIC_LOGO.Image = Properties.Resources.gear__1_;
                PIC_LOGO.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                //PIC_LOGO.Image = Properties.Resources.logo_market;
                PIC_LOGO.SizeMode = PictureBoxSizeMode.CenterImage;
                PANEL_MENU_LATERAL.Width = 250;
            }
        }

        private void ICON_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ICON_RESTORE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ICON_MAXIMIZED.Visible = true;
            ICON_RESTORE.Visible = false;
        }

        private void ICON_MAXIMIZED_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ICON_RESTORE.Visible = true;
            ICON_MAXIMIZED.Visible = false;
        }

        private void ICON_MINIMIZED_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PANEL_MENU_SUPERIOR_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void OpenFormPanel(object FormFilho)
        {
            if (this.PANEL_CONTENT.Controls.Count > 0)
                this.PANEL_CONTENT.Controls.RemoveAt(0);
            Form ff = FormFilho as Form;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
            this.PANEL_CONTENT.Controls.Add(ff);
            this.PANEL_CONTENT.Tag = ff;
            ff.Show();
        }

        private void BTN_PDF_CONVERTER_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new PDF_CONVERTER());
        }

        private void BTN_HISTORIC_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new HISTORIC());
        }

        private void BTN_IMAGES_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new IMAGES_CONVERTER());
        }
    }
}
