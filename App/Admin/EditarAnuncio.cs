using CapaDatos;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Admin
{
    public partial class EditarAnuncio : Form
    {
        public EditarAnuncio()
        {
            InitializeComponent();
        }

        public EditarAnuncio(string marca, string correo, string preview, string link, int idAnuncio, bool estado)
        {
            _marca = marca;
            _correo = correo;
            _preview = preview;
            _idAnuncio = idAnuncio;
            _estado = estado;
            _link = link;
        }

        #region Propiedades

        private string _marca;
        private string _correo;
        private string _preview;
        private int _idAnuncio;
        private string _link;
        private bool _estado;

        [Category("Custom Props")]
        public string Marca {
            get { return _marca; }
            set { _marca = value; txtMarca.Text = value; }
        }
        [Category("Custom Props")]
        public string Correo {
            get { return _correo; }
            set { _correo = value; txtCorreoContacto.Text = value; }
        }
        [Category("Custom Props")]
        public string Link
        {
            get { return _link; }
            set { _link = value; txtLink.Text = value; }
        }
        [Category("Custom Props")]
        public string Preview {
            get { return _preview; }
            set { _preview = value; picBannerPreview.Image = Imagenes.ObtenerImagen(_preview); }
        }
        [Category("Custom Props")]
        public int IdAnuncio {
            get { return _idAnuncio; }
            set { _idAnuncio = value; }
        }
        [Category("Custom Props")]
        public bool Estado
        {
            get { return _estado; }
            set { _estado = value; toggleEstado.Checked = _estado; }
        }

        #endregion

        private void EditarAnuncio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Anuncio anuncio = new Anuncio();
            anuncio.CorreoContacto = _correo;
            anuncio.Estado = _estado;
            anuncio.Imagen = _preview;
            anuncio.Link = _link;
            anuncio.NombreMarca = _marca;
            anuncio.IdAnuncio = _idAnuncio;
            APIpublicidad apiPubli = new APIpublicidad();
            apiPubli.ActualizarAnuncio(anuncio);
        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            string rutaImagen = Imagenes.GuardarImagen();
            picBannerPreview.Image = Imagenes.ObtenerImagen(rutaImagen);
        }
    }
}
