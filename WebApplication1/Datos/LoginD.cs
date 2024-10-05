using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Datos
{
    public class LoginD
    {
        public int Logeo (string usernanme, string password)
        {
            CadenaConexion cad= new CadenaConexion();
            string cadena = cad.Conexion();
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            string loginQuery = "SELECT COUNT(*) FROM login WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(loginQuery, con);
            cmd.Parameters.AddWithValue("@username", usernanme);
            cmd.Parameters.AddWithValue("@password", password);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count; 
        }
    }
}