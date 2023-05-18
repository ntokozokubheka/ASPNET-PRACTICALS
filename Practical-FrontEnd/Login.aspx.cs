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
    public partial class Login : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var user = client.login(email.Value, Secrecy.HashPassword(pass.Value));
            if (user != null)
            {
                Session["email"] = user.Email;
                Session["u_id"] = user.U_ID;
                Session["user_type"] = user.User_type;
                Session["onCartItems"] = new List<int>();
                Session["qty"] = new List<int>();
                Session["onCartProducts"] = new List<Product>();
                Response.Redirect("Home.aspx");
            }
            else
            {
                error.InnerText = "Incorrect Password";
            }
        }
    }
}