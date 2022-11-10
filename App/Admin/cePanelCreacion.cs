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

namespace App.Admin
{
    public partial class cePanelCreacion : UserControl
    {
        private int _tipoEncuentro;

        public cePanelCreacion()
        {
            InitializeComponent();
        }
        
        public int TipoEncuentro
        {
            get { return _tipoEncuentro; }
            set { _tipoEncuentro = value; }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void cePanelCreacion_Load(object sender, EventArgs e)
        {
            switch (_tipoEncuentro)
            {
                case 1:
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            lbl1.Text = "Juagador 1";
                            break;
                        case 2:
                            lbl1.Text = "Player 1";
                            break;
                    }
                    break;
                case 2:
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            lbl1.Text = "Juagador 2";
                            break;
                        case 2:
                            lbl1.Text = "Player 2";
                            break;
                    }
                    break;

            }
        }

        private void btnAgragarJugadores1_Click(object sender, EventArgs e)
        {
            AgreJugadoresEn agreJuga = new AgreJugadoresEn();
            agreJuga.Visible = true;
        }
    }
}
