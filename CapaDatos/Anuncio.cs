using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    [Serializable]
    public class Anuncio
    {
        int idAnuncio;
        string nombreMarca, link, imagen;
        string correoContacto;
        bool estado;

        public int IdAnuncio { get => idAnuncio; set => idAnuncio = value; }
        
        public string NombreMarca { get => nombreMarca; set => nombreMarca = value; }
        public string Link { get => link; set => link = value; }
        public string CorreoContacto { get => correoContacto; set => correoContacto = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}
