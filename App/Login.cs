﻿using System;
using CapaLogica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using CapaDatos;
using System.Threading;

namespace App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void Alerta(Color color, string titulo, string descripcion)
        {
            Alerta alerta = new Alerta();
            alerta.ColorAlerta = color;
            alerta.TituloAlerta = titulo;
            alerta.DescripcionAlerta = descripcion;
            alerta.ShowDialog();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo, password, respuesta;
            correo = txtCorreo.Text;
            password = txtPassword.Text;


            APIautenticacion auth = new APIautenticacion();
            respuesta = auth.Login(correo, password);
            if (string.IsNullOrEmpty(respuesta))
            {
                
                App_Gratis appGratis = new App_Gratis();
                appGratis.Visible = true;
                this.Visible = false;
            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        Alerta(Color.DarkRed, "Error al ingresar", respuesta);
                        break;
                    case 2:
                        Alerta(Color.DarkRed, "Login Error", respuesta);
                        break;
                }
               
                //MessageBox.Show(respuesta);
            }
        }


    private void btnRegistrarse_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        Registro registro = new Registro();
        registro.Visible = true;
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            Sesion.idIdioma = 2;
            this.Controls.Clear();
            InitializeComponent();
        }

        private void btnEspañol_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
            Sesion.idIdioma = 1;
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}

