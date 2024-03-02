using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login_register
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void btnRedirectToSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the username and password
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check the format of username and password
            if (IsUsernameValid(username) && IsPasswordValid(password))
            {
                // Authenticate the user
                bool isAuthenticated = AuthenticateUser(username, password);

                if (isAuthenticated)
                {
                    // If the user is authenticated, start a session and redirect to NotOrtalama.aspx page
                    Session["Username"] = username;
                    Response.Redirect("GradeAverage.aspx");
                }
                else
                {
                    // If the user is not authenticated, show invalid username or password message
                    lblLoginStatus.Text = "Invalid username or password.";
                }
            }
            else
            {
                // If the username or password format is invalid, show an appropriate message
                lblLoginStatus.Text = "Invalid username or password format.";
            }
        }

        private bool IsUsernameValid(string username)
        {
            // Username should be between 3 and 20 characters and can only contain letters, digits, and underscore (_).
            string usernameRegex = @"^[a-zA-Z0-9_]{3,20}$";
            return Regex.IsMatch(username, usernameRegex);
        }

        private bool IsPasswordValid(string password)
        {
            // Password complexity check (should contain at least one uppercase letter, one lowercase letter, and one digit)
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
            {
                return false;
            }

            return true;
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Path to the file containing user information
            string filePath = Server.MapPath("~/App_Data/users.txt");

            // Read lines from the file and store them in an array
            string[] lines = File.ReadAllLines(filePath);

            // Check each line in the file
            foreach (string line in lines)
            {
                // Split the information in the line by comma
                string[] info = line.Split(',');

                // If there are two elements in the line and they match the username and password
                if (info.Length == 2 && info[0] == username && info[1] == password)
                {
                    return true; // User is authenticated
                }
            }

            // User not found or not authenticated
            return false;
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            // Clear the session
            Session.Clear();

            // Abandon the session
            Session.Abandon();

            // Redirect the user to another page
            Response.Redirect("Login.aspx");
        }
    }
}
