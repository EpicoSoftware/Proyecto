namespace App
{
    partial class Registro
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnSiguiente = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnSubirImagen = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdioma = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPais = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboIdioma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboPaises = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picImagenPerfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmarPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenPerfil)).BeginInit();
            this.SuspendLayout();
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
            // btnSiguiente
            // 
            this.btnSiguiente.AutoRoundedCorners = true;
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BorderRadius = 19;
            this.btnSiguiente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSiguiente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSiguiente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSiguiente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSiguiente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(12, 537);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(537, 40);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(517, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 19);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.AutoRoundedCorners = true;
            this.btnSubirImagen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSubirImagen.BorderRadius = 10;
            this.btnSubirImagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubirImagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubirImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubirImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubirImagen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSubirImagen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubirImagen.ForeColor = System.Drawing.Color.White;
            this.btnSubirImagen.Location = new System.Drawing.Point(225, 171);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(111, 23);
            this.btnSubirImagen.TabIndex = 25;
            this.btnSubirImagen.Text = "Subir Imagen";
            this.btnSubirImagen.Click += new System.EventHandler(this.btnSubirImagen_Click);
            // 
            // txtIdioma
            // 
            this.txtIdioma.BackColor = System.Drawing.Color.Transparent;
            this.txtIdioma.Location = new System.Drawing.Point(318, 328);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(34, 15);
            this.txtIdioma.TabIndex = 24;
            this.txtIdioma.Text = "Idioma";
            // 
            // lblPais
            // 
            this.lblPais.BackColor = System.Drawing.Color.Transparent;
            this.lblPais.Location = new System.Drawing.Point(318, 256);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(23, 15);
            this.lblPais.TabIndex = 23;
            this.lblPais.Text = "Pais";
            // 
            // cboIdioma
            // 
            this.cboIdioma.BackColor = System.Drawing.Color.Transparent;
            this.cboIdioma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdioma.DropDownHeight = 80;
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIdioma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIdioma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboIdioma.IntegralHeight = false;
            this.cboIdioma.ItemHeight = 30;
            this.cboIdioma.Location = new System.Drawing.Point(318, 339);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(207, 36);
            this.cboIdioma.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cboIdioma.TabIndex = 21;
            // 
            // cboPaises
            // 
            this.cboPaises.BackColor = System.Drawing.Color.Transparent;
            this.cboPaises.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPaises.DropDownHeight = 100;
            this.cboPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaises.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPaises.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPaises.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPaises.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPaises.IntegralHeight = false;
            this.cboPaises.ItemHeight = 30;
            this.cboPaises.Location = new System.Drawing.Point(318, 266);
            this.cboPaises.Name = "cboPaises";
            this.cboPaises.Size = new System.Drawing.Size(207, 36);
            this.cboPaises.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cboPaises.TabIndex = 20;
            this.cboPaises.SelectedIndexChanged += new System.EventHandler(this.cboPaises_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(15, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 26);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Registrarse";
            // 
            // picImagenPerfil
            // 
            this.picImagenPerfil.Image = global::App.Properties.Resources.avatar;
            this.picImagenPerfil.ImageRotate = 0F;
            this.picImagenPerfil.Location = new System.Drawing.Point(216, 42);
            this.picImagenPerfil.Name = "picImagenPerfil";
            this.picImagenPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picImagenPerfil.Size = new System.Drawing.Size(129, 129);
            this.picImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenPerfil.TabIndex = 22;
            this.picImagenPerfil.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.IconLeft = global::App.Properties.Resources.usuario;
            this.txtNombre.Location = new System.Drawing.Point(32, 266);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(237, 36);
            this.txtNombre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNombre.TabIndex = 18;
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmarPassword.DefaultText = "";
            this.txtConfirmarPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmarPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmarPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmarPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmarPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmarPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmarPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmarPassword.IconLeft = global::App.Properties.Resources.cerrar_con_llave;
            this.txtConfirmarPassword.Location = new System.Drawing.Point(32, 444);
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.PasswordChar = '•';
            this.txtConfirmarPassword.PlaceholderText = "Contraseña";
            this.txtConfirmarPassword.SelectedText = "";
            this.txtConfirmarPassword.Size = new System.Drawing.Size(237, 36);
            this.txtConfirmarPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtConfirmarPassword.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.IconLeft = global::App.Properties.Resources.cerrar_con_llave;
            this.txtPassword.Location = new System.Drawing.Point(32, 392);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.PlaceholderText = "Contraseña";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(237, 36);
            this.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPassword.TabIndex = 16;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "";
            this.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.IconLeft = global::App.Properties.Resources.sobre;
            this.txtCorreo.Location = new System.Drawing.Point(32, 339);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderText = "Correo";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.Size = new System.Drawing.Size(237, 36);
            this.txtCorreo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCorreo.TabIndex = 15;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 589);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSubirImagen);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.picImagenPerfil);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.cboPaises);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtConfirmarPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnSiguiente;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrar;
        private Guna.UI2.WinForms.Guna2Button btnSubirImagen;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtIdioma;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPais;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picImagenPerfil;
        private Guna.UI2.WinForms.Guna2ComboBox cboIdioma;
        private Guna.UI2.WinForms.Guna2ComboBox cboPaises;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmarPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
    }
}