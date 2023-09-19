using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace proyectoweb2
{
    public partial class Signin : System.Web.UI.Page
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            /*Conexión  Piloto

            try
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Conectado satisfactoriamente a la base de datos.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sin Conectar.");
                MessageBox.Show("Cancelando ejecución.");
            }*/
        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {
            /*LOCAL*/

            /*string usuario, pass;

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
                }*/

            /*Con Access*/

            Alert.Text = "";

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string usuario = string.Empty, query;

                connection.Open();

                query = "SELECT * FROM usuarios where usuario = '" + user.Text +"' and contraseña = '" + password.Text +"'";

                new OleDbCommand(query, connection);

                OleDbCommand comando = new OleDbCommand(query, connection);

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read()){ usuario = reader.GetString(4); }

                if (!String.IsNullOrEmpty(usuario))
                {
                    connection.Close();
                    Response.Redirect("Inicio.aspx");
                }
                else
                {
                    Alert.Text = "Usario sin registrar o datos incorrectos.";
                }
            }
            
        }
        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
    }
