using CapaDatos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<string> CargarPaises()
        {
            string listaJSON;
            List<string> listaPaises;
            listaJSON = Modelos.CargarPaises();
            listaPaises = JsonConvert.DeserializeObject<List<string>>(listaJSON);
            return listaPaises;
        }

        public static int ObtenerIdPais(string nomPais)
        {
            int id = Modelos.ObtenerIdPais(nomPais);
            return id;
        }

        private static int idioma;
        public static int Idioma { get => idioma; set => idioma = value; }

        [STAThread]
        static void Main()
         {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminApp());
        }
    }
}
