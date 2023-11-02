using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Graph;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoweb2
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            Alert.Text = "";
            string user = usuario.Text;
            string email = correo.Text;
            string pass = password.Text;
            string pass2 = password2.Text;

            if (user == "" || user == null || email == "" || email == null || pass == "" || pass == null || pass2 == "" || pass2 == null)
            {
                Alert.Text = "Ningún campo puede quedar vacio.";
            }else{
                if (pass != pass2)
                {
                    Alert.Text = "Las contraseñas no coinciden.";
                }
                else
                {
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string usuario = string.Empty, query;

                        connection.Open();

                        query = "SELECT * FROM usuarios where usuario = '" + user + "'";

                        new OleDbCommand(query, connection);

                        OleDbCommand comando = new OleDbCommand(query, connection);

                        OleDbDataReader reader = comando.ExecuteReader();

                        while (reader.Read()) { usuario = reader.GetString(2); }

                       if (usuario == user)
                        {
                            connection.Close();
                            Alert.Text = "El usuario ya existe en la base de datos.";
                        }
                        else
                        {
                            query = "INSERT INTO USUARIOS (mail, usuario, contraseña) VALUES ('" + email + "','" + user + "','" + pass + "');";

                            new OleDbCommand(query, connection);

                            OleDbCommand comando2 = new OleDbCommand(query, connection);

                            int execute = comando2.ExecuteNonQuery(); /* Devuelve el numero de filas (debe ser entero)*/

                            connection.Close();

                            Response.Redirect("Signin.aspx");
                        }
                    }
                }
            }
        }
        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signin.aspx");
        }

        protected void CbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CbPass.Checked)
            {

                password.TextMode = TextBoxMode.SingleLine;
                password2.TextMode = TextBoxMode.SingleLine;
            }
            else
            {
                password.TextMode = TextBoxMode.Password;
                password2.TextMode = TextBoxMode.Password;
            }
        }
    }
}



