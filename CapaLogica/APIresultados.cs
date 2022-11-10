using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
