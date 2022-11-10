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
        Usuario usuarioSeleccionado = new Usuario();
        APIautenticacion apiAuth = new APIautenticacion();
        public GestorUsuarios()
        {
            InitializeComponent();
        }

        private void CargarCboUsuarios(ListBox list)
        {
            List<Usuario> listaUsuarios = apiAuth.ListaUsuarios();

            foreach (Usuario user in listaUsuarios)
            {
                usuarioSeleccionado = new Usuario();
                list.Items.Add(user.Email);
            }
        }

        private void GestorUsuarios_Load(object sender, EventArgs e)
        {
            lblUsuario.Visible = false;

            CargarCboUsuarios(listBox);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUsuario.Visible = true;
            usuarioSeleccionado = apiAuth.obtenerUsuario(listBox.SelectedItem.ToString());
            lblUsuario.Text = usuarioSeleccionado.IdUsuario.ToString();
            txtEmail.Text = usuarioSeleccionado.Email;
            txtNombre.Text = usuarioSeleccionado.NomUsuario;

            int tipoUsuario = usuarioSeleccionado.IdTipoUsuario;
            cboTipoUsuario.SelectedIndex = tipoUsuario - 1;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            usuarioSeleccionado.IdTipoUsuario = cboTipoUsuario.SelectedIndex + 1;
            usuarioSeleccionado.NomUsuario = txtNombre.Text;
            usuarioSeleccionado.Email = txtEmail.Text;

            string respuesta = apiAuth.ActualizarUsuario(usuarioSeleccionado);

            if (string.IsNullOrEmpty(respuesta))
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Actualizado con exito");
                        break;
                    case 2:
                        MessageBox.Show("Updated succesfully");
                        break;
                }
                this.Controls.Clear();
                InitializeComponent();
                CargarCboUsuarios(listBox);
            }
            else
            {
                MessageBox.Show(respuesta);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res;
            switch (Sesion.idIdioma)
            {
                case 1:
                    res = MessageBox.Show("Seguro desdeas eliminar a " + usuarioSeleccionado.NomUsuario + "?", "Eliminar Usuario",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.No)
                    {

                    }
                    else
                    {
                        apiAuth.EliminarUsuario(usuarioSeleccionado.IdUsuario, usuarioSeleccionado.IdTipoUsuario);
                        MessageBox.Show("Usuario correctamete eliminado", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Controls.Clear();
                        InitializeComponent();
                        CargarCboUsuarios(listBox);

                    }
                    break;
                case 2:
                    res = MessageBox.Show("Are you sure you want to delete " + usuarioSeleccionado.NomUsuario +"?", "Delete user",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.No)
                    {

                    }
                    else
                    {
                        apiAuth.EliminarUsuario(usuarioSeleccionado.IdUsuario, usuarioSeleccionado.IdTipoUsuario);
                        MessageBox.Show("User deleted succesfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Controls.Clear();
                        InitializeComponent();
                        CargarCboUsuarios(listBox);
                    }
                    break;
            }
            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            CargarCboUsuarios(listBox);
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario user;
            user = apiAuth.obtenerUsuario(txtBuscar.Text);
            if (user == null)
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("No se encontro un usuario para este correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                    case 2:
                        MessageBox.Show("We have not found a user for that email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                }
            }
            else
            {
                listBox.Items.Clear();
                listBox.Items.Add(user.Email);
            }
        }
    }
}
