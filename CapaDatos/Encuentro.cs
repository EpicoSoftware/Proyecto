using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    [Serializable]
    public class Encuentro
    {
        int idTorneo, idEncuentro, idDeporte, idEstado;
        string nomArbitro, apeArbitro, nomEstadio, fecha;

        public int IdTorneo { get => idTorneo; set => idTorneo = value; }
        public int IdEncuentro { get => idEncuentro; set => idEncuentro = value; }
        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public string NomArbitro { get => nomArbitro; set => nomArbitro = value; }
        public string ApeArbitro { get => apeArbitro; set => apeArbitro = value; }
        public string NomEstadio { get => nomEstadio; set => nomEstadio = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
    }
}
