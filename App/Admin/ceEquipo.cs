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
    public partial class ceEquipo : UserControl
    {
        static string rutaImagen;
        static Equipo equipoBusqueda;
        APIresultados apiResultados = new APIresultados();
        public ceEquipo()
        {
            InitializeComponent();
        }

        private void CargarDeportes()
        {
            List<Deporte> listaDeporte;
            listaDeporte = apiResultados.CargarDeportes();
            foreach (Deporte dep in listaDeporte)
            {
                cboDeporte.Items.Add(dep.NomDeporte);
                cboDeporteEquipo.Items.Add(dep.NomDeporte);
            }
        }

        private void CargarCboPaises()
        {
            List<string> listaPaises;
            listaPaises = Program.CargarPaises();
            foreach (string pais in listaPaises)
            {
                cboPaisEquipo.Items.Add(pais);
                cboPais.Items.Add(pais);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.NomEquipo = txtNombre.Text;
            int idDeporte = apiResultados.ObtenerIdDeporte(equipo.NomEquipo);
            equipo.IdDeporte = idDeporte;
            equipo.IdPais = Program.ObtenerIdPais(cboPais.SelectedItem.ToString());

            if (string.IsNullOrEmpty(equipo.NomEquipo) || equipo.IdPais == 0)
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Debe escribir el nombre y seleccinar un Pais para poder buscar");
                        break;
                    case 2:
                        MessageBox.Show("You must write a name and choose a Country for searching");
                        break;
                }
            }
            else
            {
                equipoBusqueda = apiResultados.CargarEquipoFiltro(equipo.NomEquipo, equipo.IdPais);
                if (equipoBusqueda == null)
                {
                    switch (Sesion.idIdioma)
                    {
                        case 1:
                            MessageBox.Show("No se encontro un equipo para los datos ingredados," +
                                "\nrevisa tu informacion o crea uno aqui abajo");
                            break;
                        case 2:
                            MessageBox.Show("we couden't find a team for the data entered," +
                                "\ncheck your data or create one down below");
                            break;
                    }
                }
                else
                {
                    lblIdEquipo.Text = equipoBusqueda.IdEquipo.ToString();
                    txtNombreEquipo.Text = equipoBusqueda.NomEquipo;
                    txtNombreDT.Text = equipoBusqueda.NomDt;
                    txtApellidoDT.Text = equipoBusqueda.ApeDt;
                    picBannerPreview.Image = Imagenes.ObtenerImagen(equipoBusqueda.RutaEscudo);
                    rutaImagen = equipoBusqueda.RutaEscudo;
                    cboPaisEquipo.SelectedIndex = equipoBusqueda.IdPais - 1;
                    cboDeporteEquipo.SelectedIndex = cboDeporte.SelectedIndex;
                    cboPais.SelectedIndex = cboPaisEquipo.SelectedIndex;
                    chboxSeleccion.Checked = equipoBusqueda.EsSeleccion;

                }
            }


        }

        private void ceEquipo_Load(object sender, EventArgs e)
        {
            CargarCboPaises();
            CargarDeportes();
        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            rutaImagen = Imagenes.GuardarImagen();
            MessageBox.Show(rutaImagen);
            Image imagen = Imagenes.ObtenerImagen(rutaImagen);
            if(imagen != null)
            {
                picBannerPreview.Image = imagen;
            }
            

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.NomEquipo = txtNombreEquipo.Text;
            equipo.NomDt = txtNombreDT.Text;
            equipo.ApeDt = txtApellidoDT.Text;
            equipo.RutaEscudo = rutaImagen;
            equipo.EsSeleccion = chboxSeleccion.Checked;
            equipo.IdDeporte = apiResultados.ObtenerIdDeporte(cboDeporteEquipo.Text);
            equipo.IdPais = Program.ObtenerIdPais(cboPaisEquipo.SelectedItem.ToString());

            string respuesta = apiResultados.CrearEquipo(equipo);
            if (string.IsNullOrEmpty(respuesta))
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Se creo correctamente", "Listo");
                        this.Controls.Clear();
                        InitializeComponent();
                        CargarCboPaises();
                        CargarDeportes();

                        break;
                    case 2:
                        MessageBox.Show("It was created succesfuly", "Done");
                        this.Controls.Clear();
                        InitializeComponent();
                        CargarCboPaises();
                        CargarDeportes();
                        break;
                }
            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("No se puedo crear, asegurate de haber ingresado todos los datos");
                        break;
                    case 2:
                        MessageBox.Show("It coudn't be created, make sure you entered all data");
                        break;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Equipo equipoActua = new Equipo();
            equipoActua.NomEquipo = txtNombreEquipo.Text;
            equipoActua.NomDt = txtNombreDT.Text;
            equipoActua.ApeDt = txtApellidoDT.Text;
            equipoActua.RutaEscudo = rutaImagen;
            equipoActua.EsSeleccion = chboxSeleccion.Checked;
            equipoActua.IdDeporte = apiResultados.ObtenerIdDeporte(cboDeporteEquipo.Text);
            equipoActua.IdPais = Program.ObtenerIdPais(cboPaisEquipo.SelectedItem.ToString());

            string respuesta = apiResultados.ActualizarEquipo(equipoActua);
            if (string.IsNullOrEmpty(respuesta))
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Se actualizo correctamente", "Listo");
                        this.Controls.Clear();
                        InitializeComponent();
                        CargarCboPaises();
                        CargarDeportes();

                        break;
                    case 2:
                        MessageBox.Show("It was updated succesfuly", "Done");
                        this.Controls.Clear();
                        InitializeComponent();
                        CargarCboPaises();
                        CargarDeportes();
                        break;
                }
            }
            else
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("No se puedo actualizar, asegurate de haber ingresado todos los datos");
                        break;
                    case 2:
                        MessageBox.Show("It coudn't be updated, make sure you entered all data");
                        break;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string respuesta = apiResultados.EliminarEquipo(equipoBusqueda.IdEquipo);
            if (string.IsNullOrEmpty(respuesta))
            {
                switch (Sesion.idIdioma)
                {
                    case 1:
                        MessageBox.Show("Se elimino correctamente", "Listo");
                        this.Controls.Clear();
                        InitializeComponent();
                        CargarCboPaises();
                        CargarDeportes();

                        break;
                    case 2:
                        MessageBox.Show("It was deleted succesfuly", "Done");
                        this.Controls.Clear();
                        InitializeComponent();
                        CargarCboPaises();
                        CargarDeportes();
                        break;
                }
            }
        }
    }
}
