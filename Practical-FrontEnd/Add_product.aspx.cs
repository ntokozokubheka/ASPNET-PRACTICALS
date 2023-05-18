using prac07.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac07
{
    public partial class Add_product : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            string status = "";
            bool add = client.addProduct(name.Value,description.Value,category.Value, Convert.ToDouble(price.Value),status,img.Value);
            if (add)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                error.InnerText = "Error: Could not add the recipe.";
            }
        }
    }
}