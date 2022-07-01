using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace CapaDatos
{
    public class EncriptarMD5
    {
        public string Encriptar(string mensaje)
        {
            string hash = "sobre las cartas;";
            byte[] data = UTF32Encoding.UTF8.GetBytes(mensaje);
            MD5 md5 = MD5.Create();
            TripleDES tripldes = TripleDES.Create();

            tripldes.Key = md5.ComputeHash(UTF32Encoding.UTF8.GetBytes(hash));
            tripldes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripldes.CreateEncryptor();
            byte[] resultado = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(resultado);
        }

        public string Desencriptar(string mensajeEn)
        {
            string hash = "sobre las cartas;";
            byte[] data = Convert.FromBase64String(mensajeEn);
            MD5 md5 = MD5.Create();
            TripleDES tripldes = TripleDES.Create();

            tripldes.Key = md5.ComputeHash(UTF32Encoding.UTF8.GetBytes(hash));
            tripldes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripldes.CreateDecryptor();
            byte[] resultado = transform.TransformFinalBlock(data, 0, data.Length);
            return UTF32Encoding.UTF8.GetString(resultado);
        }


    }
}
