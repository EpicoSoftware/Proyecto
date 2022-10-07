using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaLogica;

namespace App.UserControlAdmin
{
    public partial class Encuentros : UserControl
    {
        public Encuentros()
        {
            InitializeComponent();
        }

        private void Encuentros_Load(object sender, EventArgs e)
        {

        }

        private void CargarEncuentrosVivo()
        {
            List<Encuentro> listaEncuentros = new List<Encuentro>();
            List<EncuetroEquipo> listaElementos = new List<EncuetroEquipo>();
            APIresultados APIresu = new APIresultados();
            listaEncuentros = APIresu.CargarListaVivo(2);

            foreach (Encuentro ad in listaEncuentros)
            {
                EncuetroEquipo enEqui = new EncuetroEquipo();
                
                flpVivo.Controls.Add(anuncio);
            }
        }
    }
}
