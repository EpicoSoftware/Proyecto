using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Data;

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
                switch (Sesion.idIdioma)
                {
                    case 1:
                        respuesta = "Debe llenar todos los campos";
                        break;
                    case 2:
                        respuesta = "You must fill all the fields";
                        break;

                }

            }
            else
            {
                if (EmailValido(correo))
                {
                    string usuarioJson = Modelos.obtenerUsuario(correo);
                    var datosUsuario = JsonConvert.DeserializeObject<Usuario>(usuarioJson);

                    if (datosUsuario == null)
                    {
                        switch (Sesion.idIdioma)
                        {
                            case 1:
                                respuesta = "El usuario no existe";
                                break;
                            case 2:
                                respuesta = "User not found";
                                break;

                        }

                    }
                    else
                    {
                        string contra = Modelos.obtenerPassword(datosUsuario.IdUsuario);

                        if (contra != md5.Encriptar(password))//Compara las contrasenas encriptadas para mas seguridad
                        {
                            switch (Sesion.idIdioma)
                            {
                                case 1:
                                    respuesta = "La contraseña no es correcta";
                                    break;
                                case 2:
                                    respuesta = "The password is not correct";
                                    break;
                            }

                        }
                        else
                        {
                            Sesion.correo = datosUsuario.Email;
                            Sesion.nombre = datosUsuario.NomUsuario;
                            Sesion.idUsuario = datosUsuario.IdUsuario;
                            Sesion.idTipoUsuario = datosUsuario.IdTipoUsuario;
                        }

                    }
                }
                else
                {
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            respuesta = "Eso no aparenta ser un correo";
                            break;
                        case 2:
                            respuesta = "That doesn't seem to be a mail";
                            break;
                    }
                }

            }
            return respuesta;
        }

        public string Registro(Usuario datosUsuario, string contraseña)
        {
            string respuesta = "";

            //Verificar que esta completo
            if (string.IsNullOrEmpty(datosUsuario.Email) ||
                string.IsNullOrEmpty(datosUsuario.NomUsuario) ||
                string.IsNullOrEmpty(contraseña)
                )
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        respuesta = "Debes rellenar todos los campos";
                        break;
                    case 2:
                        respuesta = "All field must be filled";
                        break;
                }
            }
            else //Si esta completo
            {
                if (EmailValido(datosUsuario.Email)) //Validar email
                {
                    if (string.IsNullOrEmpty(Modelos.obtenerUsuario(datosUsuario.Email))) //Si no esta el correo registrado
                    {
                        switch (Sesion.idIdioma)
                        {
                            case 1:
                                respuesta = "Ya existe una cuenta con ese correo, intenta iniciando sesion";
                                break;
                            case 2:
                                respuesta = "There is already an account for that email, try loging in";
                                break;
                        }

                    }
                    else
                    {
                        Modelos.RegistrarUsuario(datosUsuario, contraseña);

                    }
                }
                else
                {
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            respuesta = "Eso no aparenta ser un correo";
                            break;
                        case 2:
                            respuesta = "That doesn't seem to be a mail";
                            break;
                    }
                }
            }
            return respuesta;
        }

        public List<Usuario> ListaUsuarios()
        {
            string listaJson = Modelos.ObtenerListaUsuarios();
            var listaAnuncios = JsonConvert.DeserializeObject<List<Usuario>>(listaJson);
            return listaAnuncios;
        }

        public Usuario obtenerUsuario(string correo)
        {
            string usuarioJSON = Modelos.obtenerUsuario(correo);
            var usuario = JsonConvert.DeserializeObject<Usuario>(usuarioJSON);
            return usuario;
        }

        public string ActualizarUsuario(Usuario user)
        {
            string respuesta = "";
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.NomUsuario))
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        respuesta = "Todos los campos deben estar llenos";
                        break;
                    case 2:
                        respuesta = "All fields must be filled";
                        break;
                }
            }
            else
            {
                Modelos.ActualizarUsuario(user);
            }
            return respuesta;

        }

        public void EliminarUsuario(int idUsuario, int tipoUsuario)
        {
            Modelos.EliminarUsuario(idUsuario, tipoUsuario);
        }
    }
}
