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
    public partial class ceDeporte : UserControl
    {
        public int idDeporte;
        public string nomDeporte;
        public APIresultados api = new APIresultados();

        public ceDeporte()
        {
            InitializeComponent();
        }

        void Alerta(Color color, string titulo, string descripcion)
        {
            Alerta alerta = new Alerta();
            alerta.ColorAlerta = color;
            alerta.TituloAlerta = titulo;
            alerta.DescripcionAlerta = descripcion;
            alerta.ShowDialog();
        }

        private void ceDeporte_Load(object sender, EventArgs e)
        {
            CargarCbo(cboDepotes);
        }

        private void CargarCbo(ComboBox cboDeportes)
        {
            List<Deporte> listaDeportes = new List<Deporte>();
            listaDeportes = api.CargarDeportes();
            foreach (Deporte dep in listaDeportes)
            {
                cboDepotes.Items.Add(dep.NomDeporte);
            }
        }

        private void cboDepotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomDeporte = cboDepotes.SelectedItem.ToString();
            idDeporte = api.ObtenerIdDeporte(nomDeporte);

            txtIdDeporte.Text = idDeporte.ToString();
            txtNombre.Text = nomDeporte;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nomDeporte = txtNombre.Text;
            api.ActualizarDeporte(idDeporte, nomDeporte);
            switch (Sesion.idIdioma)
            {
                case 1:
                    Alerta(Color.Green, "Hecho", "Se actualizo correctamente.");
                    break;
                case 2:
                    Alerta(Color.Green, "Done", "The sport was updated successfully.");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
            CargarCbo(cboDepotes);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string respuesta = api.EliminarDeporte(idDeporte);
            if (string.IsNullOrEmpty(respuesta))
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        Alerta(Color.Green, "Hecho", "Se elimino correctamente");
                        break;
                    case 2:
                        Alerta(Color.Green, "Done", "It was deleted succesfully");
                        break;
                }
                this.Controls.Clear();
                InitializeComponent();
                CargarCbo(cboDepotes);

            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        Alerta(Color.Red, "Error", respuesta);
                        break;
                    case 2:
                        Alerta(Color.Red, "Error", respuesta);
                        break;
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string respuesta;
            respuesta = api.CrearDeporte(txtNombre.Text);
            if (string.IsNullOrEmpty(respuesta))
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        Alerta(Color.Green, "Hecho", "Se creo correctamente");
                        break;
                    case 2:
                        Alerta(Color.Green, "Done", "It was created succesfully");
                        break;
                }
                this.Controls.Clear();
                InitializeComponent();
                CargarCbo(cboDepotes);

            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        Alerta(Color.Red, "Error", respuesta);
                        break;
                    case 2:
                        Alerta(Color.Red, "Error", respuesta);
                        break;
                }
            }
        }
    }
}
