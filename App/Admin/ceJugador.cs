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

namespace App.Admin
{
    public partial class ceJugador : UserControl
    {
        public ceJugador()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtNombre.Text)) && string.IsNullOrEmpty(txtApellido.Text) && cboDeporte.SelectedItem == null)
            {
                MessageBox.Show("Debe agregar algun criterio de busqueda");
                //Debe agregar algun criterio de busqueda
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                if (cboDeporte.SelectedItem == null)
                {
                    MessageBox.Show("Buscar solo por apellido ");
                    //Buscar solo por apellido 
                }
                else
                {
                    MessageBox.Show("Buscar por apellido en Deporte");
                    //Buscar por apellido en Deporte
                }
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                if (string.IsNullOrEmpty(cboDeporte.SelectedItem.ToString()))
                {
                    MessageBox.Show("Buscar solo por nombre");
                    //Buscar solo por nombre
                }
            }
            if (cboDeporte.SelectedItem == null)
            {

            }
           
        }

        private void CargarCboPaises()
        {
            List<string> listaPaises;
            listaPaises = Program.CargarPaises();
            foreach(string pais in listaPaises)
            {
                cboNacionalidadJugador.Items.Add(pais);
                cboPaisEquipo.Items.Add(pais);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void ceJugador_Load(object sender, EventArgs e)
        {
            CargarCboPaises();
        }
    }
}
