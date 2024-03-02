<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="login_register.WebForm2" %>

<!DOCTYPE html>
<html lang="tr">
<head>
    <title>Login</title>
    <link rel="stylesheet" href="assets/Login.css"> <!-- Reference to the style file -->
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="login form">
                <header>Login</header> <!-- Login header -->
                <asp:TextBox ID="txtUsername" runat="server" placeholder="Username" CssClass="login-input" /> <!-- Username input box -->
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" CssClass="login-input" /> <!-- Password input box -->
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="button" /> <!-- Login button -->
                <div class="signup">
                    Don't have an account? <!-- Signup message -->
                    <asp:LinkButton ID="LinkButton1" runat="server" Text="Sign Up" OnClick="btnRedirectToSignup_Click" CssClass="signup-link" /> <!-- Signup button -->
                </div>
                <asp:Label ID="lblLoginStatus" runat="server" Text="" /> <!-- Login status label -->
            </div>
        </div>
    </form>
</body>
</html>
