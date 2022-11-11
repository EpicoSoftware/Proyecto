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
    public partial class cePanelCreacion : UserControl
    {
        private int _tipoEncuentro;
        private List<Jugadores> _listaJugadoresEquipoEncuentro;
        Equipo equipoS1;
        Equipo equipoS2;
        APIresultados apiResultados = new APIresultados();

        public cePanelCreacion()
        {
            InitializeComponent();
        }

        public List<Jugadores> ListaJugadoresEquipoEncuentro
        {
            get { return _listaJugadoresEquipoEncuentro; }
            set { _listaJugadoresEquipoEncuentro = value; }
        }

        public int TipoEncuentro
        {
            get { return _tipoEncuentro; }
            set { _tipoEncuentro = value; }
        }

        private void CargarDeportes()
        {
            List<Deporte> listaDeporte;
            listaDeporte = apiResultados.CargarDeportes();
            cboDeporte.DataSource = listaDeporte;
            cboDeporte.DisplayMember = "NomDeporte";
        }

        private void CargarCboPaises()
        {
            List<string> listaPaises;
            listaPaises = Program.CargarPaises();
            foreach (string pais in listaPaises)
            {
                cboPaisEquipo1.Items.Add(pais);
                cboPaisEquipo2.Items.Add(pais);
            }
        }

        private void CargarCboTorneos()
        {
            List<Torneo> listaTorneos;
            listaTorneos = apiResultados.CargarTorneos();
            cboTorneo.DataSource = listaTorneos;
            cboTorneo.DisplayMember = "NomTorneo";
        }

        private void CargarCboEquipos1(ComboBox cbo)
        {
            List<Equipo> listaEquipo1 = null;
            int idDeporte = apiResultados.ObtenerIdDeporte(cboDeporte.SelectedItem.ToString());
            if (idDeporte == 0 && string.IsNullOrEmpty(cboPaisEquipo1.SelectedItem.ToString()))
            {

            }
            else
            {
                listaEquipo1 = apiResultados.CargarEquiposFiltro(idDeporte, Program.ObtenerIdPais(cboPaisEquipo1.SelectedItem.ToString()));

            }
            if (idDeporte != 0)
            {
                if (listaEquipo1 != null)
                {
                    cboEquipo1.DataSource = listaEquipo1;
                    cboEquipo1.DisplayMember = "NomEquipo";
                    /*foreach (Equipo equipo in listaEquipo1)
                    {
                        cbo.Items.Add(equipo.NomEquipo);
                    }*/
                }
                else
                {
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            MessageBox.Show("No se econtraron equipos para los datos ingresados");
                            break;
                        case 2:
                            MessageBox.Show("We couden't find teams for the date entered");
                            break;
                    }
                }
            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Selecciona un deporte");
                        break;
                    case 2:
                        MessageBox.Show("Choose a sport");
                        break;
                }
            }

        }

        private void CargarCboEquipos2(ComboBox cbo)
        {
            List<Equipo> listaEquipo2;
            int idDeporte = apiResultados.ObtenerIdDeporte(cboDeporte.SelectedItem.ToString());
            listaEquipo2 = apiResultados.CargarEquiposFiltro(idDeporte, Program.ObtenerIdPais(cboPaisEquipo2.SelectedItem.ToString()));

            if (idDeporte != 0)
            {
                if(listaEquipo2 != null)
                {
                    cboEquipo2.DataSource = listaEquipo2;
                    cboEquipo2.DisplayMember = "NomEquipo";
                    /*foreach (Equipo equipo in listaEquipo2)
                    {
                        cbo.Items.Add(equipo.NomEquipo);
                    }*/
                }
                else
                {
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            MessageBox.Show("No se econtraron equipos para los datos ingresados");
                            break;
                        case 2:
                            MessageBox.Show("We couden't find teams for the date entered");
                            break;
                    }
                }
            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Selecciona un deporte");
                        break;
                    case 2:
                        MessageBox.Show("Choose a sport");
                        break;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Encuentro encuentro = new Encuentro();
            encuentro.NomEstadio = txtNomEstadio.Text;
            encuentro.NomArbitro = txtNomArbitro.Text;
            encuentro.ApeArbitro = txtApeArbitro.Text;
            encuentro.Fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            Torneo torneo = cboTorneo.SelectedItem as Torneo;
            encuentro.IdTorneo = torneo.IdTorneo;
            Deporte dep = cboDeporte.SelectedItem as Deporte;
            encuentro.IdDeporte = dep.IdDeporte;

            string respuesta = apiResultados.CrearEncuentro(Encuentro encuentro);
            int idEncuentro = apiResultados.ObtenerIdEncuentro(encuentro);

            if (string.IsNullOrEmpty(respuesta))
            {
                for (int i = 0; _listaJugadoresEquipoEncuentro.Count >= i; i++)
                {
                    Jugadores jugadorI = _listaJugadoresEquipoEncuentro[i] as Jugadores;
                    apiResultados.AgregarJugadorEquipoEncuentro(jugadorI.IdJugador, idEncuentro, equipoS1.IdEquipo);
                }
            }

            if (string.IsNullOrEmpty(respuesta))
            {
                for (int i = 0; _listaJugadoresEquipoEncuentro.Count >= i; i++)
                {
                    Jugadores jugadorI = _listaJugadoresEquipoEncuentro[i] as Jugadores;
                    apiResultados.AgregarJugadorEquipoEncuentro(jugadorI.IdJugador, idEncuentro, equipoS2.IdEquipo);
                }
            }

            

        }

        private void cePanelCreacion_Load(object sender, EventArgs e)
        {
            CargarDeportes();
            CargarCboPaises();
            switch (_tipoEncuentro)
            {
                case 1:
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            lblEquipo1.Text = "Equipo 1";
                            lblEquipo2.Text = "Equipo 2";
                            lblPaisEquipo1.Text = "Pais Equipo 1";
                            lblPaisEquipo2.Text = "Pais Equipo 2";
                            break;
                        case 2:
                            lblEquipo1.Text = "Team 1";
                            lblEquipo2.Text = "Team 2";
                            lblPaisEquipo1.Text = "Team 1 Country";
                            lblPaisEquipo2.Text = "Team 2 Country";
                            break;
                    }
                    break;
                case 2:
                    btnAgragarJugadores1.Visible = false;
                    btnAgragarJugadores2.Visible = false;
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            lblEquipo1.Text = "Jugador 1";
                            lblEquipo1.Text = "Jugador 2";
                            lblPaisEquipo1.Text = "Pais Jugador 1";
                            lblPaisEquipo2.Text = "Pais Jugador 2";
                            break;
                        case 2:
                            lblEquipo1.Text = "Player 1";
                            lblEquipo1.Text = "Player 2";
                            lblPaisEquipo1.Text = "Player 1 Country";
                            lblPaisEquipo2.Text = "Player 2 Country";
                            break;
                    }
                    break;

            }
        }

        private void btnAgragarJugadores1_Click(object sender, EventArgs e)
        {
            AgreJugadoresEn agreJuga = new AgreJugadoresEn();
            agreJuga.Panel = this;
            agreJuga.Equipo = equipoS1;
            agreJuga.Visible = true;
        }

        private void btnAgragarJugadores2_Click(object sender, EventArgs e)
        {
            AgreJugadoresEn agreJuga = new AgreJugadoresEn();
            agreJuga.Equipo = equipoS2;
            agreJuga.Panel = this;
            agreJuga.Visible = true;
        }

        private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeporte.SelectedItem != null)
            {
                CargarCboTorneos();
            }
        }

        private void cboPaisEquipo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPaisEquipo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEquipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipoS1 = new Equipo();
            equipoS1 = cboEquipo1.SelectedItem as Equipo;
            //equipoS1 = apiResultados.CargarEquipoFiltro(cboEquipo1.SelectedItem.ToString(), Program.ObtenerIdPais(cboPaisEquipo1.SelectedItem.ToString()));
        }

        private void cboEquipo1_Click(object sender, EventArgs e)
        {
            CargarCboEquipos1(cboEquipo1);

        }

        private void cboEquipo2_Click(object sender, EventArgs e)
        {
            CargarCboEquipos2(cboEquipo2);
        }

        private void cboEquipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipoS2 = new Equipo();
            equipoS2 = cboEquipo2.SelectedItem as Equipo;
            //equipoS2 = apiResultados.CargarEquipoFiltro(cboEquipo2.SelectedItem.ToString(), Program.ObtenerIdPais(cboPaisEquipo2.SelectedItem.ToString()));
        }
    }
}
