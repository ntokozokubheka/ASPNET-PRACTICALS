using prac07.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac07
{
    public partial class Checkout : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            int itemIndex = 0;
            var list = (List<int>)Session["onCartItems"];
            int userid = Convert.ToInt32(Session["u_id"]);
            var qtyList = (List<int>)Session["qty"];
            foreach (int pid in list)
            {
                client.orderProduct(userid, pid, qtyList[itemIndex]);
            }
        }
    }
}