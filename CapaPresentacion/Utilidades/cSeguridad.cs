using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace AsignacionServicios.Utilidades
{
    public static class cSeguridad
    {
        static string key = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string Encrypt(string text)
        {
            //arreglo de bytes donde guardaremos la llave
            byte[] keyArray;
            //arreglo de bytes donde guardaremos el texto
            //que vamos a encriptar
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(text);

            //se utilizan las clases de encriptación
            //provistas por el Framework
            //Algoritmo MD5
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            //se guarda la llave para que se le realice
            //hashing
            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            //Algoritmo 3DAS
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            //se empieza con la transformación de la cadena
            ICryptoTransform cTransform =
            tdes.CreateEncryptor();

            //arreglo de bytes donde se guarda la
            //cadena cifrada
            byte[] ArrayResultado =
            cTransform.TransformFinalBlock(Arreglo_a_Cifrar,
            0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            //se regresa el resultado en forma de una cadena
            return Convert.ToBase64String(ArrayResultado,
            0, ArrayResultado.Length);
        }
        public static string Decrypt(string text)
        {
            byte[] keyArray;
            //convierte el texto en una secuencia de bytes
            byte[] Array_a_Descifrar = Convert.FromBase64String(text);

            //se llama a las clases que tienen los algoritmos
            //de encriptación se le aplica hashing
            //algoritmo MD5
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform =
            tdes.CreateDecryptor();

            byte[] resultArray =
            cTransform.TransformFinalBlock(Array_a_Descifrar,
            0, Array_a_Descifrar.Length);

            tdes.Clear();
            //se regresa en forma de cadena
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        public static string[] read(string nombreArchivo)
        {
            string linea = File.ReadAllText(nombreArchivo);
            linea = linea.Remove(linea.Length - 1);
            string[] lineas = linea.Split(';');
            return lineas;
        }
        public static void GuardarTxt(List<string> datos, string nombreArchivo)
        {
            /*datos[0] = cSeguridad.Encrypt(datos[0].Trim());
            datos[1] = cSeguridad.Encrypt(datos[1].Trim());
            using (StreamWriter sw = File.CreateText(nombreArchivo))
            {
                sw.Write(datos[0] + ";");
                sw.Write(datos[1] + ";");
            }*/
            using (StreamWriter sw = File.CreateText(nombreArchivo))
            {
                for (int i = 0; i < datos.Count; i++)
                {
                    string dato = cSeguridad.Encrypt(datos[i].Trim());
                    sw.Write(dato + ";");
                }
            }
        }
        public static void GuardarTxtVacio(string nombreArchivo)
        {
            using (StreamWriter sw = File.CreateText(nombreArchivo))
            {
                sw.Write(";");
                sw.Write(";");
            }
        }
    }
}
