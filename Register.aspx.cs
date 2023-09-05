using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace proyectoweb2
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {

            string user = usuario.Text;
            string email = correo.Text;
            string pass = password.Text;
            string pass2 = password2.Text;

       if (user == "" || user == null || email == "" || email == null || pass == "" || pass == null || pass2 == "" || pass2 == null) {
                MessageBox.Show("Ningún campo puede quedar vacio.");
    }
            else
            {
                if (pass != pass2)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                else
                {
                    Response.Redirect("Signin.aspx");
                }
            }
        }
    }
    }
