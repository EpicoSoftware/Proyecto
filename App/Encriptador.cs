using CapaDatos;
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
    public partial class Encriptador : Form
    {
        public Encriptador()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            EncriptarMD5 md5 = new EncriptarMD5();
            txtResultado.Text = md5.Encriptar(txtEntrada.Text);
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            EncriptarMD5 md5 = new EncriptarMD5();
            txtResultado.Text = md5.Desencriptar(txtEntrada.Text);
        }
    }
}
