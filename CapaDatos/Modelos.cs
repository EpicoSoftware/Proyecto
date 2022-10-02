using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace CapaDatos
{
    public class Modelos
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "root";
            string bd = "dbsistdeportivo";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;
        }

        public static int obtenerIdPassword(int idUsuario)
        {
            int idPassword = 0;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from contraseñas_usuarios WHERE idUsuario LIKE @idUsuario";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                idPassword = int.Parse(reader["idContraseña"].ToString());
            }

            return idPassword;
        }
        public static string obtenerPassword(int idPassword)
        {
            string password = null;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT Contraseña FROM contraseñas WHERE idContraseña LIKE @idPassword";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idPassword", idPassword);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                password = reader["Contraseña"].ToString();
            }

            return password;
        }

        public static string obtenerUsuario(string correo)
        {
            Usuario user = null;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from usuarios WHERE Correo LIKE @correo";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@correo", correo);

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                user = new Usuario();
                user.IdUsuario = int.Parse(reader["idUsuario"].ToString());
                user.Correo = reader["Correo"].ToString();
                user.Nombre = reader["Nombre"].ToString();
                user.IdTipo = int.Parse(reader["idTipo"].ToString());
                user.IdColorMode = int.Parse(reader["idColorMode"].ToString());
                user.IdIdioma = int.Parse(reader["idIdioma"].ToString());
                user.IdPais = int.Parse(reader["idNacionalidad"].ToString());

            }

            var usuarioJson = JsonConvert.SerializeObject(user);

            return usuarioJson;
        }


        //Metodo para rellenar combobox ("Inteligentes")
        public static void RellanarCbo(ComboBox cbo, string tabla, string columnaTabla)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from " + tabla;

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cbo.Items.Add(reader.GetString(columnaTabla));
            }
        }
        public static int ObtenerId(string opcionSelecionada, string tabla, string columnaTabla)
        {
            int id = 0;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * FROM @tabla WHERE @columnaTabla LIKE @opcionSelecionada";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@tabla", tabla);
            comando.Parameters.AddWithValue("@columnaTabla", columnaTabla);
            comando.Parameters.AddWithValue("@opcionSelecionada", opcionSelecionada);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                id = int.Parse(reader[columnaTabla].ToString());
            }

            return id;
        }

        public static int ObtenerIdPais(string pais)
        {
            int id = 0;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * FROM paises WHERE nombre LIKE @pais";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@pais", pais);

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                id = int.Parse(reader["idPais"].ToString());
            }

            return id;
        }

        //ANUNCIOS
        public static string MostrarAnuncio(int id)
        {
            Anuncio banner = null;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from anuncios WHERE idAnuncio LIKE @idAnuncio";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idAnuncio", id);

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                banner = new Anuncio();
                banner.IdAnuncio = int.Parse(reader["idAnuncio"].ToString());
                banner.Imagen = (byte[])(reader["Imagen"]);   //pasando de string a arreglo de bytes
                banner.NombreMarca = reader["NombreMarca"].ToString();
                banner.Link = reader["Link"].ToString();
            }

            var bannerJson = JsonConvert.SerializeObject(banner);
            return bannerJson;
        }
        public static int CantidadDeAnuncios()
        {
            int cantidadAnuncios = 0;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT count(*) FROM anuncios WHERE Estado = true;";

            MySqlCommand comando = new MySqlCommand(sql, conexion);

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cantidadAnuncios = int.Parse(reader[0].ToString());
            }

            return cantidadAnuncios;
        }

        public static int ExisteVista(int idAnuncio, int idUsuario)
        {
            int cantidadVistas = 0;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            //Buscando se existe una vista del anuncio por ese usuario
            string sql =
                "SELECT * FROM anuncios_usuariosgratis WHERE idUsuario LIKE @idUsuario AND idAnuncio = @idAnuncio";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@idAnuncio", idAnuncio);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cantidadVistas = int.Parse(reader["CantidadVistas"].ToString());
            }

            return cantidadVistas;
        }

        public static string CrearVista(int idAnuncio, int idUsuario)
        {
            string respuesta = null;
            MySqlConnection conexion = getConexion();
            conexion.Open();
            try
            {
                //Crea la primer vista al anuncio
                string sql =
                        "INSERT INTO anuncios_usuariosgratis (idAnuncio, idUsuario, CantidadVistas) VALUES(@idAnuncio, @idUsuario @cantidadVistas)";

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                comando.Parameters.AddWithValue("@idAnuncio", idAnuncio);
                comando.Parameters.AddWithValue("@cantidadVistas", 1);
                Console.WriteLine(comando.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                respuesta = "Error al crear vista";
            }
            return respuesta;
        }

        public static string AgregarVistaAnuncio(int idAnuncio, int idUsuario)
        {
            string respuesta = null;
            int cantidadVistas = ExisteVista(idAnuncio, idUsuario);
            MySqlConnection conexion = getConexion();
            conexion.Open();

            if (cantidadVistas>0) //Si existe
            {
                try //agrega una nueva vista en el atributo CantidadVistas
                {
                    cantidadVistas += 1;

                    string sql =
                        "UPDATE anuncios_usuariosgratis SET CantidadVistas = @cantidadVistas WHERE idAnuncio = @idAnuncio AND idUsuario = @idUsuario";

                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@idAnuncio", idAnuncio);
                    comando.Parameters.AddWithValue("@cantidadVistas", cantidadVistas);
                    Console.WriteLine(comando.ExecuteNonQuery());
                }
                catch (Exception e)
                {
                    respuesta = "Error al agregar vista";
                }
            }
            else //Si no existe
            {
                respuesta = CrearVista(idAnuncio, idUsuario);
            }
            return respuesta;
        }

        public static void RegistrarAnuncio(Anuncio anuncio)
        {
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "INSERT INTO anuncios (Imagen, NombreMarca, Link, Estado, CorreoContacto) VALUES(@imagen, @nombreMarca, @link, @estado, @correoContacto)";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@imagen", anuncio.Imagen);
            comando.Parameters.AddWithValue("@nombreMarca", anuncio.NombreMarca);
            comando.Parameters.AddWithValue("@link", anuncio.Link);
            comando.Parameters.AddWithValue("@estado", anuncio.Estado);
            comando.Parameters.AddWithValue("@correoContacto", anuncio.CorreoContacto);

            Console.WriteLine(comando.ExecuteNonQuery());
        }

        public static string EliminarAnuncio(int idAununcio)
        {
            string respuesta = null;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                         "DELETE FROM anuncios WHERE idAnuncio = @idAununcio, " +
                         "DELETE FROM anuncios_usuariosgratis WHERE idAnuncio = @idAununcio, ";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idAununcio", idAununcio);
            
            Console.WriteLine(comando.ExecuteNonQuery());

            return respuesta;
        }
        //RESULTADOS
        public static DataTable obtenerDeportes()
        {
            DataTable dataTable = new DataTable();
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from deportes";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            //comando.Parameters.AddWithValue("@correo", correo);

            reader = comando.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
        }
    }
}
