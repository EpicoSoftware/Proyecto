using System;
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
                MessageBox.Show(respuesta);
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
}
}

