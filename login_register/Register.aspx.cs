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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected bool IsUsernameValid(string username)
        {
            // Username should be between 3 and 20 characters and can only contain letters, digits, and underscore.
            string usernameRegex = @"^[a-zA-Z0-9_]{3,20}$";
            return Regex.IsMatch(username, usernameRegex);
        }

        protected bool IsPasswordValid(string password)
        {
            // Password should be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one digit.
            string passwordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            return Regex.IsMatch(password, passwordRegex);
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            string filePath = Server.MapPath("~/App_Data/users.txt");

            if (IsUsernameTaken(filePath, username))
            {
                // If username is already taken, show error message
                lblSignupStatus.Text = "This username is already taken. Please choose a different username.";
            }
            else if (password != confirmPassword)
            {
                // If passwords do not match, show error message
                lblSignupStatus.Text = "Passwords do not match. Please check again.";
            }
            else
            {
                bool isUsernameValid = IsUsernameValid(username);
                bool isPasswordValid = IsPasswordValid(password);

                if (!isUsernameValid)
                {
                    // If username does not meet the rules, show error message
                    lblUsernameRules.Text = "-Username should be between 3 and 20 characters long and contain only letters, digits, and underscores.";
                }
                else
                {
                    lblUsernameRules.Text = ""; // Clear the message if username meets the rules
                }

                if (!isPasswordValid)
                {
                    // If password does not meet the rules, show error message
                    lblPasswordRules.Text = "-Password should be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one digit.";
                }
                else
                {
                    lblPasswordRules.Text = ""; // Clear the message if password meets the rules
                }

                if (!isUsernameValid || !isPasswordValid)
                {
                    // If username or password is not valid, show signup failed message
                    lblSignupStatus.Text = "Signup failed. Please check your input.";
                }
                else
                {
                    // Create the signup information by combining username and password
                    string signupInfo = username + "," + password;

                    // Check if the same username exists in the file
                    if (IsUsernameTaken(filePath, username))
                    {
                        // If the same username is already registered, show error message
                        lblSignupStatus.Text = "This username is already taken. Please choose a different username.";
                    }
                    else
                    {
                        // Successfully save the user
                        File.AppendAllText(filePath, signupInfo + Environment.NewLine);
                        lblSignupStatus.Text = "Signup completed successfully.";
                    }
                }
            }
        }

        private bool IsUsernameTaken(string filePath, string username)
        {
            // This function checks if the given username is already in the file.

            // Load all lines of the file into an array
            string[] lines = File.ReadAllLines(filePath);

            // Loop to check each line
            foreach (string line in lines)
            {
                // Split each line by comma to get the username and other information
                string[] info = line.Split(',');

                // If the line has at least one element and the username matches the specified username,
                // return true
                if (info.Length > 0 && info[0] == username)
                {
                    return true; // Username is already taken
                }
            }
            // If the loop ends and the username cannot be found in the file, return false
            return false; // Username is not taken
        }

        protected void btnRedirectToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
