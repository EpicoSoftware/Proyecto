namespace App
{
    partial class AdminApp
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
            this.btnSubirAnuncio = new Guna.UI2.WinForms.Guna2Button();
            this.picBannerPreview = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtNombreMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtLink = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBannerPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubirAnuncio
            // 
            this.btnSubirAnuncio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubirAnuncio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubirAnuncio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubirAnuncio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubirAnuncio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubirAnuncio.ForeColor = System.Drawing.Color.White;
            this.btnSubirAnuncio.Location = new System.Drawing.Point(240, 284);
            this.btnSubirAnuncio.Name = "btnSubirAnuncio";
            this.btnSubirAnuncio.Size = new System.Drawing.Size(208, 31);
            this.btnSubirAnuncio.TabIndex = 0;
            this.btnSubirAnuncio.Text = "Subir Imagen Banner";
            this.btnSubirAnuncio.Click += new System.EventHandler(this.btnSubirAnuncio_Click);
            // 
            // picBannerPreview
            // 
            this.picBannerPreview.ImageRotate = 0F;
            this.picBannerPreview.Location = new System.Drawing.Point(240, 27);
            this.picBannerPreview.Name = "picBannerPreview";
            this.picBannerPreview.Size = new System.Drawing.Size(208, 251);
            this.picBannerPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBannerPreview.TabIndex = 1;
            this.picBannerPreview.TabStop = false;
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreMarca.DefaultText = "";
            this.txtNombreMarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreMarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMarca.Location = new System.Drawing.Point(21, 27);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.PasswordChar = '\0';
            this.txtNombreMarca.PlaceholderText = "Nombre de la Marca";
            this.txtNombreMarca.SelectedText = "";
            this.txtNombreMarca.Size = new System.Drawing.Size(200, 36);
            this.txtNombreMarca.TabIndex = 2;
            this.txtNombreMarca.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(21, 368);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(446, 31);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Subir Imagen Banner";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtLink
            // 
            this.txtLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLink.DefaultText = "";
            this.txtLink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLink.Location = new System.Drawing.Point(21, 80);
            this.txtLink.Name = "txtLink";
            this.txtLink.PasswordChar = '\0';
            this.txtLink.PlaceholderText = "Link relacionado";
            this.txtLink.SelectedText = "";
            this.txtLink.Size = new System.Drawing.Size(200, 36);
            this.txtLink.TabIndex = 3;
            this.txtLink.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // AdminApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 411);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.picBannerPreview);
            this.Controls.Add(this.btnSubirAnuncio);
            this.Name = "AdminApp";
            this.Text = "AdminAppcs";
            ((System.ComponentModel.ISupportInitialize)(this.picBannerPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSubirAnuncio;
        private Guna.UI2.WinForms.Guna2PictureBox picBannerPreview;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreMarca;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtLink;
    }
}