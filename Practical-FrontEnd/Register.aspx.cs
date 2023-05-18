using HashPass;
using prac07.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac07
{
    public partial class Register : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_type"] != null)
            {
                if (Session["user_type"].Equals("M"))
                {
                    user_type.Visible = true;
                }
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            if (password.Value == password2.Value)
            {
                bool reg = client.register(email.Value, Secrecy.HashPassword(password.Value), user_type.Value);
                if (reg)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    error.InnerText = "Email already exists";
                }
            }
        }
    }
}