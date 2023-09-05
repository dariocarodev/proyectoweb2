using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Windows.Forms;


namespace proyectoweb2
{
    public partial class Signin : System.Web.UI.Page
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {
            string usuario, pass;

            usuario = user.Text;
            pass = password.Text;


            if (usuario == "" || usuario == null || pass == "" || pass == null)
                {

                MessageBox.Show("Ningún campo puede quedar vacio.");

            }
            else
                {
                    if (usuario == "admin" || pass  == "admin")
                    {

                    Response.Redirect("Inicio.aspx");

                }
                else
                    {
                    MessageBox.Show("Usuario o contraseña incorrecta.");
                    }
                }
            }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
    }
