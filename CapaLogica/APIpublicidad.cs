using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections;

namespace CapaLogica
{
    public class APIpublicidad
    {
        public Anuncio DisplayAnuncioRandom()
        {
            Random random = new Random();
            int cantidadAnuncios = Modelos.CantidadDeAnuncios();
            int randomNumero = random.Next(1, cantidadAnuncios);
            string anuncio = Modelos.MostrarAnuncio(randomNumero);
            var datosAnuncio = JsonConvert.DeserializeObject<Anuncio>(anuncio);
            return datosAnuncio;
        }

        public string AgregarVista(int idAnuncio, int idUsuario)
        {
            string respuesta = Modelos.AgregarVistaAnuncio(idAnuncio, idUsuario);
            return respuesta;
        }

        public string agregarAnuncio(string anuncioJson)
        {
            string respuesta = "";
            var datosAnuncio = JsonConvert.DeserializeObject<Anuncio>(anuncioJson);
            if (string.IsNullOrEmpty(datosAnuncio.NombreMarca) || string.IsNullOrEmpty(datosAnuncio.Link) || datosAnuncio.Imagen == null)
            {
                respuesta = "Rellena todos los campos";
            }
            else
            {
                Modelos.RegistrarAnuncio(datosAnuncio);
                
            }
            return respuesta;
        }

        public List<Anuncio> CargarListaAnuncios()
        {
            List<Anuncio> listaAnuncios = new List<Anuncio>();
            string listaJson = Modelos.ObtenerListaAnuncios();
            listaAnuncios = JsonConvert.DeserializeObject<List<Anuncio>>(listaJson);

            return listaAnuncios;

        }

        public List<Anuncio> buscarAnuncio(string nomMarca)
        {
            string resultadoBusqueda = Modelos.BuscarAnuncio(nomMarca);
            var listaResultados = JsonConvert.DeserializeObject<List<Anuncio>>(resultadoBusqueda);

            return listaResultados;
        }

        public string EliminarAnuncio(int idAnuncio)
        {
            string respuesta = Modelos.EliminarAnuncio(idAnuncio);
            return respuesta;
        }

        public Anuncio ObtenerAnuncio(int idAnuncio)
        {
            Anuncio anuncio = new Anuncio();
            string anuncioJson = Modelos.ObtenerAnuncio(idAnuncio);
            anuncio = JsonConvert.DeserializeObject<Anuncio>(anuncioJson);

            return anuncio;
        }

        public void ActualizarAnuncio(Anuncio anuncio)
        {
            if(string.IsNullOrEmpty(anuncio.CorreoContacto) || 
                string.IsNullOrEmpty(anuncio.Imagen) || 
                string.IsNullOrEmpty(anuncio.Link) ||
                string.IsNullOrEmpty(anuncio.NombreMarca))
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Debe llenar todos los campos", "Error");
                        break;
                    case 2:
                        MessageBox.Show("You must fill all fields", "Error");
                        break;
                }
            }
            else
            {
                Modelos.ActualizarAnuncio(anuncio);
            }
            
        }

    }
}
