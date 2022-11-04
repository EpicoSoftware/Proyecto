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
using App.UserControlAdmin;

namespace App
{
    public partial class GestorAnuncios : UserControl
    {
        static byte[] fotoBanner;
        public GestorAnuncios()
        {
            InitializeComponent();
        }

        void Alerta(Color color, string titulo, string descripcion)
        {
            Alerta alerta = new Alerta();
            alerta.ColorAlerta = color;
            alerta.TituloAlerta = titulo;
            alerta.DescripcionAlerta = descripcion;
            alerta.ShowDialog();
        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            fotoBanner = Imagenes.SubirImagen(picBannerPreview);
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            Anuncio anuncio = new Anuncio();
            anuncio.Link = txtLink.Text;
            anuncio.NombreMarca = txtMarca.Text;
            anuncio.CorreoContacto = txtCorreoContacto.Text;
            anuncio.Imagen = fotoBanner;
            anuncio.Estado = toggleEstado.Checked;

            string anuncioJson = JsonConvert.SerializeObject(anuncio);
            APIpublicidad apiPublicidad = new APIpublicidad();
            string respuesta = apiPublicidad.agregarAnuncio(anuncioJson);

            if (string.IsNullOrEmpty(respuesta))
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        Alerta(Color.Green, "Hecho", "Se agrego correctamente.");
                        break;
                    case 2:
                        Alerta(Color.Green, "Done", "The ad was added successfully.");
                        break;
                }
                this.Controls.Clear();
                InitializeComponent();
                cargarAnuncios();
            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        Alerta(Color.Green, "Error", respuesta);
                        break;
                    case 2:
                        Alerta(Color.Green, "Error", respuesta);
                        break;
                }
            }
        }

        private void toggleEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleEstado.Checked)
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        lblEstado.Text = "Activo";
                        break;
                    case 2:
                        lblEstado.Text = "Active";
                        break;
                }
            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        lblEstado.Text = "Inactivo";
                        break;
                    case 2:
                        lblEstado.Text = "Inactive";
                        break;
                }
            }
            
        }
        private void cargarAnuncios()
        {
            List<Anuncio> listaAnuncios = new List<Anuncio>();
            List<AnuncioElemento> listaElementos = new List<AnuncioElemento>();
            APIpublicidad APIpubli = new APIpublicidad();
            listaAnuncios = APIpubli.CargarListaAnuncios();
            
            foreach(Anuncio ad in listaAnuncios)
            {
                AnuncioElemento anuncio = new AnuncioElemento();
                anuncio.Correo = ad.CorreoContacto;
                anuncio.Marca = ad.NombreMarca;
                anuncio.Preview = ad.Imagen;
                anuncio.Estado = ad.Estado;
                anuncio.IdAnuncio = ad.IdAnuncio;
                //MessageBox.Show(ad.NombreMarca);
                flpAnuncios.Controls.Add(anuncio);
            }
            
        }
        private void GestorAnuncios_Load(object sender, EventArgs e)
        {
            cargarAnuncios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            flpAnuncios.Controls.Clear();
            string nomMarca = txtBuscar.Text;
            APIpublicidad api = new APIpublicidad();
            List<Anuncio> listaBusqueda = api.buscarAnuncio(nomMarca);
            AnuncioElemento anuncio;
            foreach (Anuncio ad in listaBusqueda)
            {
                anuncio = new AnuncioElemento();
                anuncio.Correo = ad.CorreoContacto;
                anuncio.Marca = ad.NombreMarca;
                anuncio.Preview = ad.Imagen;
                anuncio.Estado = ad.Estado;
                anuncio.IdAnuncio = ad.IdAnuncio;

                flpAnuncios.Controls.Add(anuncio);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            cargarAnuncios();
        }
    }
}
