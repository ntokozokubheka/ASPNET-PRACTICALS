<%@ Page Title="" Language="C#" MasterPageFile="~/ClientPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="prac07.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<title>Shoping Cart</title>
	<link rel="stylesheet" type="text/css" href="styles/cart_styles.css">
	<link rel="stylesheet" type="text/css" href="styles/cart_responsive.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="cart_section">
		<div class="container">
			<div class="row">
				<div class="col-lg-10 offset-lg-1">
					<div class="cart_container">
						<div class="cart_title">Shopping Cart</div>
						<div class="cart_items">
							<ul class="cart_list" id="cartContainer" runat="server">

							</ul>
						</div>
						
						<!-- Order Total -->
						<div class="order_total">
							<div class="order_total_content text-md-right">
								<div class="order_total_title">Order Total:</div>
								<div class="order_total_amount" id="totalAmount" runat="server">$2000</div>
							</div>
						</div>

						<div class="cart_buttons">
                            <a href="Checkout.aspx"><button type="button" class="button cart_button_checkout">Checkout</button></a>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
