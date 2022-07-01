using CapaDatos;
using CapaLogica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

                var usuarioJson = JsonConvert.SerializeObject(user);
                respuesta = auth.Registro(usuarioJson);
                if (string.IsNullOrEmpty(respuesta))
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
            Modelos.obtenerListaPaises(cboPaises);
            Modelos.obtenerListaIdiomas(cboIdioma);
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

        private void cboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            int text = cboPaises.SelectedIndex;
            Console.WriteLine(text);
        }
    }
}
