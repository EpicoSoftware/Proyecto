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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Registro : Form
    {
        Image imagenPerfil;
        Bitmap imagenBitmap;
        APIautenticacion auth = new APIautenticacion();
        static byte[] fotoPerfil;
        public Registro()
        {
            InitializeComponent();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string respuesta;
            //Obtiene opcion seleccionada del cboIdioma
            string paisSeleccionado = RegionInfo.CurrentRegion.DisplayName;
            //Obtiene opcion seleccionada del cboPaises
            if (txtPassword.Text != txtConfirmarPassword.Text)
            {
                MessageBox.Show("Error", "Las contraseñas no coindicen");
            }
            else
            {
                EncriptarMD5 md5 = new EncriptarMD5();
                string passwordEncriptada = md5.Encriptar(txtPassword.Text);
                Usuario user = new Usuario();

                user.Correo = txtCorreo.Text;
                user.Nombre = txtNombre.Text;
                user.FotoPerfil = fotoPerfil;
                user.IdColorMode = 1; //Color por defecto de la App
                user.IdPais = Modelos.ObtenerId(paisSeleccionado, "paises", "nombre");

                //Serializa JSON para enviarlo al metodo Registro de la clase APIautenticacion
                var usuarioJson = JsonConvert.SerializeObject(user);
                respuesta = auth.Registro(usuarioJson, passwordEncriptada);

                if (string.IsNullOrEmpty(respuesta)) //Si respuesta tiene algun valor significa que dio un error
                {
                    this.Close();
                    App_Gratis appGratis = new App_Gratis();
                    appGratis.Visible = true;
                }
                else
                {
                    MessageBox.Show(respuesta);
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

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            DialogResult re = ofd.ShowDialog();
            if (re == DialogResult.OK)
            {
                imagenPerfil = Image.FromFile(ofd.FileName);
                imagenBitmap = (Bitmap)imagenPerfil;
                picImagenPerfil.Image = imagenBitmap;
                var ms = new MemoryStream();
                imagenPerfil.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                // to get the bytes we type
                fotoPerfil = ms.ToArray();
            }
        }
    }
}
