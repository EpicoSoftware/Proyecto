using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace App.UserControlAdmin
{
    public partial class Deportes : UserControl
    {
        public Deportes()
        {
            InitializeComponent();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deportes_Load(object sender, EventArgs e)
        {
            APIresultados resultados = new APIresultados();
            DataTable dt = new DataTable();
            dt = resultados.CargarDeportes();
            tablaDeportes.DataSource = dt;
        }
    }
}
