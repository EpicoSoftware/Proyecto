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

        private int _idTorneo, _idEncuentro, _idDeporte, _idEstado;
        private string _nomArbitro, _apeArbitro, _nomEstadio, _fecha;

        [Category("Custom Props")]
        public string NomArbitro
        {
            get { return _nomArbitro; }
            set { _nomArbitro = value; }
        }






        #endregion

        private void EncuetroEquipo_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {

        }
    }
}
