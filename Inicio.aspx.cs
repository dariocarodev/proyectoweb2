using System;
using System.Data;
using System.Data.OleDb;
using System.Web.UI;

namespace proyectoweb2
{
    public partial class Inicio : System.Web.UI.Page
    {
        string ultimaquery = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Obtención de Usuario Activo desde la base

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                if (LabelUser.Text == "" || LabelUser.Text == null)
                {
                    string usuario = string.Empty, query;

                    connection.Open();

                    query = "SELECT TOP 1 * FROM login ORDER BY id DESC;";

                    new OleDbCommand(query, connection);

                    OleDbCommand comando = new OleDbCommand(query, connection);

                    OleDbDataReader reader = comando.ExecuteReader();

                    while (reader.Read()) { usuario = reader.GetString(2); }

                    LabelUser.Text = usuario;

                    connection.Close();
                }
            }*/

            LabelUser.Text = Request.QueryString["user"]; /*Obtención de Usuario Activo desde el Signin*/
        }
        protected void BtnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signin.aspx");
        }
        protected void Buscar_Click(object sender, EventArgs e)

        {
            LDelete.Text = "";

            /*Busqueda por Nombre*/

            if (TxtSearch.Text != "" || TxtSearch.Text != null)
            {
                if (Alchoholicas.Checked != true && NoAlchoholicas.Checked != true) /*Sin filtrar, solo por nombre*/
                {
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        ultimaquery = "SELECT * FROM producto where nombre = '" + TxtSearch.Text + "';";

                        OleDbCommand query = new OleDbCommand(string.Format(ultimaquery), connection);

                        OleDbDataAdapter adaptador = new OleDbDataAdapter(query);

                        DataTable datatable = new DataTable();

                        adaptador.Fill(datatable);

                        Grid.DataSource = datatable;

                        Grid.DataBind();

                        connection.Close();

                    }
                }
                if (Alchoholicas.Checked == true && NoAlchoholicas.Checked != true) /*Buscando por nombre, filtrando alcoholicas*/
                {
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        ultimaquery = "SELECT * FROM producto WHERE nombre = '" + TxtSearch.Text + "' AND categoria_id = 5;";

                        OleDbCommand query = new OleDbCommand(string.Format(ultimaquery), connection);

                        OleDbDataAdapter adaptador = new OleDbDataAdapter(query);

                        DataTable datatable = new DataTable();

                        adaptador.Fill(datatable);

                        Grid.DataSource = datatable;

                        Grid.DataBind();

                        connection.Close();
                    }
                }
                if (Alchoholicas.Checked != true && NoAlchoholicas.Checked == true) /*Buscando por nombre, filtrando no-alcoholicas*/
                {
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        ultimaquery = "SELECT* FROM producto WHERE nombre = '" + TxtSearch.Text + "' AND categoria_id = 1;";

                        OleDbCommand query = new OleDbCommand(string.Format(ultimaquery), connection);

                        OleDbDataAdapter adaptador = new OleDbDataAdapter(query);

                        DataTable datatable = new DataTable();

                        adaptador.Fill(datatable);

                        Grid.DataSource = datatable;

                        Grid.DataBind();

                        connection.Close();
                    }
                }
            }
        }
        protected void Alchoholicas_CheckedChanged(object sender, EventArgs e)

        {
            LDelete.Text = "";

            if (Alchoholicas.Checked == true)
            {
                NoAlchoholicas.Enabled = false;
            }
            else
            {
                NoAlchoholicas.Enabled = true;
            }

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                ultimaquery = "SELECT * FROM producto WHERE categoria_id = 5;";

                OleDbCommand query = new OleDbCommand(string.Format(ultimaquery), connection);

                OleDbDataAdapter adaptador = new OleDbDataAdapter(query);

                DataTable datatable = new DataTable();

                adaptador.Fill(datatable);

                Grid.DataSource = datatable;

                Grid.DataBind();

                connection.Close();
            }

        }
        protected void NoAlchoholicas_CheckedChanged(object sender, EventArgs e)
        {
            LDelete.Text = "";

            if (NoAlchoholicas.Checked == true)
            {
                Alchoholicas.Enabled = false;
            }
            else
            {
                Alchoholicas.Enabled = true;
            }

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                ultimaquery = "SELECT * FROM producto WHERE categoria_id = 1;";

                OleDbCommand query = new OleDbCommand(string.Format(ultimaquery), connection);

                OleDbDataAdapter adaptador = new OleDbDataAdapter(query);

                DataTable datatable = new DataTable();

                adaptador.Fill(datatable);

                Grid.DataSource = datatable;

                Grid.DataBind();

                connection.Close();
            }
        }
        protected void BtnSumar_Click(object sender, EventArgs e)
        {
            LDelete.Text = "";

            if (TxtNombre.Text != "" || TxtDesc.Text != "" || TxtCosto.Text != "" || TxtVenta.Text != "" || TxtStock.Text != "")
            {
                if (DropTipo.SelectedItem.Text == "No Alcoholicas") /*Sumar a no alcoholicas*/
                {
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO producto (nombre, descripcion, p_costo, p_venta, stock, categoria_id, proveedor) VALUES ('" + TxtNombre.Text +
                            "','" + TxtDesc.Text + "','" + TxtCosto.Text + "','" + TxtVenta.Text + "','" + TxtStock.Text + "', 1,'" + TxtProve.Text + "');";

                        new OleDbCommand(query, connection);

                        OleDbCommand comando2 = new OleDbCommand(query, connection);

                        int execute = comando2.ExecuteNonQuery();

                        connection.Close();

                        LDelete.Text = "Creado Correctamente.";

                    }
                }
                else /*Sumar a alcoholicas*/
                {
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {

                        connection.Open();

                        string query = "INSERT INTO producto (nombre, descripcion, p_costo, p_venta, stock, categoria_id, proveedor) VALUES ('" + TxtNombre.Text +
                            "','" + TxtDesc.Text + "','" + TxtCosto.Text + "','" + TxtVenta.Text + "','" + TxtStock.Text + "', 5,'" + TxtProve.Text + "');";

                        new OleDbCommand(query, connection);

                        OleDbCommand comando2 = new OleDbCommand(query, connection);

                        int execute = comando2.ExecuteNonQuery();

                        connection.Close();

                        LDelete.Text = "Creado Correctamente.";
                    }

                }

            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtSearch.Text != "" || TxtSearch.Text != null)
            {
                CBDili.Enabled = true;
                NoAlchoholicas.Checked = false;
                Alchoholicas.Checked = false;

                LDelete.Text = "Filtros deshabilitados. Usted va a eliminar buscando por nombre. Debajo los registros a borrar. Para confirmar, marque la opción 'Diligenciar'.";

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    ultimaquery = "SELECT * FROM producto where nombre = '" + TxtSearch.Text + "';";

                    OleDbCommand query = new OleDbCommand(string.Format(ultimaquery), connection);

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(query);

                    DataTable datatable = new DataTable();

                    adaptador.Fill(datatable);

                    Grid.DataSource = datatable;

                    Grid.DataBind();

                }

            }
        }

        protected void CBDili_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\944556\source\repos\dariocarodev\dbdistribuidora.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query2 = "DELETE * FROM producto WHERE nombre = '" + TxtSearch.Text + "';";

                new OleDbCommand(query2, connection);

                OleDbCommand comando2 = new OleDbCommand(query2, connection);

                int execute = comando2.ExecuteNonQuery();

                connection.Close();

                LDelete.Text = "Operación completada con éxito.";
            }
        }
    }
}