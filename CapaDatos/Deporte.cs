using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    [Serializable]
    public class Deporte
    {
        int idDeporte;
        string nomDeporte;

        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public string NomDeporte { get => nomDeporte; set => nomDeporte = value; }
    }
}
