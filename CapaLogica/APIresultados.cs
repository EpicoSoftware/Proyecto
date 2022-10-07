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
        public List<Encuentro> CargarListaVivo(int estado)
        {
            //List<Anuncio> listaAnuncios = new List<Anuncio>();
            string listaJson = Modelos.ObtenerListaEncuentrosEstado(estado);
            var listaEncuentro = JsonConvert.DeserializeObject<List<Encuentro>>(listaJson);

            return listaEncuentro;

        }

    }
}
