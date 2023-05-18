<%@ Page Title="" Language="C#" MasterPageFile="~/ClientPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="prac07.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<title>Login</title>
	<link rel="stylesheet" type="text/css" href="styles/contact_styles.css">
	<link rel="stylesheet" type="text/css" href="styles/contact_responsive.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact_form">
		<div class="container">
			<div class="row">
				<div class="col-lg-10 offset-lg-1">
					<div class="contact_form_container">
						<div class="contact_form_title">Sign In</div>

						<form action="#" id="login_form" runat="server">
							<div class="contact_form_inputs d-flex flex-md-column">
								<input type="email" id="email" class="contact_form_email input_field" placeholder="Your Email" required="required" data-error="Email is required." runat="server">
								<br>
								<input type="password" id="pass" placeholder="Enter Password" class="contact_form_phone input_field" required="" runat="server">
							</div>
							<p id="error" runat="server" style="color:red"></p>
							<div class="contact_form_button">
								<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" style="background-color:#0e8ce4; color: #fff; padding: 10px; border: none"/><br><br>
							</div>
						</form>

					</div>
					</div>
				</div>
			</div>
		</div>
		<div class="panel"></div>
</asp:Content>
