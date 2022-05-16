using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Documental2
{
    public static class Cifrado
    {
        public static void crearXMLclaves(string ficPruebas)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            string xmlKey = rsa.ToXmlString(true);

            // Si no existe el directorio, crearlo
            string dirPruebas = Path.GetDirectoryName(ficPruebas);

            if (Directory.Exists(dirPruebas) == false)
            {
                Directory.CreateDirectory(dirPruebas);
            }

            using (StreamWriter sw = new StreamWriter(ficPruebas, false, Encoding.UTF8))
            {
                sw.WriteLine(xmlKey);
                sw.Close();
            }
        }

        public static string clavesXML(string fichero)
        {
            string s;

            using (StreamReader sr = new StreamReader(fichero, Encoding.UTF8))
            {
                s = sr.ReadToEnd();
                sr.Close();
            }

            return s;
        }

        public static byte[] cifrar(string texto, string xmlKeys)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            rsa.FromXmlString(xmlKeys);

            byte[] datosEnc = rsa.Encrypt(Encoding.Default.GetBytes(texto), false);

            return datosEnc;
        }

        public static string descifrar(byte[] datosEnc, string xmlKeys)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

                rsa.FromXmlString(xmlKeys);

                byte[] datos = rsa.Decrypt(datosEnc, false);

                string res = Encoding.Default.GetString(datos);

                return res;

            }
            catch (Exception ex)
            {
                return "Error";
            }
        }
    }


}
