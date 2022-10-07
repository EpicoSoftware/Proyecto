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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminApp));
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAbrirApp = new Guna.UI2.WinForms.Guna2Button();
            this.btnMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ResizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.pnlContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnAnuncios = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnEncuentros = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.TargetControl = this;
            // 
            // btnAbrirApp
            // 
            this.btnAbrirApp.Animated = true;
            this.btnAbrirApp.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirApp.BorderColor = System.Drawing.Color.Empty;
            this.btnAbrirApp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAbrirApp.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnAbrirApp.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnAbrirApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbrirApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbrirApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbrirApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbrirApp.FillColor = System.Drawing.Color.Transparent;
            this.btnAbrirApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirApp.ForeColor = System.Drawing.Color.White;
            this.btnAbrirApp.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnAbrirApp.IndicateFocus = true;
            this.btnAbrirApp.Location = new System.Drawing.Point(762, 14);
            this.btnAbrirApp.Name = "btnAbrirApp";
            this.btnAbrirApp.Size = new System.Drawing.Size(153, 38);
            this.btnAbrirApp.TabIndex = 16;
            this.btnAbrirApp.Text = "Abrir App de Usuario";
            this.btnAbrirApp.UseTransparentBackground = true;
            this.btnAbrirApp.Click += new System.EventHandler(this.btnAbrirApp_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMin.FillColor = System.Drawing.Color.Transparent;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(933, 15);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 19);
            this.btnMin.TabIndex = 11;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMax.FillColor = System.Drawing.Color.Transparent;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(969, 15);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(31, 19);
            this.btnMax.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1007, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 19);
            this.btnCerrar.TabIndex = 9;
            // 
            // ResizeForm
            // 
            this.ResizeForm.TargetForm = this;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoSize = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlContenedor.Location = new System.Drawing.Point(0, 58);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1061, 571);
            this.pnlContenedor.TabIndex = 2;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // dragControl
            // 
            this.dragControl.DockIndicatorTransparencyValue = 0.6D;
            this.dragControl.TargetControl = this.pnlMenu;
            this.dragControl.UseTransparentDrag = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnEncuentros);
            this.pnlMenu.Controls.Add(this.btnAnuncios);
            this.pnlMenu.Controls.Add(this.btnAbrirApp);
            this.pnlMenu.Controls.Add(this.guna2PictureBox1);
            this.pnlMenu.Controls.Add(this.btnMin);
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.btnMax);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.pnlMenu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1061, 64);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnAnuncios
            // 
            this.btnAnuncios.Animated = true;
            this.btnAnuncios.BackColor = System.Drawing.Color.Transparent;
            this.btnAnuncios.BorderColor = System.Drawing.Color.Empty;
            this.btnAnuncios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAnuncios.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnAnuncios.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnAnuncios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnuncios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnuncios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnuncios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnuncios.FillColor = System.Drawing.Color.Transparent;
            this.btnAnuncios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAnuncios.ForeColor = System.Drawing.Color.White;
            this.btnAnuncios.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnAnuncios.IndicateFocus = true;
            this.btnAnuncios.Location = new System.Drawing.Point(228, 0);
            this.btnAnuncios.Name = "btnAnuncios";
            this.btnAnuncios.Size = new System.Drawing.Size(120, 64);
            this.btnAnuncios.TabIndex = 18;
            this.btnAnuncios.Text = "Anuncios";
            this.btnAnuncios.UseTransparentBackground = true;
            this.btnAnuncios.Click += new System.EventHandler(this.btnAnuncios_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::App.Properties.Resources.logo1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 17);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(42, 32);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btnEncuentros
            // 
            this.btnEncuentros.Animated = true;
            this.btnEncuentros.BackColor = System.Drawing.Color.Transparent;
            this.btnEncuentros.BorderColor = System.Drawing.Color.Empty;
            this.btnEncuentros.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEncuentros.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnEncuentros.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnEncuentros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncuentros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncuentros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncuentros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncuentros.FillColor = System.Drawing.Color.Transparent;
            this.btnEncuentros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnEncuentros.ForeColor = System.Drawing.Color.White;
            this.btnEncuentros.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnEncuentros.IndicateFocus = true;
            this.btnEncuentros.Location = new System.Drawing.Point(73, 0);
            this.btnEncuentros.Name = "btnEncuentros";
            this.btnEncuentros.Size = new System.Drawing.Size(149, 64);
            this.btnEncuentros.TabIndex = 19;
            this.btnEncuentros.Text = "Encuentros";
            this.btnEncuentros.UseTransparentBackground = true;
            this.btnEncuentros.Click += new System.EventHandler(this.btnEncuentros_Click);
            // 
            // AdminApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 629);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAppcs";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2ControlBox btnMin;
        private Guna.UI2.WinForms.Guna2ControlBox btnMax;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrar;
        private Guna.UI2.WinForms.Guna2ResizeForm ResizeForm;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedor;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2Button btnAbrirApp;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlMenu;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAnuncios;
        private Guna.UI2.WinForms.Guna2Button btnEncuentros;
    }
}