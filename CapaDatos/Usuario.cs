using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    [Serializable]
    public class Usuario
    {
        int idUsuario ,idTipo ,idPais, idColorMode, idIdioma;
        string correo, nombre;

        public string Correo { get => correo; set => correo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdColorMode { get => idColorMode; set => idColorMode = value; }
        public int IdIdioma { get => idIdioma; set => idIdioma = value; }
        public int IdPais { get => idPais; set => idPais = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
    }
}
