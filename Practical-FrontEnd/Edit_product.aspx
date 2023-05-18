<%@ Page Title="" Language="C#" MasterPageFile="~/ClientPage.Master" AutoEventWireup="true" CodeBehind="Edit_product.aspx.cs" Inherits="prac07.Edit_product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<title>About Product</title>
	<link rel="stylesheet" type="text/css" href="styles/contact_styles.css">
	<link rel="stylesheet" type="text/css" href="styles/contact_responsive.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="contact_form">
		<div class="container">
			<div class="row">
				<div class="col-lg-10 offset-lg-1">
					<div class="contact_form_container">
						<div class="contact_form_title">Edit Product</div>

						<form action="#" id="contact_form">
							<div class="contact_form_inputs d-flex flex-md-column">
								<input type="text" id="product_name" class="contact_form_email input_field" placeholder="Product Name" required="required" data-error="Product name is required.">
								<br>
								<input type="text" id="product_description" placeholder="Description" class="contact_form_phone input_field" required="">
								<br>
								<input type="number" id="price" placeholder="Product Price" class="contact_form_phone input_field" required="">
								<br>
								<div class="form-group">
								    <label for="img_product">Product Image:</label>
									<input type="file" class="form-control-file" id="img_product">
								</div>
							</div>
							<div class="contact_form_button">
								<button type="submit" class="button contact_submit_button">Add</button>
							</div>
						</form>

					</div>
				</div>
			</div>
		</div>
		<div class="panel"></div>
	</div>
</asp:Content>
