using prac07.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac07
{
    public partial class About_product : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
			string visibity = "hidden";
			if (Session["email"] != null)
			{
				visibity = "";
			}
			int id  = Convert.ToInt32(Request.QueryString["id"]);
            var product = client.getProduct(id);

			string proImg = "";
			proImg = "<div class='image_selected'><img src = 'images/"+product.P_Image+"'></div>";
			productImg.InnerHtml = proImg;
			
			string strProduct = "";
			strProduct += "<div class='product_description'>";
			strProduct += "<div class='product_category'>"+product.P_Category+"</div>";
			strProduct += "<div class='product_name'>"+product.P_Name+"</div>";
			strProduct += "<div class='rating_r rating_r_4 product_rating'><i></i><i></i><i></i><i></i><i></i></div>";
			strProduct += "<div class='product_text'><p>"+product.P_Description+"</p></div>";
			strProduct += "<div class='order_info d-flex flex-row'>";
			strProduct += "<form action = '#' > ";
			strProduct += "<div class='clearfix' style='z-index: 1000;'>";
			strProduct += "<div class='product_quantity clearfix'>";
			strProduct += "<span>Quantity: </span>";
			strProduct += "<input id = 'quantity_input' type='text' pattern='[0-9]*' value='1'>";
			strProduct += "<div class='quantity_buttons'>";
			strProduct += "<div id = 'quantity_inc_button' class='quantity_inc quantity_control'><i class='fas fa-chevron-up'></i></div>";
			strProduct += "<div id = 'quantity_dec_button' class='quantity_dec quantity_control'><i class='fas fa-chevron-down'></i></div>";
			strProduct += "</div>";
			strProduct += "</div>";
			strProduct += "<ul class='product_color'>";
			strProduct += "<li>";
			strProduct += "<span>Color: </span>";
			strProduct += "<div class='color_mark_container'><div id = 'selected_color' class='color_mark'></div></div>";
			strProduct += "<div class='color_dropdown_button'><i class='fas fa-chevron-down'></i></div>";

			strProduct += "<ul class='color_list'>";
			strProduct += "<li><div class='color_mark' style='background: #999999;'></div></li>";
			strProduct += "<li><div class='color_mark' style='background: #b19c83;'></div></li>";
			strProduct += "<li><div class='color_mark' style='background: #000000;'></div></li>";
			strProduct += "</ul>";
			strProduct += "</li>";
			strProduct += "</ul>";

			strProduct += "</div>";

			strProduct += "<div class='product_price'>R"+product.P_Price+"</div>";
			strProduct += "<div class='button_container'>";
			strProduct += "<button type = 'button' class='button cart_button' "+ visibity + "><a style='color:#ffffff;' href='Home.aspx?cid=" + product.P_ID + "&qty=1' id='btnAddToCart'>Add to Cart</a></button>";
			strProduct += "<div class='product_fav'><i class='fas fa-heart'></i></div>";
			strProduct += "</div>";

			strProduct += "</form>";
			strProduct += "</div>";
			strProduct += "</div>";

			productC.InnerHtml = strProduct;

		}
    }
}