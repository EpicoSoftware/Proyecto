using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaLogica;
using Newtonsoft.Json;

namespace CapaLogica
{
    public class APIresultados
    {
        public DataTable CargarDeportes()
        {
            DataTable dataTable = new DataTable();
            dataTable = Modelos.obtenerDeportes();
            return dataTable;
        }
        

    }
}
