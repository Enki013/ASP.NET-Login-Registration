<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradeAverage.aspx.cs" Inherits="login_register.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grade Average Page</title>
    <!-- Reference to the style file -->
    <link rel="stylesheet" href="assets/GradeAverage.css"/>
</head>
<body>
    <!-- Start of form element -->
    <form id="form1" runat="server">
        <!-- Navbar section -->
        <div class="navbar">
            <!-- Logout button -->
            <asp:Button ID="Button1" runat="server" Text="Log Out" OnClick="Logout_Click" CssClass="logout-button" />
        </div>
        <div class="container">
            <!-- Textboxes for entering grades -->
            <asp:TextBox ID="txtGrade1" runat="server" placeholder="Grade 1 (1-100)" CssClass="textbox" />
            <asp:TextBox ID="txtGrade2" runat="server" placeholder="Grade 2 (1-100)" CssClass="textbox" />
            <asp:TextBox ID="txtGrade3" runat="server" placeholder="Grade 3 (1-100)" CssClass="textbox" />
            <!-- Button to calculate the average -->
            <asp:Button ID="btnCalculateAverage" runat="server" Text="Calculate Average" OnClick="CalculateAverage_Click" CssClass="button" />
            <!-- Label to display the calculated average -->
            <asp:Label ID="lblAverageResult" runat="server" Text="" CssClass="result" />
        </div>
    </form>
</body>
</html>
