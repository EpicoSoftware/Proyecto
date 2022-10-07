using App.UserControlAdmin;
using CapaDatos;
using CapaLogica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class AdminApp : Form
    {
        public AdminApp()
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

      

        private void btnAbrirApp_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Visible = true;
            this.Visible = false;
        }
        

        private void btnAnuncios_Click(object sender, EventArgs e)
        {
            UserControl gAnuncios = new GestorAnuncios();
            agregarUserControl(gAnuncios);
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEncuentros_Click(object sender, EventArgs e)
        {
            UserControl encuentro = new Encuentros();
            agregarUserControl(encuentro);
        }
    }
}