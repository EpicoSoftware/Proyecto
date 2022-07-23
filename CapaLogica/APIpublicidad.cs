using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace CapaLogica
{
    public class APIpublicidad
    {
        public byte[] DisplayAnuncioRandom()
        {
            string respuesta;
            Random random = new Random();
            int cantidadAnuncios = Modelos.CantidadDeAnuncios();
            int randomNumero = random.Next(1, cantidadAnuncios);
            string anuncio = Modelos.MostrarAnuncio(randomNumero);
            if (string.IsNullOrEmpty(anuncio)){
                respuesta = "No se encontro anuncio";
            }
            var datosAnuncio = JsonConvert.DeserializeObject<Anuncio>(anuncio);
            byte[] imagen = datosAnuncio.Imagen;
            return imagen;
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
    }
}
