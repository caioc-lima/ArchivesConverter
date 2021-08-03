
namespace ArchivesConverter
{
    partial class PDF_CONVERTER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PANEL_CONVERTER = new System.Windows.Forms.Panel();
            this.BTN_CONVERTER = new System.Windows.Forms.Button();
            this.BTN_PDF_TEXT = new System.Windows.Forms.RadioButton();
            this.BTN_PDF_XML = new System.Windows.Forms.RadioButton();
            this.BTN_PDF_IMAGE = new System.Windows.Forms.RadioButton();
            this.BTN_PDF_EXCEL = new System.Windows.Forms.RadioButton();
            this.BTN_PDF_HTML = new System.Windows.Forms.RadioButton();
            this.BTN_REMOVE_ARCHIVE_SELECTED = new System.Windows.Forms.Button();
            this.LABEL_ARCHIVE_SELECTED = new System.Windows.Forms.Label();
            this.BTN_PDF_DOCX = new System.Windows.Forms.RadioButton();
            this.BTN_SELECIONAR_PDF = new System.Windows.Forms.Button();
            this.PANEL_TITTLE = new System.Windows.Forms.Panel();
            this.LABEL_TITTLE = new System.Windows.Forms.Label();
            this.BTN_TIFF = new System.Windows.Forms.RadioButton();
            this.BTN_JPEG = new System.Windows.Forms.RadioButton();
            this.PANEL_CONVERTER.SuspendLayout();
            this.PANEL_TITTLE.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_CONVERTER
            // 
            this.PANEL_CONVERTER.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PANEL_CONVERTER.Controls.Add(this.BTN_TIFF);
            this.PANEL_CONVERTER.Controls.Add(this.BTN_JPEG);
            this.PANEL_CONVERTER.Controls.Add(this.BTN_CONVERTER);
            this.PANEL_CONVERTER.Controls.Add(this.BTN_PDF_TEXT);
            this.PANEL_CONVERTER.Controls.Add(this.BTN_PDF_XML);
            this.PANEL_CONVERTER.Controls.Add(this.BTN_PDF_IMAGE);
            this.PANEL_CONVERTER.Controls.Add(this.BTN_PDF_EXCEL);
            this.PANEL_CONVERTER.Controls.Add(this.BTN_PDF_HTML);
            this.PANEL_CONVERTER.Controls.Add(this.BTN_REMOVE_ARCHIVE_SELECTED);
            this.PANEL_CONVERTER.Controls.Add(this.LABEL_ARCHIVE_SELECTED);
            this.PANEL_CONVERTER.Controls.Add(this.BTN_PDF_DOCX);
            this.PANEL_CONVERTER.Controls.Add(this.BTN_SELECIONAR_PDF);
            this.PANEL_CONVERTER.Controls.Add(this.PANEL_TITTLE);
            this.PANEL_CONVERTER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONVERTER.Location = new System.Drawing.Point(0, 0);
            this.PANEL_CONVERTER.Name = "PANEL_CONVERTER";
            this.PANEL_CONVERTER.Size = new System.Drawing.Size(800, 450);
            this.PANEL_CONVERTER.TabIndex = 0;
            // 
            // BTN_CONVERTER
            // 
            this.BTN_CONVERTER.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_CONVERTER.BackColor = System.Drawing.Color.DarkOrange;
            this.BTN_CONVERTER.FlatAppearance.BorderSize = 0;
            this.BTN_CONVERTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CONVERTER.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CONVERTER.ForeColor = System.Drawing.Color.White;
            this.BTN_CONVERTER.Image = global::ArchivesConverter.Properties.Resources.file__1_;
            this.BTN_CONVERTER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CONVERTER.Location = new System.Drawing.Point(335, 323);
            this.BTN_CONVERTER.Name = "BTN_CONVERTER";
            this.BTN_CONVERTER.Size = new System.Drawing.Size(137, 49);
            this.BTN_CONVERTER.TabIndex = 10;
            this.BTN_CONVERTER.Text = "Converter";
            this.BTN_CONVERTER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CONVERTER.UseVisualStyleBackColor = false;
            this.BTN_CONVERTER.Visible = false;
            this.BTN_CONVERTER.Click += new System.EventHandler(this.BTN_CONVERTER_Click);
            // 
            // BTN_PDF_TEXT
            // 
            this.BTN_PDF_TEXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_PDF_TEXT.AutoSize = true;
            this.BTN_PDF_TEXT.Location = new System.Drawing.Point(619, 228);
            this.BTN_PDF_TEXT.Name = "BTN_PDF_TEXT";
            this.BTN_PDF_TEXT.Size = new System.Drawing.Size(53, 17);
            this.BTN_PDF_TEXT.TabIndex = 9;
            this.BTN_PDF_TEXT.TabStop = true;
            this.BTN_PDF_TEXT.Text = "TEXT";
            this.BTN_PDF_TEXT.UseVisualStyleBackColor = true;
            this.BTN_PDF_TEXT.Visible = false;
            this.BTN_PDF_TEXT.CheckedChanged += new System.EventHandler(this.BTN_PDF_TEXT_CheckedChanged);
            // 
            // BTN_PDF_XML
            // 
            this.BTN_PDF_XML.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_PDF_XML.AutoSize = true;
            this.BTN_PDF_XML.Location = new System.Drawing.Point(519, 228);
            this.BTN_PDF_XML.Name = "BTN_PDF_XML";
            this.BTN_PDF_XML.Size = new System.Drawing.Size(47, 17);
            this.BTN_PDF_XML.TabIndex = 8;
            this.BTN_PDF_XML.TabStop = true;
            this.BTN_PDF_XML.Text = "XML";
            this.BTN_PDF_XML.UseVisualStyleBackColor = true;
            this.BTN_PDF_XML.Visible = false;
            this.BTN_PDF_XML.CheckedChanged += new System.EventHandler(this.BTN_PDF_XML_CheckedChanged);
            // 
            // BTN_PDF_IMAGE
            // 
            this.BTN_PDF_IMAGE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_PDF_IMAGE.AutoSize = true;
            this.BTN_PDF_IMAGE.Location = new System.Drawing.Point(219, 228);
            this.BTN_PDF_IMAGE.Name = "BTN_PDF_IMAGE";
            this.BTN_PDF_IMAGE.Size = new System.Drawing.Size(59, 17);
            this.BTN_PDF_IMAGE.TabIndex = 7;
            this.BTN_PDF_IMAGE.TabStop = true;
            this.BTN_PDF_IMAGE.Text = "IMAGE";
            this.BTN_PDF_IMAGE.UseVisualStyleBackColor = true;
            this.BTN_PDF_IMAGE.Visible = false;
            this.BTN_PDF_IMAGE.CheckedChanged += new System.EventHandler(this.BTN_PDF_IMAGE_CheckedChanged);
            // 
            // BTN_PDF_EXCEL
            // 
            this.BTN_PDF_EXCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_PDF_EXCEL.AutoSize = true;
            this.BTN_PDF_EXCEL.Location = new System.Drawing.Point(419, 228);
            this.BTN_PDF_EXCEL.Name = "BTN_PDF_EXCEL";
            this.BTN_PDF_EXCEL.Size = new System.Drawing.Size(59, 17);
            this.BTN_PDF_EXCEL.TabIndex = 6;
            this.BTN_PDF_EXCEL.TabStop = true;
            this.BTN_PDF_EXCEL.Text = "EXCEL";
            this.BTN_PDF_EXCEL.UseVisualStyleBackColor = true;
            this.BTN_PDF_EXCEL.Visible = false;
            this.BTN_PDF_EXCEL.CheckedChanged += new System.EventHandler(this.BTN_PDF_EXCEL_CheckedChanged);
            // 
            // BTN_PDF_HTML
            // 
            this.BTN_PDF_HTML.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_PDF_HTML.AutoSize = true;
            this.BTN_PDF_HTML.Enabled = false;
            this.BTN_PDF_HTML.Location = new System.Drawing.Point(319, 228);
            this.BTN_PDF_HTML.Name = "BTN_PDF_HTML";
            this.BTN_PDF_HTML.Size = new System.Drawing.Size(55, 17);
            this.BTN_PDF_HTML.TabIndex = 5;
            this.BTN_PDF_HTML.TabStop = true;
            this.BTN_PDF_HTML.Text = "HTML";
            this.BTN_PDF_HTML.UseVisualStyleBackColor = true;
            this.BTN_PDF_HTML.Visible = false;
            this.BTN_PDF_HTML.CheckedChanged += new System.EventHandler(this.BTN_PDF_HTML_CheckedChanged);
            // 
            // BTN_REMOVE_ARCHIVE_SELECTED
            // 
            this.BTN_REMOVE_ARCHIVE_SELECTED.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_REMOVE_ARCHIVE_SELECTED.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTN_REMOVE_ARCHIVE_SELECTED.FlatAppearance.BorderSize = 0;
            this.BTN_REMOVE_ARCHIVE_SELECTED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_REMOVE_ARCHIVE_SELECTED.Location = new System.Drawing.Point(435, 168);
            this.BTN_REMOVE_ARCHIVE_SELECTED.Name = "BTN_REMOVE_ARCHIVE_SELECTED";
            this.BTN_REMOVE_ARCHIVE_SELECTED.Size = new System.Drawing.Size(65, 23);
            this.BTN_REMOVE_ARCHIVE_SELECTED.TabIndex = 4;
            this.BTN_REMOVE_ARCHIVE_SELECTED.Text = "Remover";
            this.BTN_REMOVE_ARCHIVE_SELECTED.UseVisualStyleBackColor = false;
            this.BTN_REMOVE_ARCHIVE_SELECTED.Visible = false;
            this.BTN_REMOVE_ARCHIVE_SELECTED.Click += new System.EventHandler(this.BTN_REMOVE_ARCHIVE_SELECTED_Click);
            // 
            // LABEL_ARCHIVE_SELECTED
            // 
            this.LABEL_ARCHIVE_SELECTED.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LABEL_ARCHIVE_SELECTED.Location = new System.Drawing.Point(304, 173);
            this.LABEL_ARCHIVE_SELECTED.Name = "LABEL_ARCHIVE_SELECTED";
            this.LABEL_ARCHIVE_SELECTED.Size = new System.Drawing.Size(125, 16);
            this.LABEL_ARCHIVE_SELECTED.TabIndex = 3;
            this.LABEL_ARCHIVE_SELECTED.Text = "label1";
            this.LABEL_ARCHIVE_SELECTED.Visible = false;
            // 
            // BTN_PDF_DOCX
            // 
            this.BTN_PDF_DOCX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_PDF_DOCX.AutoSize = true;
            this.BTN_PDF_DOCX.Location = new System.Drawing.Point(119, 228);
            this.BTN_PDF_DOCX.Name = "BTN_PDF_DOCX";
            this.BTN_PDF_DOCX.Size = new System.Drawing.Size(55, 17);
            this.BTN_PDF_DOCX.TabIndex = 2;
            this.BTN_PDF_DOCX.TabStop = true;
            this.BTN_PDF_DOCX.Text = "DOCX";
            this.BTN_PDF_DOCX.UseVisualStyleBackColor = true;
            this.BTN_PDF_DOCX.Visible = false;
            this.BTN_PDF_DOCX.CheckedChanged += new System.EventHandler(this.BTN_PDF_DOCX_CheckedChanged);
            // 
            // BTN_SELECIONAR_PDF
            // 
            this.BTN_SELECIONAR_PDF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_SELECIONAR_PDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_SELECIONAR_PDF.FlatAppearance.BorderSize = 0;
            this.BTN_SELECIONAR_PDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SELECIONAR_PDF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SELECIONAR_PDF.ForeColor = System.Drawing.Color.White;
            this.BTN_SELECIONAR_PDF.Image = global::ArchivesConverter.Properties.Resources.add;
            this.BTN_SELECIONAR_PDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SELECIONAR_PDF.Location = new System.Drawing.Point(304, 117);
            this.BTN_SELECIONAR_PDF.Name = "BTN_SELECIONAR_PDF";
            this.BTN_SELECIONAR_PDF.Size = new System.Drawing.Size(196, 49);
            this.BTN_SELECIONAR_PDF.TabIndex = 1;
            this.BTN_SELECIONAR_PDF.Text = "Escolher Arquivo";
            this.BTN_SELECIONAR_PDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SELECIONAR_PDF.UseVisualStyleBackColor = false;
            this.BTN_SELECIONAR_PDF.Click += new System.EventHandler(this.BTN_SELECIONAR_PDF_Click);
            // 
            // PANEL_TITTLE
            // 
            this.PANEL_TITTLE.Controls.Add(this.LABEL_TITTLE);
            this.PANEL_TITTLE.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_TITTLE.Location = new System.Drawing.Point(0, 0);
            this.PANEL_TITTLE.Name = "PANEL_TITTLE";
            this.PANEL_TITTLE.Size = new System.Drawing.Size(800, 78);
            this.PANEL_TITTLE.TabIndex = 0;
            // 
            // LABEL_TITTLE
            // 
            this.LABEL_TITTLE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LABEL_TITTLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LABEL_TITTLE.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_TITTLE.ForeColor = System.Drawing.Color.Black;
            this.LABEL_TITTLE.Location = new System.Drawing.Point(0, 0);
            this.LABEL_TITTLE.Name = "LABEL_TITTLE";
            this.LABEL_TITTLE.Size = new System.Drawing.Size(800, 78);
            this.LABEL_TITTLE.TabIndex = 0;
            this.LABEL_TITTLE.Text = "CONVERTER PDF";
            this.LABEL_TITTLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_TIFF
            // 
            this.BTN_TIFF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_TIFF.AutoSize = true;
            this.BTN_TIFF.Location = new System.Drawing.Point(267, 269);
            this.BTN_TIFF.Name = "BTN_TIFF";
            this.BTN_TIFF.Size = new System.Drawing.Size(47, 17);
            this.BTN_TIFF.TabIndex = 14;
            this.BTN_TIFF.TabStop = true;
            this.BTN_TIFF.Text = "TIFF";
            this.BTN_TIFF.UseVisualStyleBackColor = true;
            this.BTN_TIFF.Visible = false;
            this.BTN_TIFF.CheckedChanged += new System.EventHandler(this.BTN_TIFF_CheckedChanged);
            // 
            // BTN_JPEG
            // 
            this.BTN_JPEG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_JPEG.AutoSize = true;
            this.BTN_JPEG.Location = new System.Drawing.Point(189, 269);
            this.BTN_JPEG.Name = "BTN_JPEG";
            this.BTN_JPEG.Size = new System.Drawing.Size(52, 17);
            this.BTN_JPEG.TabIndex = 13;
            this.BTN_JPEG.TabStop = true;
            this.BTN_JPEG.Text = "JPEG";
            this.BTN_JPEG.UseVisualStyleBackColor = true;
            this.BTN_JPEG.Visible = false;
            this.BTN_JPEG.CheckedChanged += new System.EventHandler(this.BTN_JPEG_CheckedChanged);
            // 
            // PDF_CONVERTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PANEL_CONVERTER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PDF_CONVERTER";
            this.Text = "CONVERTER";
            this.PANEL_CONVERTER.ResumeLayout(false);
            this.PANEL_CONVERTER.PerformLayout();
            this.PANEL_TITTLE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_CONVERTER;
        private System.Windows.Forms.Panel PANEL_TITTLE;
        private System.Windows.Forms.Label LABEL_TITTLE;
        private System.Windows.Forms.Button BTN_SELECIONAR_PDF;
        private System.Windows.Forms.Label LABEL_ARCHIVE_SELECTED;
        private System.Windows.Forms.RadioButton BTN_PDF_DOCX;
        private System.Windows.Forms.Button BTN_REMOVE_ARCHIVE_SELECTED;
        private System.Windows.Forms.RadioButton BTN_PDF_TEXT;
        private System.Windows.Forms.RadioButton BTN_PDF_XML;
        private System.Windows.Forms.RadioButton BTN_PDF_IMAGE;
        private System.Windows.Forms.RadioButton BTN_PDF_EXCEL;
        private System.Windows.Forms.RadioButton BTN_PDF_HTML;
        private System.Windows.Forms.Button BTN_CONVERTER;
        private System.Windows.Forms.RadioButton BTN_TIFF;
        private System.Windows.Forms.RadioButton BTN_JPEG;
    }
}