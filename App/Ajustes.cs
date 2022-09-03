using System;
using App.UserControlAjustes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Perfil ucPerfil = new Perfil();
            addUserControl(ucPerfil);
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            Notificaciones ucNotificaciones = new Notificaciones();
            addUserControl(ucNotificaciones);
        }

        private void Ajustes_Load(object sender, EventArgs e)
        {
            Perfil ucPerfil = new Perfil();
            addUserControl(ucPerfil);
        }
    }
}
