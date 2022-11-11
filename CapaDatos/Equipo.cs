using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    [Serializable]
    public class Equipo
    {
        int idEquipo, idDeporte, idPais;
        string nomEquipo, rutaEscudo, nomDt, apeDt;
        bool esSeleccion;

        public int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public string NomEquipo { get => nomEquipo; set => nomEquipo = value; }
        public string RutaEscudo { get => rutaEscudo; set => rutaEscudo = value; }
        public string NomDt { get => nomDt; set => nomDt = value; }
        public bool EsSeleccion { get => esSeleccion; set => esSeleccion = value; }
        public int IdPais { get => idPais; set => idPais = value; }
        public string ApeDt { get => apeDt; set => apeDt = value; }
    }
}
