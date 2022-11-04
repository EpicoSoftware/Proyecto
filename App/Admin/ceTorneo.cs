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

namespace App.Admin
{
    public partial class ceTorneo : UserControl
    {
        public int idTorneo;
        public string nomTorneo;
        public APIresultados api = new APIresultados();
        public ceTorneo()
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

        private void ceTorneo_Load(object sender, EventArgs e)
        {
            CargarCbo(cboTorneos);
        }

        private void CargarCbo(ComboBox cbo)
        {
            List<Torneo> listaTorneo = new List<Torneo>();
            listaTorneo = api.CargarTorneos();
            foreach (Torneo tor in listaTorneo)
            {
                cbo.Items.Add(tor.NomTorneo);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string respuesta = api.EliminarTorneo(idTorneo);
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
                CargarCbo(cboTorneos);

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

        private void cboTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomTorneo = cboTorneos.SelectedItem.ToString();
            idTorneo = api.ObtenerIdTorneo(nomTorneo);

            txtId.Text = idTorneo.ToString();
            txtNombre.Text = nomTorneo;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nomTorneo = txtNombre.Text;
            api.ActulizarTorneo(idTorneo, nomTorneo);
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
            CargarCbo(cboTorneos);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string respuesta;
            respuesta = api.CrearTorneo(txtNombre.Text);
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
                CargarCbo(cboTorneos);

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
