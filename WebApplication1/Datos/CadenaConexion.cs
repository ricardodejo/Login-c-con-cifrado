using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace WebApplication1.Datos
{
    public class CadenaConexion
    {
        public string Conexion()
        {
            string cadena = "Data Source=user\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True";
            return cadena; 
        }

    }
}