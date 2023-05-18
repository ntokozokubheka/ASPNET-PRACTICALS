using prac07.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac07
{
    public partial class Cart : System.Web.UI.Page
    {
		Service1Client client = new Service1Client();
		protected void Page_Load(object sender, EventArgs e)
        {
			if (Session["email"] == null)
			{
				Response.Redirect("Login.aspx");
			}
			string cartItem = "";
			double total = 0.0;
			int itemIndex = 0;
			var productList = (List<Product>)Session["onCartProducts"];
			var list = (List<int>)Session["onCartItems"];
			var qtyList = (List<int>)Session["qty"];
			if (Request.QueryString["index"] != null)
            {
				int i = Convert.ToInt32(Request.QueryString["index"]);
				//int pid = Convert.ToInt32(Request.QueryString["pid"]);
				productList.RemoveAt(i);
				list.RemoveAt(i);
				qtyList.RemoveAt(i);

			}
			foreach (Product p in productList)
            {
				double subTotal = p.P_Price*qtyList[itemIndex];
				total += subTotal;
				cartItem += "<li class='cart_item clearfix'>";
				cartItem += "<div class='cart_item_image'><img src = 'images/"+p.P_Image+"'></div>";
				cartItem += "<div class='cart_item_info d-flex flex-md-row flex-column justify-content-between'>";
				cartItem += "<div class='cart_item_name cart_info_col'>";
				cartItem += "<div class='cart_item_title'>Name</div>";
				cartItem += "<div class='cart_item_text'>"+p.P_Name+"</div>";
				cartItem += "</div>";
				cartItem += "<div class='cart_item_quantity cart_info_col'>";
				cartItem += "<div class='cart_item_title'>Quantity</div>";
				cartItem += "<div class='cart_item_text'>"+ qtyList[itemIndex] + "</div>";
				cartItem += "</div>";
				cartItem += "<div class='cart_item_price cart_info_col'>";
				cartItem += "<div class='cart_item_title'>Price</div>";
				cartItem += "<div class='cart_item_text'>R" + p.P_Price + "</div>";
				cartItem += "</div>";
				cartItem += "<div class='cart_item_total cart_info_col'>";
				cartItem += "<div class='cart_item_title'>Total</div>";
				cartItem += "<div class='cart_item_text'>R" + subTotal + "</div>";
				cartItem += "</div>";
				cartItem += "<div class='cart_item_color cart_info_col'>";
				cartItem += "<div class='cart_item_title'></div>";
				cartItem += "<div class='cart_item_text'> <a href='Cart.aspx?index="+itemIndex+"'><small>Remove</small></a> </div> ";
				cartItem += "</div> ";
				cartItem += "</div>";
				cartItem += "</li>";
				itemIndex++;
			}
			cartContainer.InnerHtml = cartItem;
			totalAmount.InnerText = "R"+total.ToString();

		}
    }
}