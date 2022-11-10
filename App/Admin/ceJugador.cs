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
using CapaLogica;

namespace App.Admin
{
    public partial class ceJugador : UserControl
    {
        private static APIresultados apiResultados = new APIresultados();
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
                    //Jugadores jugadorBusqueda = apiResultados.obtenerJugador("", txtNombre,)
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
        private void CargarCboDeportes()
        {
            List<Deporte> listaDeporte;
            listaDeporte = apiResultados.CargarDeportes();
            foreach(Deporte dep in listaDeporte)
            {
                cboDeporte.Items.Add(dep.NomDeporte);
                cboDeporteJugador.Items.Add(dep.NomDeporte);
            }
        }
        private void CargarCboEquipos() {
            if(cboDeporteJugador.SelectedItem != null || cboPaisEquipo != null)
            {
                List<Equipo> listaEquipo;
                int idDeporte = apiResultados.ObtenerIdDeporte(cboDeporteJugador.SelectedItem.ToString());
                listaEquipo = apiResultados.CargarEquiposFiltro(idDeporte, cboPaisEquipo.SelectedIndex -1);
                foreach (Equipo equipo in listaEquipo)
                {
                    cboEquipo.Items.Add(equipo.NomEquipo);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void ceJugador_Load(object sender, EventArgs e)
        {
            CargarCboPaises();
            CargarCboDeportes();
            CargarCboEquipos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            DialogResult res;
            string mensajeEsp = 
                        "Nombre: " + txtNombreJugador.Text + " " + txtApellidoJugador.Text +
                        "\nNacionalidad: " + cboNacionalidadJugador.SelectedItem.ToString() +
                        "\nJuega al: " + cboDeporteJugador.SelectedItem.ToString() +
                        "\nEn: " + cboEquipo.SelectedItem.ToString() + " de " + cboPaisEquipo.SelectedItem.ToString() +
                        "\nNacio el: " + dtpFechaNacimiento.Value.ToShortDateString() +
                        "\nSeleccion?: " + chboxSeleccion.Checked;

            string mensajeIng = 
                        "Name: " + txtNombreJugador.Text + " " + txtApellidoJugador.Text +
                        "\nNacionality: " + cboNacionalidadJugador.SelectedItem.ToString() +
                        "\nPlays: " + cboDeporteJugador.SelectedItem.ToString() +
                        "\nat: " + cboEquipo.SelectedItem.ToString() + " de " + cboPaisEquipo.SelectedItem.ToString() +
                        "\nBirth day: " + dtpFechaNacimiento.Value.ToShortDateString() +
                        "\nPlay at national team?: " + chboxSeleccion.Checked;

            switch (Sesion.idIdioma)
            {
                case 1:
                    res = MessageBox.Show(mensajeEsp, "Confirmar Jugador:", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    
                    if (res == DialogResult.No)
                    {

                    }
                    else
                    {
                        //apiAuth.EliminarUsuario(usuarioSeleccionado.IdUsuario, usuarioSeleccionado.IdTipoUsuario);
                        MessageBox.Show("Jugador correctamete creado", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Controls.Clear();
                        InitializeComponent();
                        CargarCboPaises();
                        CargarCboDeportes();
                        CargarCboEquipos();
                    }
                    break;
                case 2:
                    res = MessageBox.Show(mensajeIng, "Confirm Player:", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.No)
                    {

                    }
                    else
                    {
                        //apiAuth.EliminarUsuario(usuarioSeleccionado.IdUsuario, usuarioSeleccionado.IdTipoUsuario);
                        MessageBox.Show("Player created succesfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Controls.Clear();
                        InitializeComponent();
                        CargarCboPaises();
                        CargarCboDeportes();
                        CargarCboEquipos();
                    }
                    break;
            }
        }

        private void cboEquipo_Click(object sender, EventArgs e)
        {
            
            if (cboDeporteJugador.SelectedItem == null || cboPaisEquipo == null)
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Para buscar un Equipo debes seleccionar deporte y pais del mismo.", "Uh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        MessageBox.Show("For searching a team you must fill the sport and team country fields", "Uh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }

        }
    }
}
