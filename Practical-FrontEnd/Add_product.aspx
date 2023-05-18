<%@ Page Title="" Language="C#" MasterPageFile="~/ClientPage.Master" AutoEventWireup="true" CodeBehind="Add_product.aspx.cs" Inherits="prac07.Add_product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link rel="stylesheet" type="text/css" href="styles/contact_styles.css">
	<link rel="stylesheet" type="text/css" href="styles/contact_responsive.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="contact_form">
		<div class="container">
			<div class="row">
				<div class="col-lg-10 offset-lg-1">
					<div class="contact_form_container">
						<div class="contact_form_title">Add Product</div>

						<form action="#" id="contact_form" runat="server">
							<div class="contact_form_inputs d-flex flex-md-column">
								<input type="text" id="name" runat="server" class="contact_form_email input_field" placeholder="Product Name" required="required" data-error="Product name is required.">
								<br>
								<input type="text" id="description" runat="server" placeholder="Description" class="contact_form_phone input_field" required="">
								<br>
								<input type="text" id="price" runat="server" placeholder="Product Price" class="contact_form_phone input_field" required="">
								<br>
								<input type="text" id="category" runat="server" placeholder="Product Category" class="contact_form_phone input_field" required="">
								<br>
								<div class="form-group">
								    <label for="img_product">Product Image:</label>
									<input type="file" class="form-control-file" id="img" runat="server">
								</div>
							</div>
							<div class="contact_form_button">
								<asp:Button ID="btnSubmit" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" style="background-color:#0e8ce4; color: #fff; padding: 10px; border: none"/><br><br>
							</div>
                            <div id="error" runat="server"></div>
						</form>

					</div>
				</div>
			</div>
		</div>
		<div class="panel"></div>
	</div>
</asp:Content>
