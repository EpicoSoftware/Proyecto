using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace App.UserControlAdmin
{
    public partial class AnuncioElemento : UserControl
    {
        public AnuncioElemento()
        {
            InitializeComponent();
        }

        public AnuncioElemento(string marca, string correo, string fecha, byte[] preview, int idAnuncio = 0, bool estado = true)
        {
            _marca = marca;
            _correo = correo;
            _fecha = fecha;
            _preview = preview;
            this.idAnuncio = idAnuncio;
            this.estado = estado;
        }

        private void AnuncioElemento_Load(object sender, EventArgs e)
        {
            if (Estado)
            {
                this.BackColor = Color.FromArgb(10, 101, 255);
            }
            else this.BackColor = Color.FromArgb(144, 144, 144);

        }

        #region Propiedades

        private string _marca;
        private string _correo;
        private string _fecha;
        private byte[] _preview;
        private int idAnuncio;
        private bool estado;

        [Category("Custom Props")]
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; lblMarca.Text = value; }
        }

        [Category("Custom Props")]
        public string Correo
        {
            get { return _correo; }
            set { _correo = value; lblCorreo.Text = value; }
        }

        [Category("Custom Props")]
        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; lblFechaCreacion.Text = value; }
        }

        [Category("Custom Props")]
        public byte[] Preview
        {
            get { return _preview; }
            set { _preview = value; picAnuncio.Image = Imagenes.ByteToImagen(_preview); }
        }

        [Category("Custom Props")]
        public int IdAnuncio { get => idAnuncio; set => idAnuncio = value; }

        [Category("Custom Props")]
        public bool Estado { get => estado; set => estado = value; }

        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Deseas confirmar esta accion?", "Eliminar Anuncio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string respuesta = Modelos.EliminarAnuncio(IdAnuncio);
                if (string.IsNullOrEmpty(respuesta))
                {

                }
                else MessageBox.Show(respuesta, "error");
               
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }
    }
}
