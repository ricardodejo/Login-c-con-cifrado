using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebApplication1.Negocio
{
    public class Cifrar
    {
        public string CifrarBien (string pass)
        {
            string pass1 = "";

            SHA256 sha256 = SHA256Managed.Create();
            byte[] hashValue;
            UTF8Encoding objUtf8 = new UTF8Encoding();
            hashValue = sha256.ComputeHash(objUtf8.GetBytes(pass));

            // Convertimos el hash a una cadena hexadecimal
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashValue)
            {
                sb.Append(b.ToString("x2")); // "x2" convierte el byte a hexadecimal
            }

            pass1 = sb.ToString();
            return pass1;
        }

    }
}