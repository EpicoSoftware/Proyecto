using CapaDatos;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace App
{
    public partial class App_Gratis : Form
    {
        public App_Gratis()
        {
            InitializeComponent();
        }

        private void App_Gratis_Load(object sender, EventArgs e)
        {
            btnCuenta.Text = Sesion.nombre;
            
            switch (Sesion.idColorMode)
            {
                case 1:
                    this.BackColor = Color.FromArgb(28, 28, 28);
                    break;
                case 2:
                    this.BackColor = Color.White;
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            APIpublicidad apiPubli = new APIpublicidad();
            Anuncio anuncio = apiPubli.DisplayAnuncioRandom();
            byte[] img = anuncio.Imagen;
            MemoryStream ms = new MemoryStream(img);
            picBanner.Image = Image.FromStream(ms);

            /*string respuesta = apiPubli.AgregarVista(anuncio.IdAnuncio, Sesion.idUsuario);

            if (string.IsNullOrEmpty(respuesta)) //Si respuesta tiene algun valor significa que dio un error
            {
                
            }
            else
            {
                MessageBox.Show(respuesta);
            }*/

        }

        private void btnBanner_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }


        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Ajustes frm = new Ajustes();
            frm.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

