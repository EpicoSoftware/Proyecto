namespace App
{
    partial class GestorAnuncios
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpAnuncios = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.scbAnuncios = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCorreoContacto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLink = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.toggleEstado = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblPreview = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPublicar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCargarImg = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefrescar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.picBannerPreview = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBannerPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // flpAnuncios
            // 
            this.flpAnuncios.AutoScroll = true;
            this.flpAnuncios.Location = new System.Drawing.Point(90, 169);
            this.flpAnuncios.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flpAnuncios.Name = "flpAnuncios";
            this.flpAnuncios.Size = new System.Drawing.Size(708, 896);
            this.flpAnuncios.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Animated = true;
            this.txtBuscar.AutoRoundedCorners = true;
            this.txtBuscar.BorderRadius = 41;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FillColor = System.Drawing.Color.Transparent;
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(86, 56);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "Busca por marca aqui";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(524, 85);
            this.txtBuscar.TabIndex = 2;
            // 
            // scbAnuncios
            // 
            this.scbAnuncios.BindingContainer = this.flpAnuncios;
            this.scbAnuncios.FillOffset = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.scbAnuncios.InUpdate = false;
            this.scbAnuncios.LargeChange = 10;
            this.scbAnuncios.Location = new System.Drawing.Point(764, 169);
            this.scbAnuncios.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.scbAnuncios.Name = "scbAnuncios";
            this.scbAnuncios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.scbAnuncios.ScrollbarSize = 14;
            this.scbAnuncios.Size = new System.Drawing.Size(34, 896);
            this.scbAnuncios.TabIndex = 4;
            this.scbAnuncios.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(870, 44);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(358, 86);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Crear anuncio";
            // 
            // txtMarca
            // 
            this.txtMarca.Animated = true;
            this.txtMarca.AutoRoundedCorners = true;
            this.txtMarca.BorderRadius = 41;
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
            this.txtMarca.Location = new System.Drawing.Point(870, 152);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.PlaceholderText = "Nombre de marca anunciante";
            this.txtMarca.SelectedText = "";
            this.txtMarca.Size = new System.Drawing.Size(564, 85);
            this.txtMarca.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMarca.TabIndex = 6;
            // 
            // txtCorreoContacto
            // 
            this.txtCorreoContacto.Animated = true;
            this.txtCorreoContacto.AutoRoundedCorners = true;
            this.txtCorreoContacto.BorderRadius = 41;
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
            this.txtCorreoContacto.Location = new System.Drawing.Point(1472, 152);
            this.txtCorreoContacto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCorreoContacto.Name = "txtCorreoContacto";
            this.txtCorreoContacto.PasswordChar = '\0';
            this.txtCorreoContacto.PlaceholderText = "Correo de contacto del anunciante";
            this.txtCorreoContacto.SelectedText = "";
            this.txtCorreoContacto.Size = new System.Drawing.Size(564, 85);
            this.txtCorreoContacto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCorreoContacto.TabIndex = 7;
            // 
            // txtLink
            // 
            this.txtLink.Animated = true;
            this.txtLink.AutoRoundedCorners = true;
            this.txtLink.BorderRadius = 41;
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
            this.txtLink.Location = new System.Drawing.Point(870, 273);
            this.txtLink.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtLink.Name = "txtLink";
            this.txtLink.PasswordChar = '\0';
            this.txtLink.PlaceholderText = "Link en el anuncio";
            this.txtLink.SelectedText = "";
            this.txtLink.Size = new System.Drawing.Size(564, 85);
            this.txtLink.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtLink.TabIndex = 8;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(1468, 290);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(95, 55);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Activo";
            // 
            // toggleEstado
            // 
            this.toggleEstado.Animated = true;
            this.toggleEstado.Checked = true;
            this.toggleEstado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.toggleEstado.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.toggleEstado.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleEstado.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleEstado.Location = new System.Drawing.Point(1582, 298);
            this.toggleEstado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toggleEstado.Name = "toggleEstado";
            this.toggleEstado.Size = new System.Drawing.Size(78, 38);
            this.toggleEstado.TabIndex = 10;
            this.toggleEstado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleEstado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleEstado.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleEstado.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleEstado.CheckedChanged += new System.EventHandler(this.toggleEstado_CheckedChanged);
            // 
            // lblPreview
            // 
            this.lblPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblPreview.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.lblPreview.ForeColor = System.Drawing.Color.White;
            this.lblPreview.Location = new System.Drawing.Point(870, 383);
            this.lblPreview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(146, 44);
            this.lblPreview.TabIndex = 12;
            this.lblPreview.Text = "Vista previa";
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.Color.Transparent;
            this.btnPublicar.BorderColor = System.Drawing.Color.Empty;
            this.btnPublicar.BorderThickness = 3;
            this.btnPublicar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPublicar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPublicar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPublicar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPublicar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnPublicar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnPublicar.Location = new System.Drawing.Point(1582, 967);
            this.btnPublicar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(494, 87);
            this.btnPublicar.TabIndex = 14;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseTransparentBackground = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
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
            this.btnCargarImg.Location = new System.Drawing.Point(870, 919);
            this.btnCargarImg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(400, 87);
            this.btnCargarImg.TabIndex = 13;
            this.btnCargarImg.Text = "Cargar Imagen";
            this.btnCargarImg.Click += new System.EventHandler(this.btnCargarImg_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Animated = true;
            this.btnRefrescar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefrescar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefrescar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefrescar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefrescar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Image = global::App.Properties.Resources.actualizar1;
            this.btnRefrescar.Location = new System.Drawing.Point(714, 60);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRefrescar.Size = new System.Drawing.Size(80, 77);
            this.btnRefrescar.TabIndex = 15;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // picBannerPreview
            // 
            this.picBannerPreview.BackColor = System.Drawing.Color.Transparent;
            this.picBannerPreview.FillColor = System.Drawing.Color.DimGray;
            this.picBannerPreview.ImageRotate = 0F;
            this.picBannerPreview.Location = new System.Drawing.Point(870, 437);
            this.picBannerPreview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picBannerPreview.Name = "picBannerPreview";
            this.picBannerPreview.Size = new System.Drawing.Size(400, 475);
            this.picBannerPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBannerPreview.TabIndex = 11;
            this.picBannerPreview.TabStop = false;
            this.picBannerPreview.UseTransparentBackground = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Animated = true;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::App.Properties.Resources.busqueda;
            this.btnBuscar.Location = new System.Drawing.Point(622, 60);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBuscar.Size = new System.Drawing.Size(80, 77);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FillColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnActualizar.Location = new System.Drawing.Point(1582, 848);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(494, 87);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseTransparentBackground = true;
            this.btnActualizar.Visible = false;
            // 
            // GestorAnuncios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.scbAnuncios);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnCargarImg);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.picBannerPreview);
            this.Controls.Add(this.toggleEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtCorreoContacto);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.flpAnuncios);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GestorAnuncios";
            this.Size = new System.Drawing.Size(2122, 1098);
            this.Load += new System.EventHandler(this.GestorAnuncios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBannerPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAnuncios;
        private Guna.UI2.WinForms.Guna2CircleButton btnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2VScrollBar scbAnuncios;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMarca;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreoContacto;
        private Guna.UI2.WinForms.Guna2TextBox txtLink;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstado;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleEstado;
        private Guna.UI2.WinForms.Guna2PictureBox picBannerPreview;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPreview;
        private Guna.UI2.WinForms.Guna2Button btnPublicar;
        private Guna.UI2.WinForms.Guna2Button btnCargarImg;
        private Guna.UI2.WinForms.Guna2CircleButton btnRefrescar;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
    }
}
