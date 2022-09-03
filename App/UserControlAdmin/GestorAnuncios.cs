using CapaDatos;
using CapaLogica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App
{
    public partial class GestorAnuncios : UserControl
    {
        //Image imagenBanner;
        //Bitmap imagenBitmap;
        //static byte[] fotoBanner;
        public GestorAnuncios()
        {
            InitializeComponent();
        }

        /*private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            Anuncio anuncio = new Anuncio();
            anuncio.Link = txtLink.Text;
            anuncio.NombreMarca = txtNombreMarca.Text;
            anuncio.Imagen = fotoBanner;

            string anuncioJson = JsonConvert.SerializeObject(anuncio);
            APIpublicidad apiPublicidad = new APIpublicidad();
            string respuesta = apiPublicidad.agregarAnuncio(anuncioJson);

            if (string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("Se agrego correctamente");
            }
            else
            {
                MessageBox.Show(respuesta);
            }
        }*/

        /*private void btnSubirAnuncio_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            DialogResult re = ofd.ShowDialog();
            if (re == DialogResult.OK)
            {
                imagenBanner = Image.FromFile(ofd.FileName);
                imagenBitmap = (Bitmap)imagenBanner;
                picBannerPreview.Image = imagenBitmap;
                var ms = new MemoryStream();
                imagenBanner.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                // to get the bytes we type
                fotoBanner = ms.ToArray();
            }
        }*/
    }
}
