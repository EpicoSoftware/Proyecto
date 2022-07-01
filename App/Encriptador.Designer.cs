namespace App
{
    partial class Encriptador
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEntrada = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtResultado = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEncriptar = new Guna.UI2.WinForms.Guna2Button();
            this.btnDesencriptar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 14);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(49, 15);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Password";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 98);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(51, 15);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Resultado";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEntrada.DefaultText = "";
            this.txtEntrada.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEntrada.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEntrada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEntrada.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEntrada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEntrada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEntrada.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEntrada.Location = new System.Drawing.Point(12, 36);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.PasswordChar = '\0';
            this.txtEntrada.PlaceholderText = "";
            this.txtEntrada.SelectedText = "";
            this.txtEntrada.Size = new System.Drawing.Size(200, 36);
            this.txtEntrada.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResultado.DefaultText = "";
            this.txtResultado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtResultado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtResultado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResultado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResultado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResultado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResultado.Location = new System.Drawing.Point(12, 120);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.PasswordChar = '\0';
            this.txtResultado.PlaceholderText = "";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.SelectedText = "";
            this.txtResultado.Size = new System.Drawing.Size(200, 36);
            this.txtResultado.TabIndex = 3;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncriptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncriptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncriptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncriptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEncriptar.ForeColor = System.Drawing.Color.White;
            this.btnEncriptar.Location = new System.Drawing.Point(12, 190);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(200, 45);
            this.btnEncriptar.TabIndex = 4;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesencriptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesencriptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDesencriptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDesencriptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDesencriptar.ForeColor = System.Drawing.Color.White;
            this.btnDesencriptar.Location = new System.Drawing.Point(12, 255);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(200, 45);
            this.btnDesencriptar.TabIndex = 5;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // Encriptador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 316);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "Encriptador";
            this.Text = "Encriptador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtEntrada;
        private Guna.UI2.WinForms.Guna2TextBox txtResultado;
        private Guna.UI2.WinForms.Guna2Button btnEncriptar;
        private Guna.UI2.WinForms.Guna2Button btnDesencriptar;
    }
}