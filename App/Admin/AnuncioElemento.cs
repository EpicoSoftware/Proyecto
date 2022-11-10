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
using App.Admin;

namespace App.UserControlAdmin
{
    public partial class AnuncioElemento : UserControl
    {
        public AnuncioElemento()
        {
            InitializeComponent();
        }

        public AnuncioElemento(string marca, string correo, string preview, int idAnuncio = 0, bool estado = true)
        {
            _marca = marca;
            _correo = correo;
            _preview = preview;
            _idAnuncio = idAnuncio;
            _estado = estado;
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
        private string _preview;
        private int _idAnuncio;
        private bool _estado;

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
        public string Preview
        {
            get { return _preview; }
            set { _preview = value; picAnuncio.Image = Imagenes.ObtenerImagen(_preview); }
        }

        [Category("Custom Props")]
        public int IdAnuncio { get => _idAnuncio; set => _idAnuncio = value; }

        [Category("Custom Props")]
        public bool Estado { get => _estado; set => _estado = value; }

        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Deseas confirmar esta accion?", "Eliminar Anuncio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string respuesta = Modelos.EliminarAnuncio(IdAnuncio);
                if (string.IsNullOrEmpty(respuesta))
                {
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            MessageBox.Show("Se elimino correctamente, actualiza para ver cambios", "Hecho");
                            break;
                        case 2:
                            MessageBox.Show("It was deleted succesfuly, refresh to see changes", "Done");

                            break;
                    }
              
                }
                else MessageBox.Show(respuesta, "error");

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarAnuncio anuncio = new EditarAnuncio();
            anuncio.Correo = _correo;
            anuncio.Marca = _marca;
            anuncio.Preview = _preview;
            anuncio.Estado = _estado;
            anuncio.IdAnuncio = _idAnuncio;
            anuncio.Visible = true;
        }
    }
}
        
    