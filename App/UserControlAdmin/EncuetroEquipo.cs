using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UserControlAdmin
{
    public partial class EncuetroEquipo : UserControl
    {
        public EncuetroEquipo()
        {
            InitializeComponent();
        }

        #region Propiedades
        
        private int idTorneo, idEncuentro, idDeporte, idEstado;
        private string nomArbitro, apeArbitro, nomEstadio, fecha;

        public int IdTorneo { get => idTorneo; set => idTorneo = value; }
        public int IdEncuentro { get => idEncuentro; set => idEncuentro = value; }
        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string NomArbitro { get => nomArbitro; set => nomArbitro = value; }
        public string ApeArbitro { get => apeArbitro; set => apeArbitro = value; }
        public string NomEstadio { get => nomEstadio; set => nomEstadio = value; }
        public string Fecha { get => fecha; set => fecha = value; }

        #endregion

        private void EncuetroEquipo_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {

        }
    }
}
