using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

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
        public static void RegistrarUsuario(Usuario usuario)
        {
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "INSERT INTO usuarios (Correo, Nombre, idTipo, idIdioma, idNacionalidad, fotoPerfil) VALUES(@correo, @nombre, @idTipo, @idIdioma, @idNacionalidad, @fotoPerfil)";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@correo", usuario.Correo);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@idTipo", 2);
            comando.Parameters.AddWithValue("@idIdioma", usuario.IdIdioma);
            comando.Parameters.AddWithValue("@idNacionalidad", usuario.IdPais);
            comando.Parameters.AddWithValue("@fotoPerfil", usuario.FotoPerfil);
            Console.WriteLine(comando.ExecuteNonQuery());
            

        }
        public static void obtenerListaPaises(ComboBox cbo)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from paises";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cbo.Items.Add(reader.GetString("nombre"));
            }
            

        }
        public static void obtenerListaIdiomas(ComboBox cbo)
        {

            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from idiomas";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cbo.Items.Add(reader.GetString("NombreIdioma"));
            }
        }

        public int obtenerIdPais(string nombrePais)
        {
            int idPais = ;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT idPais FROM paises WHERE nombre LIKE @nombrePais";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombrePais", nombrePais);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                idPais = int.Parse(reader["Contraseña"].ToString());
            }

            return idPais;
        }
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
                banner.Imagen =  (byte[])(reader["Imagen"]);   //pasando de string a arreglo de bytes
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
                "SELECT count(*) FROM anuncios";

            MySqlCommand comando = new MySqlCommand(sql, conexion);

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cantidadAnuncios = int.Parse(reader[0].ToString());
            }

            return cantidadAnuncios;
        }
        public static void RegistrarAnuncio(Anuncio anuncio)
        {
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "INSERT INTO anuncios (Imagen, NombreMarca, Link) VALUES(@imagen, @nombreMarca, @link)";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@imagen", anuncio.Imagen);
            comando.Parameters.AddWithValue("@nombreMarca", anuncio.NombreMarca);
            comando.Parameters.AddWithValue("@link", anuncio.Link);
            
            Console.WriteLine(comando.ExecuteNonQuery());
        }


    }
}
