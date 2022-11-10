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
        //GENERALES
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
        public static string CargarPaises()
        {
            List<String> listaPais = new List<String>();
            string pais;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from paises";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                pais = reader["nomPais"].ToString();
                listaPais.Add(pais);
            }

            var listaPaisJson = JsonConvert.SerializeObject(listaPais);
            return listaPaisJson;
        }

        //AUTENTICACION

        public static string obtenerPassword(int idUsuario)
        {
            string password = null;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT Contraseña FROM Contraseña WHERE idUsuario LIKE @idUsuario";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
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
                "SELECT * from Usuario WHERE email LIKE @correo";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@correo", correo);

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                user = new Usuario();
                user.IdUsuario = int.Parse(reader["idUsuario"].ToString());
                user.Email = reader["email"].ToString();
                user.NomUsuario = reader["nomUsuario"].ToString();
                user.IdTipoUsuario = int.Parse(reader["idTipoUsuario"].ToString());
            }

            var usuarioJson = JsonConvert.SerializeObject(user);

            return usuarioJson;
        }

        public static void RegistrarUsuario(Usuario user, string contaseña)
        {
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                    "INSERT INTO Usuario (email, nomUsuario, idTipoUsuario) VALUES(@email, @nomUsuario, @idTipoUsuario); " +
                    "INSERT INTO Contraseña(Contraseña, idUsuario) VALUES(@contaseña, (SELECT idUsuario FROM Usuario WHERE email = @email)); ";
               
            switch (user.IdTipoUsuario)
            {
                case 1:
                    sql += "INSERT INTO Usuariosgratis VALUES((SELECT idUsuario FROM usuario WHERE email = @email))";
                    break;
                case 2:
                    sql += "INSERT INTO Usuariospago VALUES((SELECT idUsuario FROM usuario WHERE email = @email))";
                    break;
            }

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@email", user.Email);
            comando.Parameters.AddWithValue("@nomUsuario", user.NomUsuario);
            comando.Parameters.AddWithValue("@idTipoUsuario", user.IdTipoUsuario);
            comando.Parameters.AddWithValue("@contaseña", contaseña);

            Console.WriteLine(comando.ExecuteNonQuery());
        }

        public static string EliminarUsuario(int idUsuario, int tipoUsuario)
        {
            string respuesta = null;
            MySqlConnection conexion = getConexion();
            try
            {
                conexion.Open();
                string sql = "";
                switch (tipoUsuario)
                {
                    case 1:
                        sql += "DELETE FROM usuariosgratis WHERE idUsuario = @idUsuario; ";
                        break;
                    case 2:
                        sql += "DELETE FROM usuariopago WHERE idUsuario = @idUsuario; ";
                        break;
                }
                sql += "DELETE FROM Contraseña WHERE idUsuario = @idUsuario; " +
                    "DELETE FROM Usuario WHERE idUsuario = @idUsuario;";

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                Console.WriteLine(comando.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


            return respuesta;
        }

        public static string ObtenerListaUsuarios()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            Usuario user;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from Usuario";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                user = new Usuario();
                user.IdUsuario = int.Parse(reader["idUsuario"].ToString());
                user.Email = reader["email"].ToString();
                user.NomUsuario = reader["nomUsuario"].ToString();
                user.IdTipoUsuario = int.Parse(reader["idTipoUsuario"].ToString());
                listaUsuario.Add(user);
            }

            var listaUsuarioJson = JsonConvert.SerializeObject(listaUsuario);
            return listaUsuarioJson;
        }

        public static void ActualizarUsuario(Usuario user)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "UPDATE Usuario SET " +
                    "nomUsuario = @nomNuevo, " +
                    "email = @emailNuevo, " +
                    "idTipoUsuario = @idTipoNuevo " +
                "WHERE idUsuario = @id; ";

            switch (user.IdTipoUsuario)
            {
                case 1:
                    sql += "INSERT INTO usuariosgratis VALUES(@id); " +
                        "DELETE FROM usuariopago WHERE idUsuario = @id;";
                    break;
                case 2:
                    sql += "INSERT INTO usuariopago VALUES(@id);" +
                        "DELETE FROM usuariosgratis WHERE idUsuario = @id;";
                    break;
                case 3:
                    sql += "DELETE FROM usuariopago WHERE idUsuario = @id; " +
                        "DELETE FROM usuariosgratis WHERE idUsuario = @id;";
                    break;
            }

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nomNuevo", user.NomUsuario);
            comando.Parameters.AddWithValue("@emailNuevo", user.Email);
            comando.Parameters.AddWithValue("@idTipoNuevo", user.IdTipoUsuario);
            comando.Parameters.AddWithValue("@id", user.IdUsuario);
            reader = comando.ExecuteReader();
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
                banner.Imagen = reader["imagen"].ToString();   
                banner.NombreMarca = reader["nomMarca"].ToString();
                banner.Link = reader["link"].ToString();
                banner.Estado = bool.Parse(reader["estado"].ToString());
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

            if (cantidadVistas > 0) //Si existe
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

        public static string ObtenerListaAnuncios()
        {
            List<Anuncio> listaAnuncios = new List<Anuncio>();
            Anuncio ad;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from anuncios";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ad = new Anuncio();
                ad.IdAnuncio = int.Parse(reader["idAnuncio"].ToString());
                ad.Link = reader["link"].ToString();
                ad.NombreMarca = reader["nomMarca"].ToString();
                ad.Estado = bool.Parse(reader["estado"].ToString());
                ad.Imagen = reader["imagen"].ToString(); //pasando de string a arreglo de bytes

                listaAnuncios.Add(ad);
            }

            string listaAnunciosJson = JsonConvert.SerializeObject(listaAnuncios);
            return listaAnunciosJson;
        }

        public static void ActualizarAnuncio(Anuncio anuncio)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "UPDATE anuncios SET " +
                "nomMarca = @nomMarca " +
                "imagen = @imagen " +
                "link = @link " +
                "correoContacto = @correoContacto " +
                "estado = @estado " +
                "WHERE idDeporte = @id; ";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nomMarca", anuncio.NombreMarca);
            comando.Parameters.AddWithValue("@imagen", anuncio.Imagen);
            comando.Parameters.AddWithValue("@link", anuncio.Link);
            comando.Parameters.AddWithValue("@correoContacto", anuncio.CorreoContacto);
            comando.Parameters.AddWithValue("@estado", anuncio.Estado);
            comando.Parameters.AddWithValue("@id", anuncio.IdAnuncio);
            reader = comando.ExecuteReader();
        }

        public static void RegistrarAnuncio(Anuncio anuncio)
        {
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "INSERT INTO anuncios (nomMarca, imagen, link, correoContacto, estado) VALUES(@nombreMarca, @imagen, @link, @correoContacto, @estado)";

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
            try
            {
                conexion.Open();

                string sql =
                             "DELETE FROM anuncios WHERE idAnuncio LIKE @idAununcio; " +
                             "DELETE FROM gratisanuncios WHERE idAnuncio LIKE @idAununcio";

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idAununcio", idAununcio);

                Console.WriteLine(comando.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                respuesta = e.ToString();
            }


            return respuesta;
        }

        public static string BuscarAnuncio(string nomMarca)
        {
            List<Anuncio> listaAnuncios = new List<Anuncio>();
            Anuncio ad;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from anuncios WHERE nomMarca LIKE '%" + nomMarca + "%'";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            //comando.Parameters.AddWithValue("@nomMarca", nomMarca);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ad = new Anuncio();
                ad.IdAnuncio = int.Parse(reader["idAnuncio"].ToString());
                ad.Link = reader["link"].ToString();
                ad.NombreMarca = reader["nomMarca"].ToString();
                ad.Estado = bool.Parse(reader["estado"].ToString());
                ad.Imagen = reader["imagen"].ToString(); //pasando de string a arreglo de bytes

                listaAnuncios.Add(ad);
            }

            var listaAnunciosJson = JsonConvert.SerializeObject(listaAnuncios);
            return listaAnunciosJson;
        }

        public static string ObtenerAnuncio(int idAnuncios)
        {
            Anuncio anuncio = new Anuncio();
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from anuncios WHERE idAnuncio = @idAnuncio";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idAnuncio", anuncio.Imagen);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                anuncio.IdAnuncio = int.Parse(reader["idAnuncio"].ToString());
                anuncio.Link = reader["link"].ToString();
                anuncio.NombreMarca = reader["nomMarca"].ToString();
                anuncio.Estado = bool.Parse(reader["estado"].ToString());
                anuncio.Imagen = reader["imagen"].ToString(); //pasando de string a arreglo de bytes
            }

            string anuncioJson = JsonConvert.SerializeObject(anuncio);

            return anuncioJson;
        }

        //ENCUENTROS
        public static string ObtenerListaEncuentrosEstado(int estadoFiltro)
        {
            List<Encuentro> listaEncuentros = new List<Encuentro>();
            Encuentro encuentro;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from encuentro WHERE idEstado = @idEstado";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idEstado", estadoFiltro);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                encuentro = new Encuentro();
                encuentro.IdEncuentro = int.Parse(reader["idEncuentro"].ToString());
                encuentro.IdDeporte = int.Parse(reader["idDeporte"].ToString());
                encuentro.IdTorneo = int.Parse(reader["IdTorneo"].ToString());
                encuentro.IdEstado = int.Parse(reader["IdTorneo"].ToString());
                encuentro.Fecha = reader["Fecha"].ToString();
                encuentro.NomEstadio = reader["nomEstadio"].ToString();
                encuentro.NomArbitro = reader["nomArbitro"].ToString();
                encuentro.ApeArbitro = reader["apeArbitro"].ToString();

                listaEncuentros.Add(encuentro);
            }

            var listaEncuentrosJson = JsonConvert.SerializeObject(listaEncuentros);
            return listaEncuentrosJson;
        }

        public static string ObtenerListaDeportes()
        {
            List<Deporte> listaDeporte = new List<Deporte>();
            Deporte deporte;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from deportes";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                deporte = new Deporte();
                deporte.IdDeporte = int.Parse(reader["idDeporte"].ToString());
                deporte.NomDeporte = reader["nomDeporte"].ToString();
                listaDeporte.Add(deporte);
            }

            var listaDeporteJson = JsonConvert.SerializeObject(listaDeporte);
            return listaDeporteJson;
        }

        public static string ObtenerListaEquipos()
        {
            List<Equipo> listaEquipo = new List<Equipo>();
            Equipo equipo;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from equipo";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                equipo = new Equipo();
                equipo.IdEquipo = int.Parse(reader["idEquipo"].ToString());
                equipo.IdDeporte = int.Parse(reader["idDeporte"].ToString());
                equipo.IdPais = int.Parse(reader["idPais"].ToString());
                equipo.NomEquipo = reader["nomEquipo"].ToString();
                equipo.NomDt = reader["nomDt"].ToString();
                equipo.RutaEscudo = reader["escudo"].ToString();
                equipo.EsSeleccion = bool.Parse(reader["esSeleccion"].ToString());

                listaEquipo.Add(equipo);
            }

            var listaEquipoJson = JsonConvert.SerializeObject(listaEquipo);
            return listaEquipoJson;
        }

        public static string ObtenerListaEquiposFiltro(int idDeporte, int idPais)
        {
            List<Equipo> listaEquipo = new List<Equipo>();
            Equipo equipo;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from equipo WHERE idDeporte = @idDeporte AND idPais = @idPais";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idDeporte", idDeporte);
            comando.Parameters.AddWithValue("@idPais", idPais);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                equipo = new Equipo();
                equipo.IdEquipo = int.Parse(reader["idEquipo"].ToString());
                equipo.IdDeporte = int.Parse(reader["idDeporte"].ToString());
                equipo.IdPais = int.Parse(reader["idPais"].ToString());
                equipo.NomEquipo = reader["nomEquipo"].ToString();
                equipo.NomDt = reader["nomDt"].ToString();
                equipo.RutaEscudo = reader["escudo"].ToString();
                equipo.EsSeleccion = bool.Parse(reader["esSeleccion"].ToString());

                listaEquipo.Add(equipo);
            }

            var listaEquipoJson = JsonConvert.SerializeObject(listaEquipo);
            return listaEquipoJson;
        }

        public static int ObtenerIdDeporte(string nomDeporte)
        {
            Deporte deporte = new Deporte();
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from deportes WHERE nomDeporte = @nomDeporte";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nomDeporte", nomDeporte);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                deporte.IdDeporte = int.Parse(reader["idDeporte"].ToString());
            }

            return deporte.IdDeporte;
        }

        public static void ActualizarDeporte(int id, string nomNuevo)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "UPDATE deportes SET nomDeporte = @nomNuevo WHERE idDeporte = @id; ";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nomNuevo", nomNuevo);
            comando.Parameters.AddWithValue("@id", id);
            reader = comando.ExecuteReader();

        }

        public static string EliminarDeporte(int id)
        {
            string respuesta = null;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();

            try
            {
                conexion.Open();

                string sql =
                    "DELETE FROM deportes WHERE idDeporte = @id; ";

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@id", id);
                reader = comando.ExecuteReader();
            }
            catch (Exception e)
            {
                respuesta = e.ToString();
            }

            return respuesta;
        }

        public static string CrearDeporte(string nomDeporte)
        {
            string respuesta = null;
            MySqlConnection conexion = getConexion();

            try
            {
                conexion.Open();

                string sql =
                    "INSERT INTO deportes (nomDeporte) VALUES(@nomDeporte)";

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nomDeporte", nomDeporte);

                Console.WriteLine(comando.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                respuesta = e.ToString();
            }

            return respuesta;
        }

        public static string ObtenerListaTorneos()
        {
            List<Torneo> listaTorneo = new List<Torneo>();
            Torneo torneo;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from torneos";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                torneo = new Torneo();
                torneo.IdTorneo = int.Parse(reader["idTorneo"].ToString());
                torneo.NomTorneo = reader["nomTorneo"].ToString();
                listaTorneo.Add(torneo);
            }

            var listaTorneoJson = JsonConvert.SerializeObject(listaTorneo);
            return listaTorneoJson;
        }

        public static int ObtenerIdTorneo(string nombre)
        {
            Torneo torneo = new Torneo();
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "SELECT * from torneos WHERE nomTorneo = @nombre";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                torneo.IdTorneo = int.Parse(reader["idTorneo"].ToString());
            }

            return torneo.IdTorneo;
        }

        public static void ActualizarTorneo(int id, string nomNuevo)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();
            conexion.Open();

            string sql =
                "UPDATE torneos SET nomTorneo = @nomNuevo WHERE idTorneo = @id; ";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nomNuevo", nomNuevo);
            comando.Parameters.AddWithValue("@id", id);
            reader = comando.ExecuteReader();

        }

        public static string EliminarTorneo(int id)
        {
            string respuesta = null;
            MySqlDataReader reader;
            MySqlConnection conexion = getConexion();

            try
            {
                conexion.Open();

                string sql =
                    "DELETE FROM torneos WHERE idTorneo = @id; ";

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@id", id);
                reader = comando.ExecuteReader();
            }
            catch (Exception e)
            {
                respuesta = e.ToString();
            }

            return respuesta;
        }

        public static string CrearTorneo(string nombre)
        {
            string respuesta = null;
            MySqlConnection conexion = getConexion();

            try
            {
                conexion.Open();

                string sql =
                    "INSERT INTO torneos (nomTorneo) VALUES(@nombre)";

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);

                Console.WriteLine(comando.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                respuesta = e.ToString();
            }

            return respuesta;
        }

    }
}
