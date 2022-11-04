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
using CapaDatos;

namespace App.Admin
{
    public partial class GestorUsuarios : UserControl
    {
        Usuario usuarioSeleccionado;
        public GestorUsuarios()
        {
            InitializeComponent();
        }

        private void GestorUsuarios_Load(object sender, EventArgs e)
        {
            APIautenticacion api = new APIautenticacion();
            List<Usuario> listaUsuarios = api.ListaUsuarios();
            
            foreach(Usuario user in listaUsuarios)
            {
                usuarioSeleccionado = new Usuario();
                listBox.Items.Add(user.Email);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            usuarioSeleccionado = listBox.SelectedItem as Usuario;
            lblUsuario.Text = usuarioSeleccionado.IdUsuario.ToString();
            txtEmail.Text = usuarioSeleccionado.Email;
            txtNombre.Text = usuarioSeleccionado.NomUsuario;
        }
    }
}
