using prac07.ServiceReference1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac07
{
    public partial class ClientPage : System.Web.UI.MasterPage
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                loginTab.Visible = false;
                logoutTab.Visible = true;
                if (Session["user_type"].Equals("M"))
                {
                    addProduct.Visible = true;
                    editProduct.Visible = true;
                }
                var list = (List<int>)Session["onCartItems"];
                var productList = (List<Product>)Session["onCartProducts"];
                var qtyList = (List<int>)Session["qty"];
                double total = 0.0;
                int itemIndex = 0;
                int cid = Convert.ToInt32(Request.QueryString["cid"]);
                int qty = Convert.ToInt32(Request.QueryString["qty"]);
                if (Request.QueryString["cid"] != null)
                {
                    if (!list.Contains(cid))
                    {
                        list.Add(cid);
                        qtyList.Add(qty);
                        //get product price
                        var product = client.getProduct(cid);
                        productList.Add(product);
                    }
                }
                foreach(Product p in productList)
                {
                    total += p.P_Price* qtyList[itemIndex];
                    itemIndex++;
                }
                cartTotal.InnerText = "R"+total.ToString();
                cart_count.InnerText = list.Count.ToString();
            }
        }
    }
}