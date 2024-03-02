<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="login_register.WebForm1" %>

<!DOCTYPE html>
<html lang="tr">
<head>
    <title>Signup</title>
    <link rel="stylesheet" href="assets/Register.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <!-- Registration form -->
            <div class="registration form">
                <!-- Header -->
                <header>Signup</header>

                <!-- Username, password, and password confirmation input boxes -->
                <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter username"></asp:TextBox>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Create password"></asp:TextBox>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" placeholder="Confirm password"></asp:TextBox>
                <asp:Button ID="btnSignup" runat="server" CssClass="button" Text="Signup" OnClick="btnSignup_Click" />

                <!-- Login link -->
                <div class="signup">
                    Already have an account?
                    <asp:LinkButton runat="server" Text="Login" OnClick="btnRedirectToLogin_Click" CssClass="signup" />
                </div>

                <!-- Labels for registration status and error messages -->
                <asp:Label ID="lblSignupStatus" runat="server" Text="" />
                <asp:Label ID="lblUsernameRules" runat="server" CssClass="error-message"></asp:Label>
                <asp:Label ID="lblPasswordRules" runat="server" CssClass="error-message"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
