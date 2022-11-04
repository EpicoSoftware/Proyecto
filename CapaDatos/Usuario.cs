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
        int idUsuario ,idTipoUsuario, IdIdioma;
        string email, nomUsuario;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
        public string Email { get => email; set => email = value; }
        public string NomUsuario { get => nomUsuario; set => nomUsuario = value; }
        public int IdIdioma1 { get => IdIdioma; set => IdIdioma = value; }
        public object Value { get; set; }
    }
}
