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
    public class APIautenticacion
    {
        bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public string Login(string correo, string password)
        {
            string respuesta = "";
            EncriptarMD5 md5 = new EncriptarMD5();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (EmailValido(correo))
                {
                    string usuarioJson = Modelos.obtenerUsuario(correo);
                    var datosUsuario = JsonConvert.DeserializeObject<Usuario>(usuarioJson);

                    if (datosUsuario == null)
                    {
                        respuesta = "El usuario no existe";
                    }
                    else
                    {
                        int idPassoword = Modelos.obtenerIdPassword(datosUsuario.IdUsuario);
                        //busca el Id contraseña del usuario registrado con ese correo en la tabla contraseñas_usuarios
                        if (idPassoword != 0)
                        {
                            string contra = Modelos.obtenerPassword(idPassoword);

                            if (contra != md5.Encriptar(password))//Compara las contrasenas encriptadas para mas seguridad
                            {
                                respuesta = "El usuario y/o contraseña no coinciden";
                            }
                            else
                            {
                                Sesion.correo = datosUsuario.Correo;
                                Sesion.nombre = datosUsuario.Nombre;
                                Sesion.idTipo = datosUsuario.IdTipo;
                                Sesion.idColorMode = datosUsuario.IdColorMode;
                                Sesion.idIdioma = datosUsuario.IdIdioma;
                            }
                        }
                    }
                }
                else
                {
                    respuesta = "Eso no aparenta ser un correo";
                }
                
            }
            return respuesta;
        }
        public string Registro (string usuarioJson)
        {
            string respuesta = "";
            var datosUsuario = JsonConvert.DeserializeObject<Usuario>(usuarioJson);
            if(string.IsNullOrEmpty(datosUsuario.Nombre) ||
                string.IsNullOrEmpty(datosUsuario.Correo) ||
                datosUsuario.IdPais == null ||
                datosUsuario.IdIdioma == null)
            {
                respuesta = "Asegurate de llenar todos los campos";
            }
            else
            {
                Modelos.RegistrarUsuario(datosUsuario);
            }
            return respuesta;
        }
        
    }
}
