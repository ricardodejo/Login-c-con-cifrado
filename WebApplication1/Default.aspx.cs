using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Datos;
using WebApplication1.Negocio;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            LoginD login = new LoginD();
            int count = login.Logeo(txt1.Text, txt2.Text);
            if (count > 0)
            {
                Response.Write("<script>alert('login success');</script>");
            }
            else
            {
                Response.Write("<script>alert('login error');</script>");
            }
        }

        
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Cifrar cifrar = new Cifrar();
            string textoCifrado = cifrar.CifrarBien(txt3.Text); 
            txt4.Text = textoCifrado;

        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {

        }

        protected void txt4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}