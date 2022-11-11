using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaLogica;
using Newtonsoft.Json;

namespace CapaLogica
{
    public class APIresultados
    {
        public List<Encuentro> CargarListaVivo(int estado) //Encuentros en vivo
        {
            //List<Anuncio> listaAnuncios = new List<Anuncio>();
            string listaJson = Modelos.ObtenerListaEncuentrosEstado(estado);
            var listaEncuentro = JsonConvert.DeserializeObject<List<Encuentro>>(listaJson);

            return listaEncuentro;

        }
        public List<Deporte> CargarDeportes()
        {
            string listaJson = Modelos.ObtenerListaDeportes();
            var listaDeporte = JsonConvert.DeserializeObject<List<Deporte>>(listaJson);
            return listaDeporte;
        }

        public int ObtenerIdDeporte(string nombreDeporte)
        {
            int id = Modelos.ObtenerIdDeporte(nombreDeporte);
            return id;
        }

        public void ActualizarDeporte(int id, string nomNuevo)
        {
            Modelos.ActualizarDeporte(id, nomNuevo);
        }
        public string EliminarDeporte(int id)
        {
            string respuesta = Modelos.EliminarDeporte(id);
            if (string.IsNullOrEmpty(respuesta))
            {
                
            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        respuesta = "No se pudo eliminar";
                        break;
                    case 2:
                        respuesta = "It couldn't be deleted";
                        break;
                }
            }
            return respuesta;
        }
        public string CrearDeporte(string nomDeporte)
        {
            string respuesta = Modelos.CrearDeporte(nomDeporte);
            if (string.IsNullOrEmpty(respuesta))
            {

            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        respuesta = "No se pudo crear";
                        break;
                    case 2:
                        respuesta = "It couldn't be created";
                        break;
                }
            }
            return respuesta;
        }

        public List<Equipo> CargarEquipos()
        {
            string listaJson = Modelos.ObtenerListaEquipos();
            var listaEquipos = JsonConvert.DeserializeObject<List<Equipo>>(listaJson);
            return listaEquipos;
        }

        public List<Equipo> CargarEquiposFiltro(int idDeporte, int idPais)
        {
            string listaJson = Modelos.ObtenerListaEquiposFiltro(idDeporte, idPais);
            var listaEquipos = JsonConvert.DeserializeObject<List<Equipo>>(listaJson);
            return listaEquipos;
        }

        public Equipo CargarEquipoFiltro(string nombre, int idPais)
        {
            Equipo equipo = null;
            string equipoJson = Modelos.ObtenerEquipoFiltro(nombre, idPais);
            if (string.IsNullOrEmpty(equipoJson))
            {

            }
            else
            {
                equipo = JsonConvert.DeserializeObject<Equipo>(equipoJson);
            }
            return equipo;
        }

        public string EliminarEquipo(int idEquipo)
        {
            string respuesta = Modelos.EliminarEquipo(idEquipo);
            if (string.IsNullOrEmpty(respuesta))
            {

            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("No se pudo eliminar");
                        break;
                    case 2:
                        MessageBox.Show("It couden't be deleted");

                        break;
                }
            }
            return respuesta;
        }

        public string CrearEquipo(Equipo equipo)
        {
            string respuesta = "";
            if (string.IsNullOrEmpty(equipo.NomEquipo) ||
                string.IsNullOrEmpty(equipo.RutaEscudo) ||
                string.IsNullOrEmpty(equipo.NomDt) ||
                string.IsNullOrEmpty(equipo.ApeDt) ||
                equipo.IdDeporte == 0 || equipo.IdPais == 0)
            {
                respuesta = "error";
                           
            }
            else
            {
                respuesta = Modelos.CrearEquipo(equipo);

            }
            return respuesta;
        }

        public string ActualizarEquipo(Equipo equipo)
        {
            string respuesta = "";
            if (string.IsNullOrEmpty(equipo.NomEquipo) ||
                string.IsNullOrEmpty(equipo.RutaEscudo) ||
                string.IsNullOrEmpty(equipo.NomDt) ||
                string.IsNullOrEmpty(equipo.ApeDt) ||
                equipo.IdDeporte == 0 || equipo.IdPais == 0)
            {
                respuesta = "error";
            }
            else
            {
                respuesta = Modelos.ActulizarEquipo(equipo);
            }
            return respuesta;
        }

        public List<Torneo> CargarTorneos()
        {
            string listaJson = Modelos.ObtenerListaTorneos();
            var listaTorneos = JsonConvert.DeserializeObject<List<Torneo>>(listaJson);
            return listaTorneos;
        }

        public int ObtenerIdTorneo(string nombreTorneo)
        {
            int id = Modelos.ObtenerIdTorneo(nombreTorneo);
            return id;

        }

        public void ActulizarTorneo(int id, string nomNuevo)
        {
            Modelos.ActualizarTorneo(id, nomNuevo);
        }

        public string EliminarTorneo(int id)
        {
            string respuesta = Modelos.EliminarTorneo(id);
            if (string.IsNullOrEmpty(respuesta))
            {

            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        respuesta = "No se pudo eliminar";
                        break;
                    case 2:
                        respuesta = "It couldn't be deleted";
                        break;
                }
            }
            return respuesta;
        }

        public string CrearTorneo(string nomTorneo)
        {
            string respuesta = Modelos.CrearTorneo(nomTorneo);
            if (string.IsNullOrEmpty(respuesta))
            {

            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        respuesta = "No se pudo crear";
                        break;
                    case 2:
                        respuesta = "It couldn't be created";
                        break;
                }
            }
            return respuesta;

        }

        public string RegistrarJugador(Jugadores jugador, Equipo equipo)
        {
            string respuesta = "";
            respuesta = Modelos.CrearJugador(jugador);
            if (string.IsNullOrEmpty(respuesta))
            {
                int idJugador = Modelos.ObtenerIdJugador(jugador.Nombre, jugador.Apellido, jugador.FechaNac, jugador.IdPais);
                MessageBox.Show("idJugador = " + idJugador + "\n" + "idEquipo = " + equipo.IdEquipo);
                respuesta = Modelos.JugadorFormaParte(idJugador, equipo.IdEquipo);
                if (string.IsNullOrEmpty(respuesta))
                {

                } else respuesta = "error";

            } else respuesta = "error";

            return respuesta;
        }

        public string EliminarJugador(int idJugador)
        {
            string respuesta = Modelos.EliminarJugador(idJugador);
            return respuesta;
        }

        public Jugadores BuscarJugador(string nom, string ape, int idPais)
        {
            string jugadorJson = Modelos.BuscarJugador(nom, ape, idPais);
            var jugador = JsonConvert.DeserializeObject<Jugadores>(jugadorJson);
            return jugador;
        }

        public void ActualizarJugador(Jugadores jugador)
        {
            Modelos.ActualizarJugador(jugador);
        }

        public List<Jugadores> ListaJugadoresEquipo(int idEquipo)
        {
            string listaJson = Modelos.ListaJugadoresEquipo(idEquipo);
            var listaJugadores = JsonConvert.DeserializeObject<List<Jugadores>>(listaJson);
            return listaJugadores;
        }

        public void AgregarJugadorEquipoEncuentro(int idJugador, int idEncuentro, int idEquipo)
        {
            Modelos.AgregarJugadorEquipoEncuentro(idJugador, idEncuentro, idEquipo);
        }

    }
}
