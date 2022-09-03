using System;
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
    public partial class Alerta : Form
    {
        public Alerta()
        {
            InitializeComponent();
        }
        public Color ColorAlerta
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public string TituloAlerta
        {
            get { return lblTexto.Text; }
            set { lblTexto.Text = value; }
        }

        public string DescripcionAlerta
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
