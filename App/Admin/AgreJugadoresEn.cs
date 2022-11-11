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
    public partial class AgreJugadoresEn : Form
    {
        APIresultados apiResultados = new APIresultados();
        private Jugadores _jugador;
        Jugadores jugadorSeleccionado;
        private Equipo _equipo;
        private Encuentro _encuentro;
        private cePanelCreacion _panel;
        List<Jugadores> jugadoresEquipoEncuentro;

        public cePanelCreacion Panel
        {
            get { return _panel; }
            set { _panel = value; }
        }

        public Jugadores Jugador
        {
            get { return _jugador; }
            set { _jugador = value; }
        }

        public Encuentro Encuentro
        {
            get { return _encuentro; }
            set { _encuentro = value; }
        }

        public Equipo Equipo
        {
            get { return _equipo; }
            set { _equipo = value; }
        }

        public AgreJugadoresEn()
        {
            InitializeComponent();
        }

        private void ListaJugadoresEquipo()
        {
            List<Jugadores> listaJugadores;
            listaJugadores = apiResultados.ListaJugadoresEquipo(_equipo.IdEquipo);
            cboJugadores.DataSource = listaJugadores;
            cboJugadores.DisplayMember = "Nombre";
        }

        private void AgreJugadoresEn_Load(object sender, EventArgs e)
        {
            ListaJugadoresEquipo();
        }

        private void cboJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            jugadorSeleccionado = cboJugadores.SelectedItem as Jugadores;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Jugadores jugadorAgregado = cboJugadores.SelectedItem as Jugadores;
            if (jugadorAgregado != null)
            {
                jugadoresEquipoEncuentro.Add(jugadorAgregado);
                listBox.Items.Add(jugadorAgregado.Nombre + " " + jugadorAgregado.Apellido);
            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Debes seleccionar un jugador para agregar");
                        break;
                    case 2:
                        MessageBox.Show("You must select a player to add");
                        break;
                }
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; listBox.Items.Count >= i; i++)
            {
                Jugadores jugadorI = listBox.Items[i] as Jugadores;
                apiResultados.AgregarJugadorEquipoEncuentro(jugadorI.IdJugador, _encuentro.IdEncuentro, _equipo.IdEquipo);
            }*/
            _panel.ListaJugadoresEquipoEncuentro = obtenerListaJugadoresEquipo();
            this.Close();
        }
     
        public List<Jugadores> obtenerListaJugadoresEquipo()
        {
            List<Jugadores> listaJugadores = new List<Jugadores>();
            for (int i = 0; listBox.Items.Count >= i; i++)
            {
                Jugadores jugadorI = listBox.Items[i] as Jugadores;
                listaJugadores.Add(jugadorI);
            }
            return listaJugadores;
        }
    }
}
