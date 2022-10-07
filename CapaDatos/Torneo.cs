using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    [Serializable]
    public class Torneo
    {
        int idTorneo;
        string nomTorneo;

        public int IdTorneo { get => idTorneo; set => idTorneo = value; }
        public string NomTorneo { get => nomTorneo; set => nomTorneo = value; }
    }
}
