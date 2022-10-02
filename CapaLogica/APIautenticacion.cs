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
                        int idPassoword = Modelos.obtenerIdPassword(datosUsuario.IdUsuario);
                        //busca el Id contraseña del usuario registrado con ese correo en la tabla contraseñas_usuarios
                        if (idPassoword != 0)
                        {
                            string contra = Modelos.obtenerPassword(idPassoword);

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
                                Sesion.correo = datosUsuario.Correo;
                                Sesion.nombre = datosUsuario.Nombre;
                                Sesion.idUsuario = datosUsuario.IdUsuario;
                                Sesion.idTipo = datosUsuario.IdTipo;
                                Sesion.idColorMode = datosUsuario.IdColorMode;
                                Sesion.idIdioma = datosUsuario.IdIdioma;
                            }
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


        public string Registro(string usuarioJson, string contraseña)
        {
            string respuesta = "";
            var datosUsuario = JsonConvert.DeserializeObject<Usuario>(usuarioJson);
            if (String.IsNullOrEmpty(datosUsuario.Correo) ||
                String.IsNullOrEmpty(datosUsuario.Nombre) ||
                String.IsNullOrEmpty(contraseña) ||
                String.IsNullOrEmpty(datosUsuario.IdIdioma.ToString()) ||
                String.IsNullOrEmpty(datosUsuario.IdPais.ToString()) ||
                String.IsNullOrEmpty(datosUsuario.IdColorMode.ToString())
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
            else
            {
                if (EmailValido(datosUsuario.Correo))
                {
                    /*try
                    {
                        Modelos.RegistrarUsuario(datosUsuario, contraseña);
                    }
                    catch (Exception ex)
                    {
                        respuesta = "No se ha podido registrar el usuario";
                    }*/
                    //Modelos.RegistrarUsuario(datosUsuario, contraseña);
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
    }
}
