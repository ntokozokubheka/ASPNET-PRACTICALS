<%@ Page Title="" Language="C#" MasterPageFile="~/ClientPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="prac07.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Register</title>
	<link rel="stylesheet" type="text/css" href="styles/contact_styles.css">
	<link rel="stylesheet" type="text/css" href="styles/contact_responsive.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact_form">
		<div class="container">
			<div class="row">
				<div class="col-lg-10 offset-lg-1">
					<div class="contact_form_container">
						<div class="contact_form_title">Sign Up</div>

						<form id="register_form" runat="server">
							<div class="contact_form_inputs d-flex flex-md-column">
								<input type="email" id="email" class="input_field" placeholder="Your Email" required="required" data-error="Email is required." runat="server">
								<br>
								<input type="password" id="password" placeholder="Enter Password" class="contact_form_phone input_field" required="" runat="server">
								<br>
								<input type="password" id="password2" placeholder="Confirm Password" class="contact_form_phone input_field" required="" runat="server">
								<br>
								<select class="form-control" style="margin: 0!important; color: #0e8ce4;" id="user_type" required="" runat="server" visible="false">
								  	<option value="">Select user type</option>
								    <option value="C">Client</option>
								    <option value="M">Manager</option>
								</select>
                                <br />
                                <p id="error" runat="server" style="color:red"></p>
							</div>
							<div class="contact_form_button">
								<asp:Button ID="btnSubmit" runat="server" Text="Register" OnClick="btnSignUp_Click" style="background-color:#0e8ce4; color: #fff; padding: 10px; border: none"/><br><br>
							</div>
						</form>

					</div>
				</div>
			</div>
		</div>
		<div class="panel"></div>
	</div>
</asp:Content>
