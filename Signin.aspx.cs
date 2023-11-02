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

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
        protected void CbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CbPass.Checked){ 
            
                password.TextMode = TextBoxMode.SingleLine;
            }
            else
            {
                password.TextMode = TextBoxMode.Password;
            }
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

            if (user.Text == "" || user.Text == null || password.Text == "" || password.Text == null)
            {
                Alert.Text = "Ningún campo puede quedar vacio.";
            }
            else
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string usuario = string.Empty, query, query2;
                    int id = 0;

                    connection.Open();

                    query = "SELECT * FROM usuarios where usuario = '" + user.Text + "' and contraseña = '" + password.Text + "'";

                    new OleDbCommand(query, connection);

                    OleDbCommand comando = new OleDbCommand(query, connection);

                    OleDbDataReader reader = comando.ExecuteReader();

                    while (reader.Read()) {
                        usuario = reader.GetString(2);
                        id = reader.GetInt32(0);}

                    if (!String.IsNullOrEmpty(usuario))
                    {
                        /*Hístórico de conexiones*/

                        query2 = "INSERT INTO login (id_user, nombre_usuario, conexion) values ('" + id + "', '" + usuario + "', Date());";

                        new OleDbCommand(query2, connection);

                        OleDbCommand comando2 = new OleDbCommand(query2, connection);

                        int execute3 = comando2.ExecuteNonQuery(); 

                        connection.Close();

                        Response.Redirect("Inicio.aspx?user=" + usuario); /*Se lleva el contenido de usuario*/

                    }
                    else
                    {
                        Alert.Text = "Usuario sin registrar o datos incorrectos.";
                    }
                }
            }
        }
    }
}
