using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    [Serializable]
    public class Jugadores
    {
        int idJugador, numero, idPais, idDeporte;
        string nombre, apellido, fechaNac;
        bool selaccion;

        public int IdJugador { get => idJugador; set => idJugador = value; }
        public int Numero { get => numero; set => numero = value; }
        public int IdPais { get => idPais; set => idPais = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public bool Selaccion { get => selaccion; set => selaccion = value; }
    }
}
