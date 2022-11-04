using CapaDatos;
using CapaLogica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Registro : Form
    {
        void Alerta(Color color, string titulo, string descripcion)
        {
            Alerta alerta = new Alerta();
            alerta.ColorAlerta = color;
            alerta.TituloAlerta = titulo;
            alerta.DescripcionAlerta = descripcion;
            alerta.ShowDialog();
        }

        APIautenticacion auth = new APIautenticacion();


        public Registro()
        {
            InitializeComponent();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            if (txtPassword.Text != txtConfirmarPassword.Text) //Confirmar contrsenas
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        Alerta(Color.DarkRed, "Error", "Las contraseñas no coindicen");
                        break;
                    case 2:
                        Alerta(Color.DarkRed, "Error", "passwords dosen't much");
                        break;
                }
            }
            else
            {
                EncriptarMD5 md5 = new EncriptarMD5();
                string passwordEncriptada = md5.Encriptar(txtPassword.Text);
                Usuario user = new Usuario();
                user.Email = txtCorreo.Text;
                user.NomUsuario = txtNombre.Text;
                user.IdTipoUsuario = 1;

                respuesta = auth.Registro(user, passwordEncriptada);

                if (string.IsNullOrEmpty(respuesta)) //Si respuesta tiene algun valor significa que dio un error
                {
                    auth.Login(user.Email, passwordEncriptada);
                    this.Visible = false;
                    App app = new App();
                    app.Visible = true;
                }
                else
                {
                    Alerta(Color.DarkRed, "Error", respuesta);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

    }
}
