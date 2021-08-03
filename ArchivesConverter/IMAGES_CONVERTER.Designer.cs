
namespace ArchivesConverter
{
    partial class IMAGES_CONVERTER
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
            this.PANEL_IMAGES = new System.Windows.Forms.Panel();
            this.BTN_IMAGE_JPEG = new System.Windows.Forms.RadioButton();
            this.BTN_CONVERTER = new System.Windows.Forms.Button();
            this.BTN_IMAGE_ICO = new System.Windows.Forms.RadioButton();
            this.BTN_IMAGE_PNG = new System.Windows.Forms.RadioButton();
            this.BTN_REMOVE_ARCHIVE_SELECTED = new System.Windows.Forms.Button();
            this.LABEL_ARCHIVE_SELECTED = new System.Windows.Forms.Label();
            this.BTN_SELECIONAR_IMAGE = new System.Windows.Forms.Button();
            this.PANEL_TITTLE_IMAGES = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PANEL_IMAGES.SuspendLayout();
            this.PANEL_TITTLE_IMAGES.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_IMAGES
            // 
            this.PANEL_IMAGES.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PANEL_IMAGES.Controls.Add(this.BTN_IMAGE_JPEG);
            this.PANEL_IMAGES.Controls.Add(this.BTN_CONVERTER);
            this.PANEL_IMAGES.Controls.Add(this.BTN_IMAGE_ICO);
            this.PANEL_IMAGES.Controls.Add(this.BTN_IMAGE_PNG);
            this.PANEL_IMAGES.Controls.Add(this.BTN_REMOVE_ARCHIVE_SELECTED);
            this.PANEL_IMAGES.Controls.Add(this.LABEL_ARCHIVE_SELECTED);
            this.PANEL_IMAGES.Controls.Add(this.BTN_SELECIONAR_IMAGE);
            this.PANEL_IMAGES.Controls.Add(this.PANEL_TITTLE_IMAGES);
            this.PANEL_IMAGES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_IMAGES.Location = new System.Drawing.Point(0, 0);
            this.PANEL_IMAGES.Name = "PANEL_IMAGES";
            this.PANEL_IMAGES.Size = new System.Drawing.Size(800, 450);
            this.PANEL_IMAGES.TabIndex = 0;
            // 
            // BTN_IMAGE_JPEG
            // 
            this.BTN_IMAGE_JPEG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_IMAGE_JPEG.AutoSize = true;
            this.BTN_IMAGE_JPEG.Location = new System.Drawing.Point(280, 238);
            this.BTN_IMAGE_JPEG.Name = "BTN_IMAGE_JPEG";
            this.BTN_IMAGE_JPEG.Size = new System.Drawing.Size(52, 17);
            this.BTN_IMAGE_JPEG.TabIndex = 12;
            this.BTN_IMAGE_JPEG.TabStop = true;
            this.BTN_IMAGE_JPEG.Text = "JPEG";
            this.BTN_IMAGE_JPEG.UseVisualStyleBackColor = true;
            this.BTN_IMAGE_JPEG.Visible = false;
            this.BTN_IMAGE_JPEG.CheckedChanged += new System.EventHandler(this.BTN_IMAGE_JPEG_CheckedChanged);
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
            this.BTN_CONVERTER.Location = new System.Drawing.Point(337, 315);
            this.BTN_CONVERTER.Name = "BTN_CONVERTER";
            this.BTN_CONVERTER.Size = new System.Drawing.Size(137, 49);
            this.BTN_CONVERTER.TabIndex = 11;
            this.BTN_CONVERTER.Text = "Converter";
            this.BTN_CONVERTER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CONVERTER.UseVisualStyleBackColor = false;
            this.BTN_CONVERTER.Visible = false;
            this.BTN_CONVERTER.Click += new System.EventHandler(this.BTN_CONVERTER_Click);
            // 
            // BTN_IMAGE_ICO
            // 
            this.BTN_IMAGE_ICO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_IMAGE_ICO.AutoSize = true;
            this.BTN_IMAGE_ICO.Location = new System.Drawing.Point(480, 238);
            this.BTN_IMAGE_ICO.Name = "BTN_IMAGE_ICO";
            this.BTN_IMAGE_ICO.Size = new System.Drawing.Size(43, 17);
            this.BTN_IMAGE_ICO.TabIndex = 9;
            this.BTN_IMAGE_ICO.TabStop = true;
            this.BTN_IMAGE_ICO.Text = "ICO";
            this.BTN_IMAGE_ICO.UseVisualStyleBackColor = true;
            this.BTN_IMAGE_ICO.Visible = false;
            this.BTN_IMAGE_ICO.CheckedChanged += new System.EventHandler(this.BTN_IMAGE_ICO_CheckedChanged);
            // 
            // BTN_IMAGE_PNG
            // 
            this.BTN_IMAGE_PNG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_IMAGE_PNG.AutoSize = true;
            this.BTN_IMAGE_PNG.Location = new System.Drawing.Point(380, 238);
            this.BTN_IMAGE_PNG.Name = "BTN_IMAGE_PNG";
            this.BTN_IMAGE_PNG.Size = new System.Drawing.Size(48, 17);
            this.BTN_IMAGE_PNG.TabIndex = 8;
            this.BTN_IMAGE_PNG.TabStop = true;
            this.BTN_IMAGE_PNG.Text = "PNG";
            this.BTN_IMAGE_PNG.UseVisualStyleBackColor = true;
            this.BTN_IMAGE_PNG.Visible = false;
            this.BTN_IMAGE_PNG.CheckedChanged += new System.EventHandler(this.BTN_IMAGE_PNG_CheckedChanged);
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
            this.BTN_REMOVE_ARCHIVE_SELECTED.TabIndex = 7;
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
            this.LABEL_ARCHIVE_SELECTED.TabIndex = 6;
            this.LABEL_ARCHIVE_SELECTED.Text = "label1";
            this.LABEL_ARCHIVE_SELECTED.Visible = false;
            // 
            // BTN_SELECIONAR_IMAGE
            // 
            this.BTN_SELECIONAR_IMAGE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_SELECIONAR_IMAGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_SELECIONAR_IMAGE.FlatAppearance.BorderSize = 0;
            this.BTN_SELECIONAR_IMAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SELECIONAR_IMAGE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SELECIONAR_IMAGE.ForeColor = System.Drawing.Color.White;
            this.BTN_SELECIONAR_IMAGE.Image = global::ArchivesConverter.Properties.Resources.add;
            this.BTN_SELECIONAR_IMAGE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SELECIONAR_IMAGE.Location = new System.Drawing.Point(304, 117);
            this.BTN_SELECIONAR_IMAGE.Name = "BTN_SELECIONAR_IMAGE";
            this.BTN_SELECIONAR_IMAGE.Size = new System.Drawing.Size(196, 49);
            this.BTN_SELECIONAR_IMAGE.TabIndex = 5;
            this.BTN_SELECIONAR_IMAGE.Text = "Escolher Arquivo";
            this.BTN_SELECIONAR_IMAGE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SELECIONAR_IMAGE.UseVisualStyleBackColor = false;
            this.BTN_SELECIONAR_IMAGE.Click += new System.EventHandler(this.BTN_SELECIONAR_IMAGE_Click);
            // 
            // PANEL_TITTLE_IMAGES
            // 
            this.PANEL_TITTLE_IMAGES.Controls.Add(this.label1);
            this.PANEL_TITTLE_IMAGES.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_TITTLE_IMAGES.Location = new System.Drawing.Point(0, 0);
            this.PANEL_TITTLE_IMAGES.Name = "PANEL_TITTLE_IMAGES";
            this.PANEL_TITTLE_IMAGES.Size = new System.Drawing.Size(800, 78);
            this.PANEL_TITTLE_IMAGES.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMAGES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IMAGES_CONVERTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PANEL_IMAGES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IMAGES_CONVERTER";
            this.Text = "IMAGES";
            this.PANEL_IMAGES.ResumeLayout(false);
            this.PANEL_IMAGES.PerformLayout();
            this.PANEL_TITTLE_IMAGES.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_IMAGES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PANEL_TITTLE_IMAGES;
        private System.Windows.Forms.Button BTN_REMOVE_ARCHIVE_SELECTED;
        private System.Windows.Forms.Label LABEL_ARCHIVE_SELECTED;
        private System.Windows.Forms.Button BTN_SELECIONAR_IMAGE;
        private System.Windows.Forms.RadioButton BTN_IMAGE_ICO;
        private System.Windows.Forms.RadioButton BTN_IMAGE_PNG;
        private System.Windows.Forms.Button BTN_CONVERTER;
        private System.Windows.Forms.RadioButton BTN_IMAGE_JPEG;
    }
}