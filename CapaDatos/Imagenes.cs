using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Imagenes
    {
        public static Image imagen;
        public static Bitmap imagenBitmap;
        public static byte[] imagenByte;

        public static Image ByteToImagen(byte[] arregloByte)
        {
            byte[] img = arregloByte;
            MemoryStream ms = new MemoryStream(img);
            Image convertida = Image.FromStream(ms);
            return convertida;
        }

        public static byte[] SubirImagen(PictureBox imagenPreview)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            DialogResult re = ofd.ShowDialog();
            if (re == DialogResult.OK)
            {
                imagen = Image.FromFile(ofd.FileName);
                imagenBitmap = (Bitmap)imagen;
                imagenPreview.Image = imagenBitmap;
                var ms = new MemoryStream();
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                imagenByte = ms.ToArray();

            }
            return imagenByte;
        }

        public static string GuardarImagen()
        {
            string ruta = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            DialogResult re = ofd.ShowDialog();
            if (re == DialogResult.OK)
            {
                string filename = ofd.FileName;
                string file = Path.GetFileName(ofd.FileName);
                string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

                ruta = path + "\\imagenes\\" + file;

                if (File.Exists(ruta))
                {

                }
                else
                {
                    try
                    {
                        File.Copy(filename, ruta);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                    
                }
                
                
            }
            return ruta;
        }

        public static Image ObtenerImagen(string ruta)
        {
            Image imagen = Image.FromFile(ruta);
            return imagen;
        }

        public static void EliminarImagen(string ruta)
        {
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }
        }
    }
}
