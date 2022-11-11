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
            if ((string.IsNullOrEmpty(txtNombre.Text)) || string.IsNullOrEmpty(txtApellido.Text) || cboPais.SelectedItem == null)
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Debe completar los criterios de busqueda");
                        break;
                    case 2:
                        MessageBox.Show("You must fill all searching criteria");
                        break;
                }
            }
            else
            {
                Jugadores jugadorBusqueda = apiResultados.BuscarJugador(txtNombre.Text, txtApellido.Text, Program.ObtenerIdPais(cboPais.SelectedItem.ToString()));
                if (jugadorBusqueda == null)
                {
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            MessageBox.Show("No se encontro un jugador para los datos ingresados");
                            break;
                        case 2:
                            MessageBox.Show("We couden't find a player for the entered data");
                            break;
                    }
                }
                else
                {
                    txtNombreJugador.Text = jugadorBusqueda.Nombre;
                    txtApellidoJugador.Text = jugadorBusqueda.Apellido;
                    cboNacionalidadJugador.SelectedIndex = jugadorBusqueda.IdPais - 1;
                }
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
                cboPais.Items.Add(pais);
            }
        }
        private void CargarCboDeportes()
        {
            List<Deporte> listaDeporte;
            listaDeporte = apiResultados.CargarDeportes();
            foreach(Deporte dep in listaDeporte)
            {
                cboPais.Items.Add(dep.NomDeporte);
                cboDeporteJugador.Items.Add(dep.NomDeporte);
            }
        }
        private void CargarCboEquipos() {
            if(cboDeporteJugador.SelectedItem != null && cboPaisEquipo.SelectedItem != null)
            {
                List<Equipo> listaEquipo;
                int idDeporte = apiResultados.ObtenerIdDeporte(cboDeporteJugador.SelectedItem.ToString());
                listaEquipo = apiResultados.CargarEquiposFiltro(idDeporte, Program.ObtenerIdPais(cboPaisEquipo.SelectedItem.ToString()));
                foreach (Equipo equipo in listaEquipo)
                {
                    cboEquipo.Items.Add(equipo.NomEquipo);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Jugadores jugador = new Jugadores();
            jugador.Nombre = txtNombreJugador.Text;
            jugador.Apellido = txtApellidoJugador.Text;
            jugador.IdPais = Program.ObtenerIdPais(cboNacionalidadJugador.SelectedItem.ToString());
            jugador.IdDeporte = apiResultados.ObtenerIdDeporte(cboDeporteJugador.SelectedItem.ToString());
            jugador.FechaNac = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");
            jugador.Selaccion = chboxSeleccion.Checked;

            Equipo equipo = new Equipo();
            equipo = apiResultados.CargarEquipoFiltro(cboEquipo.SelectedItem.ToString(), Program.ObtenerIdPais(cboPaisEquipo.SelectedItem.ToString()));

            apiResultados.ActualizarJugador(jugador);

            switch (Sesion.idIdioma)
            {
                case 2:
                    MessageBox.Show("Player updated succesfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Controls.Clear();
                    InitializeComponent();
                    CargarCboPaises();
                    CargarCboDeportes();
                    CargarCboEquipos();
                    break;
                case 1:
                    MessageBox.Show("Jugador actualizado", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Controls.Clear();
                    InitializeComponent();
                    CargarCboPaises();
                    CargarCboDeportes();
                    CargarCboEquipos();
                    break;
            }
        }

        private void ceJugador_Load(object sender, EventArgs e)
        {
            CargarCboPaises();
            CargarCboDeportes();
            CargarCboEquipos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Jugadores jugador = new Jugadores();
            jugador.Nombre = txtNombreJugador.Text;
            jugador.Apellido = txtApellidoJugador.Text;
            jugador.IdPais = Program.ObtenerIdPais(cboNacionalidadJugador.SelectedItem.ToString());
            jugador.IdDeporte = apiResultados.ObtenerIdDeporte(cboDeporteJugador.SelectedItem.ToString());
            jugador.FechaNac = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");
            jugador.Selaccion = chboxSeleccion.Checked;

            Equipo equipo = new Equipo();
            equipo = apiResultados.CargarEquipoFiltro(cboEquipo.SelectedItem.ToString(), Program.ObtenerIdPais(cboPaisEquipo.SelectedItem.ToString()));

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
                        string respuesta = apiResultados.RegistrarJugador(jugador, equipo);
                        if (string.IsNullOrEmpty(respuesta))
                        {
                            MessageBox.Show("Jugador correctamete creado", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Controls.Clear();
                            InitializeComponent();
                            CargarCboPaises();
                            CargarCboDeportes();
                            CargarCboEquipos();
                        }
                        else MessageBox.Show("Jugador no pudo ser creado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    break;
                case 2:
                    res = MessageBox.Show(mensajeIng, "Confirm Player:", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.No)
                    {

                    }
                    else
                    {
                        string respuesta = apiResultados.RegistrarJugador(jugador, equipo);
                        if (string.IsNullOrEmpty(respuesta))
                        {
                            MessageBox.Show("Player created succesfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Controls.Clear();
                            InitializeComponent();
                            CargarCboPaises();
                            CargarCboDeportes();
                            CargarCboEquipos();
                        }
                        else MessageBox.Show("Player couden't be created", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


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

        private void cboDeporteJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCboEquipos();
        }

        private void cboPaisEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCboEquipos();
        }
    }
}
