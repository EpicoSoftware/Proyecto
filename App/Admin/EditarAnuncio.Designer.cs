namespace App.Admin
{
    partial class EditarAnuncio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarAnuncio));
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCargarImg = new Guna.UI2.WinForms.Guna2Button();
            this.picBannerPreview = new Guna.UI2.WinForms.Guna2PictureBox();
            this.toggleEstado = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblEstado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLink = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCorreoContacto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBannerPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnActualizar.BorderThickness = 3;
            this.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizar.FillColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnActualizar.Location = new System.Drawing.Point(387, 479);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(247, 45);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseTransparentBackground = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarImg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargarImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargarImg.FillColor = System.Drawing.Color.DimGray;
            this.btnCargarImg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCargarImg.ForeColor = System.Drawing.Color.White;
            this.btnCargarImg.Location = new System.Drawing.Point(31, 479);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(200, 45);
            this.btnCargarImg.TabIndex = 24;
            this.btnCargarImg.Text = "Cargar Imagen";
            this.btnCargarImg.Click += new System.EventHandler(this.btnCargarImg_Click);
            // 
            // picBannerPreview
            // 
            this.picBannerPreview.BackColor = System.Drawing.Color.Transparent;
            this.picBannerPreview.FillColor = System.Drawing.Color.DimGray;
            this.picBannerPreview.ImageRotate = 0F;
            this.picBannerPreview.Location = new System.Drawing.Point(31, 228);
            this.picBannerPreview.Name = "picBannerPreview";
            this.picBannerPreview.Size = new System.Drawing.Size(200, 247);
            this.picBannerPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBannerPreview.TabIndex = 23;
            this.picBannerPreview.TabStop = false;
            this.picBannerPreview.UseTransparentBackground = true;
            // 
            // toggleEstado
            // 
            this.toggleEstado.Animated = true;
            this.toggleEstado.Checked = true;
            this.toggleEstado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.toggleEstado.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.toggleEstado.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleEstado.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleEstado.Location = new System.Drawing.Point(387, 156);
            this.toggleEstado.Name = "toggleEstado";
            this.toggleEstado.Size = new System.Drawing.Size(39, 20);
            this.toggleEstado.TabIndex = 22;
            this.toggleEstado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleEstado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleEstado.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleEstado.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(330, 152);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(49, 28);
            this.lblEstado.TabIndex = 21;
            this.lblEstado.Text = "Activo";
            // 
            // txtLink
            // 
            this.txtLink.Animated = true;
            this.txtLink.AutoRoundedCorners = true;
            this.txtLink.BorderRadius = 21;
            this.txtLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLink.DefaultText = "";
            this.txtLink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLink.FillColor = System.Drawing.Color.Transparent;
            this.txtLink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLink.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtLink.ForeColor = System.Drawing.Color.White;
            this.txtLink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLink.Location = new System.Drawing.Point(31, 143);
            this.txtLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLink.Name = "txtLink";
            this.txtLink.PasswordChar = '\0';
            this.txtLink.PlaceholderText = "Link en el anuncio";
            this.txtLink.SelectedText = "";
            this.txtLink.Size = new System.Drawing.Size(282, 44);
            this.txtLink.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtLink.TabIndex = 20;
            // 
            // txtCorreoContacto
            // 
            this.txtCorreoContacto.Animated = true;
            this.txtCorreoContacto.AutoRoundedCorners = true;
            this.txtCorreoContacto.BorderRadius = 21;
            this.txtCorreoContacto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreoContacto.DefaultText = "";
            this.txtCorreoContacto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreoContacto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreoContacto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreoContacto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreoContacto.FillColor = System.Drawing.Color.Transparent;
            this.txtCorreoContacto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreoContacto.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtCorreoContacto.ForeColor = System.Drawing.Color.White;
            this.txtCorreoContacto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreoContacto.Location = new System.Drawing.Point(332, 80);
            this.txtCorreoContacto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreoContacto.Name = "txtCorreoContacto";
            this.txtCorreoContacto.PasswordChar = '\0';
            this.txtCorreoContacto.PlaceholderText = "Correo de contacto del anunciante";
            this.txtCorreoContacto.SelectedText = "";
            this.txtCorreoContacto.Size = new System.Drawing.Size(282, 44);
            this.txtCorreoContacto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCorreoContacto.TabIndex = 19;
            // 
            // txtMarca
            // 
            this.txtMarca.Animated = true;
            this.txtMarca.AutoRoundedCorners = true;
            this.txtMarca.BorderRadius = 21;
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.DefaultText = "";
            this.txtMarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarca.FillColor = System.Drawing.Color.Transparent;
            this.txtMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarca.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarca.Location = new System.Drawing.Point(31, 80);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.PlaceholderText = "Nombre de marca anunciante";
            this.txtMarca.SelectedText = "";
            this.txtMarca.Size = new System.Drawing.Size(282, 44);
            this.txtMarca.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMarca.TabIndex = 18;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(31, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(181, 44);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "Editar anuncio";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(608, 13);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 26;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // EditarAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(665, 548);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCargarImg);
            this.Controls.Add(this.picBannerPreview);
            this.Controls.Add(this.toggleEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtCorreoContacto);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarAnuncio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarAnuncio";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditarAnuncio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBannerPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnCargarImg;
        private Guna.UI2.WinForms.Guna2PictureBox picBannerPreview;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleEstado;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstado;
        private Guna.UI2.WinForms.Guna2TextBox txtLink;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreoContacto;
        private Guna.UI2.WinForms.Guna2TextBox txtMarca;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}