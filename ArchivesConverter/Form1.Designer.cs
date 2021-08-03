
namespace ArchivesConverter
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PANEL_MENU_LATERAL = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PANEL_MENU_SUPERIOR = new System.Windows.Forms.Panel();
            this.PANEL_CONTENT = new System.Windows.Forms.Panel();
            this.ICON_MINIMIZED = new System.Windows.Forms.PictureBox();
            this.ICON_RESTORE = new System.Windows.Forms.PictureBox();
            this.ICON_MAXIMIZED = new System.Windows.Forms.PictureBox();
            this.ICON_CLOSE = new System.Windows.Forms.PictureBox();
            this.BTN_SLIDE = new System.Windows.Forms.PictureBox();
            this.BTN_IMAGES = new System.Windows.Forms.Button();
            this.BTN_HISTORIC = new System.Windows.Forms.Button();
            this.BTN_PDF_CONVERTER = new System.Windows.Forms.Button();
            this.PIC_LOGO = new System.Windows.Forms.PictureBox();
            this.PANEL_MENU_LATERAL.SuspendLayout();
            this.PANEL_MENU_SUPERIOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_MINIMIZED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_RESTORE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_MAXIMIZED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_CLOSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_SLIDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_MENU_LATERAL
            // 
            this.PANEL_MENU_LATERAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PANEL_MENU_LATERAL.Controls.Add(this.BTN_IMAGES);
            this.PANEL_MENU_LATERAL.Controls.Add(this.BTN_HISTORIC);
            this.PANEL_MENU_LATERAL.Controls.Add(this.BTN_PDF_CONVERTER);
            this.PANEL_MENU_LATERAL.Controls.Add(this.label1);
            this.PANEL_MENU_LATERAL.Controls.Add(this.PIC_LOGO);
            this.PANEL_MENU_LATERAL.Dock = System.Windows.Forms.DockStyle.Left;
            this.PANEL_MENU_LATERAL.Location = new System.Drawing.Point(0, 0);
            this.PANEL_MENU_LATERAL.Name = "PANEL_MENU_LATERAL";
            this.PANEL_MENU_LATERAL.Size = new System.Drawing.Size(250, 500);
            this.PANEL_MENU_LATERAL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archives Converter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PANEL_MENU_SUPERIOR
            // 
            this.PANEL_MENU_SUPERIOR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PANEL_MENU_SUPERIOR.Controls.Add(this.ICON_MINIMIZED);
            this.PANEL_MENU_SUPERIOR.Controls.Add(this.ICON_RESTORE);
            this.PANEL_MENU_SUPERIOR.Controls.Add(this.ICON_MAXIMIZED);
            this.PANEL_MENU_SUPERIOR.Controls.Add(this.ICON_CLOSE);
            this.PANEL_MENU_SUPERIOR.Controls.Add(this.BTN_SLIDE);
            this.PANEL_MENU_SUPERIOR.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_MENU_SUPERIOR.Location = new System.Drawing.Point(250, 0);
            this.PANEL_MENU_SUPERIOR.Name = "PANEL_MENU_SUPERIOR";
            this.PANEL_MENU_SUPERIOR.Size = new System.Drawing.Size(750, 55);
            this.PANEL_MENU_SUPERIOR.TabIndex = 1;
            this.PANEL_MENU_SUPERIOR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PANEL_MENU_SUPERIOR_MouseDown);
            // 
            // PANEL_CONTENT
            // 
            this.PANEL_CONTENT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PANEL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONTENT.Location = new System.Drawing.Point(250, 55);
            this.PANEL_CONTENT.Name = "PANEL_CONTENT";
            this.PANEL_CONTENT.Size = new System.Drawing.Size(750, 445);
            this.PANEL_CONTENT.TabIndex = 2;
            // 
            // ICON_MINIMIZED
            // 
            this.ICON_MINIMIZED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICON_MINIMIZED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICON_MINIMIZED.Image = global::ArchivesConverter.Properties.Resources.e629486b00b62fe708ffb795eca820b2_removebg_preview;
            this.ICON_MINIMIZED.Location = new System.Drawing.Point(666, 6);
            this.ICON_MINIMIZED.Name = "ICON_MINIMIZED";
            this.ICON_MINIMIZED.Size = new System.Drawing.Size(20, 20);
            this.ICON_MINIMIZED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ICON_MINIMIZED.TabIndex = 181;
            this.ICON_MINIMIZED.TabStop = false;
            this.ICON_MINIMIZED.Click += new System.EventHandler(this.ICON_MINIMIZED_Click);
            // 
            // ICON_RESTORE
            // 
            this.ICON_RESTORE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICON_RESTORE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICON_RESTORE.Image = global::ArchivesConverter.Properties.Resources.squares__1_;
            this.ICON_RESTORE.Location = new System.Drawing.Point(693, 6);
            this.ICON_RESTORE.Name = "ICON_RESTORE";
            this.ICON_RESTORE.Size = new System.Drawing.Size(20, 20);
            this.ICON_RESTORE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ICON_RESTORE.TabIndex = 180;
            this.ICON_RESTORE.TabStop = false;
            this.ICON_RESTORE.Visible = false;
            this.ICON_RESTORE.Click += new System.EventHandler(this.ICON_RESTORE_Click);
            // 
            // ICON_MAXIMIZED
            // 
            this.ICON_MAXIMIZED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICON_MAXIMIZED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICON_MAXIMIZED.Image = global::ArchivesConverter.Properties.Resources.squares;
            this.ICON_MAXIMIZED.Location = new System.Drawing.Point(693, 6);
            this.ICON_MAXIMIZED.Name = "ICON_MAXIMIZED";
            this.ICON_MAXIMIZED.Size = new System.Drawing.Size(20, 20);
            this.ICON_MAXIMIZED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ICON_MAXIMIZED.TabIndex = 179;
            this.ICON_MAXIMIZED.TabStop = false;
            this.ICON_MAXIMIZED.Click += new System.EventHandler(this.ICON_MAXIMIZED_Click);
            // 
            // ICON_CLOSE
            // 
            this.ICON_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICON_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICON_CLOSE.Image = global::ArchivesConverter.Properties.Resources.close;
            this.ICON_CLOSE.Location = new System.Drawing.Point(719, 6);
            this.ICON_CLOSE.Name = "ICON_CLOSE";
            this.ICON_CLOSE.Size = new System.Drawing.Size(20, 20);
            this.ICON_CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ICON_CLOSE.TabIndex = 182;
            this.ICON_CLOSE.TabStop = false;
            this.ICON_CLOSE.Click += new System.EventHandler(this.ICON_CLOSE_Click);
            // 
            // BTN_SLIDE
            // 
            this.BTN_SLIDE.BackColor = System.Drawing.Color.Transparent;
            this.BTN_SLIDE.Image = global::ArchivesConverter.Properties.Resources.botao_de_menu_de_tres_linhas_horizontais;
            this.BTN_SLIDE.Location = new System.Drawing.Point(11, 12);
            this.BTN_SLIDE.Name = "BTN_SLIDE";
            this.BTN_SLIDE.Size = new System.Drawing.Size(33, 31);
            this.BTN_SLIDE.TabIndex = 1;
            this.BTN_SLIDE.TabStop = false;
            this.BTN_SLIDE.Click += new System.EventHandler(this.BTN_SLIDE_Click);
            // 
            // BTN_IMAGES
            // 
            this.BTN_IMAGES.FlatAppearance.BorderSize = 0;
            this.BTN_IMAGES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_IMAGES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_IMAGES.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_IMAGES.ForeColor = System.Drawing.Color.White;
            this.BTN_IMAGES.Image = global::ArchivesConverter.Properties.Resources.image;
            this.BTN_IMAGES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_IMAGES.Location = new System.Drawing.Point(0, 192);
            this.BTN_IMAGES.Name = "BTN_IMAGES";
            this.BTN_IMAGES.Size = new System.Drawing.Size(250, 40);
            this.BTN_IMAGES.TabIndex = 6;
            this.BTN_IMAGES.Text = "IMAGE CONVERTER";
            this.BTN_IMAGES.UseVisualStyleBackColor = true;
            this.BTN_IMAGES.Click += new System.EventHandler(this.BTN_IMAGES_Click);
            // 
            // BTN_HISTORIC
            // 
            this.BTN_HISTORIC.FlatAppearance.BorderSize = 0;
            this.BTN_HISTORIC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_HISTORIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HISTORIC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_HISTORIC.ForeColor = System.Drawing.Color.White;
            this.BTN_HISTORIC.Image = global::ArchivesConverter.Properties.Resources.return_to_the_past;
            this.BTN_HISTORIC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_HISTORIC.Location = new System.Drawing.Point(0, 238);
            this.BTN_HISTORIC.Name = "BTN_HISTORIC";
            this.BTN_HISTORIC.Size = new System.Drawing.Size(250, 40);
            this.BTN_HISTORIC.TabIndex = 5;
            this.BTN_HISTORIC.Text = "Histórico";
            this.BTN_HISTORIC.UseVisualStyleBackColor = true;
            this.BTN_HISTORIC.Click += new System.EventHandler(this.BTN_HISTORIC_Click);
            // 
            // BTN_PDF_CONVERTER
            // 
            this.BTN_PDF_CONVERTER.FlatAppearance.BorderSize = 0;
            this.BTN_PDF_CONVERTER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_PDF_CONVERTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PDF_CONVERTER.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PDF_CONVERTER.ForeColor = System.Drawing.Color.White;
            this.BTN_PDF_CONVERTER.Image = global::ArchivesConverter.Properties.Resources.file;
            this.BTN_PDF_CONVERTER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_PDF_CONVERTER.Location = new System.Drawing.Point(0, 146);
            this.BTN_PDF_CONVERTER.Name = "BTN_PDF_CONVERTER";
            this.BTN_PDF_CONVERTER.Size = new System.Drawing.Size(250, 40);
            this.BTN_PDF_CONVERTER.TabIndex = 4;
            this.BTN_PDF_CONVERTER.Text = "PDF Converter";
            this.BTN_PDF_CONVERTER.UseVisualStyleBackColor = true;
            this.BTN_PDF_CONVERTER.Click += new System.EventHandler(this.BTN_PDF_CONVERTER_Click);
            // 
            // PIC_LOGO
            // 
            this.PIC_LOGO.Image = global::ArchivesConverter.Properties.Resources.gear;
            this.PIC_LOGO.Location = new System.Drawing.Point(0, 0);
            this.PIC_LOGO.Name = "PIC_LOGO";
            this.PIC_LOGO.Size = new System.Drawing.Size(55, 55);
            this.PIC_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PIC_LOGO.TabIndex = 0;
            this.PIC_LOGO.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.PANEL_CONTENT);
            this.Controls.Add(this.PANEL_MENU_SUPERIOR);
            this.Controls.Add(this.PANEL_MENU_LATERAL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PANEL_MENU_LATERAL.ResumeLayout(false);
            this.PANEL_MENU_SUPERIOR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ICON_MINIMIZED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_RESTORE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_MAXIMIZED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICON_CLOSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_SLIDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_LOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_MENU_LATERAL;
        private System.Windows.Forms.Panel PANEL_MENU_SUPERIOR;
        private System.Windows.Forms.Panel PANEL_CONTENT;
        private System.Windows.Forms.PictureBox PIC_LOGO;
        private System.Windows.Forms.PictureBox BTN_SLIDE;
        private System.Windows.Forms.PictureBox ICON_MINIMIZED;
        private System.Windows.Forms.PictureBox ICON_RESTORE;
        private System.Windows.Forms.PictureBox ICON_MAXIMIZED;
        private System.Windows.Forms.PictureBox ICON_CLOSE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_HISTORIC;
        private System.Windows.Forms.Button BTN_PDF_CONVERTER;
        private System.Windows.Forms.Button BTN_IMAGES;
    }
}

