using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Admin
{
    public partial class CrearEncuentro : Form
    {
        public static int tipoEncuentro;
        public CrearEncuentro()
        {
            InitializeComponent();
        }

        private void agregarUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void CrearEncuentroEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnDeporte_Click(object sender, EventArgs e)
        {
            ceDeporte uc = new ceDeporte();
            agregarUserControl(uc);
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            ceTorneo uc = new ceTorneo();
            agregarUserControl(uc);
        }

        private void btnJugador_Click(object sender, EventArgs e)
        {
            ceJugador uc = new ceJugador();
            agregarUserControl(uc);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            cePanelCreacion uc = new cePanelCreacion();
            uc.TipoEncuentro = 1;
            agregarUserControl(uc);
        }
    }
}
