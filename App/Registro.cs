using CapaDatos;
using CapaLogica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Registro : Form
    {
        public static string GetCountryByIP()
        {
            

            IpInfo ipInfo = new IpInfo();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io/");
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
                RegionInfo myRI1 = new RegionInfo(ipInfo.Country);
                ipInfo.Country = myRI1.EnglishName;
            }
            catch (Exception)
            {
                ipInfo.Country = null;
            }

            return ipInfo.Country;
        }



        public string ObtenerPais(){
            StringBuilder sb = new StringBuilder();
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                sb.Append(ci.DisplayName);
                sb.AppendLine();
            }
           return sb.ToString();
            
        }
        
        APIautenticacion auth = new APIautenticacion();
        public Registro()
        {
            InitializeComponent();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string respuesta;
            
            
            
            if (txtPassword.Text != txtConfirmarPassword.Text)
            {
                MessageBox.Show("Error", "Las contraseñas no coindicen");
            }
            else
            {
                EncriptarMD5 md5 = new EncriptarMD5();
                string passwordEncriptada = md5.Encriptar(txtPassword.Text);
                Usuario user = new Usuario();

                user.Correo = txtCorreo.Text;
                user.Nombre = txtNombre.Text;
                user.IdColorMode = 1; //Color por defecto de la App
                user.IdPais = Modelos.ObtenerId(GetCountryByIP(), "paises", "nombre");

                //Serializa JSON para enviarlo al metodo Registro de la clase APIautenticacion
                var usuarioJson = JsonConvert.SerializeObject(user);
                respuesta = auth.Registro(usuarioJson, passwordEncriptada);

                if (string.IsNullOrEmpty(respuesta)) //Si respuesta tiene algun valor significa que dio un error
                {
                    this.Visible = false;
                    App appGratis = new App();
                    appGratis.Visible = true;
                }
                else
                {
                    MessageBox.Show(respuesta);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

    }
}
