using prac07.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac07
{
    public partial class Home : System.Web.UI.Page
    {
		Service1Client client = new Service1Client();
		protected void Page_Load(object sender, EventArgs e)
        {
			string visibity = "hidden";
			if (Session["email"] != null)
			{
				visibity = "";
			}

				string itemStr = "";
			dynamic products = client.getProducts();
			foreach(Product p in products)
            {
				itemStr += "<div class='featured_slider_item'>";
				itemStr += "<div class='border_active'></div>";
				itemStr += "<div class='product_item discount d-flex flex-column align-items-center justify-content-center text-center'>";
				itemStr += "<div class='product_image d-flex flex-column align-items-center justify-content-center'><a href='About_product.aspx?id=" + p.P_ID + "'><img src = 'images/" + p.P_Image+"'></div>";
				itemStr += "<div class='product_content'>";
				itemStr += "<div class='product_price discount'><span>R"+p.P_Price+"</span></div>";
				itemStr += "<div class='product_name'><div><a href = 'About_product.aspx?id=" + p.P_ID + "' >" + p.P_Name+"</a></div></div>";
				itemStr += "<div class='product_extras'>";
				itemStr += "<div class='product_color'>";
				itemStr += "<input type = 'radio' checked name='product_color' style='background:#b19c83'>";
				itemStr += "<input type = 'radio' name='product_color' style='background:#000000'>";
				itemStr += "<input type = 'radio' name='product_color' style='background:#999999'>";
				itemStr += "</div>";
				itemStr += "<button class='product_cart_button' "+ visibity + "><a style='color:#ffffff;' href='Home.aspx?cid=" + p.P_ID + "&qty=1'>Add to Cart</a></button>";
				itemStr += "</div>";
				itemStr += "</div>";
				itemStr += "<div class='product_fav'><i class='fas fa-heart'></i></div>";
				itemStr += "<ul class='product_marks'>";
				itemStr += "<li class='product_mark product_discount'>-25%</li>";
				itemStr += "<li class='product_mark product_new'>new</li>";
				itemStr += "</ul>";
				itemStr += "</div>";
				itemStr += "</div>";
			}

			items.InnerHtml = itemStr;
        }
    }
}