using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login_register
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void CalculateAverage_Click(object sender, EventArgs e)
        {
            // Variables to store the grades entered by the user
            double grade1, grade2, grade3;

            // Convert grades from textboxes entered by the user to double type
            if (double.TryParse(txtGrade1.Text, out grade1) &&
                double.TryParse(txtGrade2.Text, out grade2) &&
                double.TryParse(txtGrade3.Text, out grade3))
            {
                // Check if entered grades are valid and between 1 and 100
                if (grade1 >= 1 && grade1 <= 100 &&
                    grade2 >= 1 && grade2 <= 100 &&
                    grade3 >= 1 && grade3 <= 100)
                {
                    // Calculate the average of the grades
                    double average = (grade1 + grade2 + grade3) / 3.0;

                    // Assign the calculated average value to the label and display it with 2 decimal places
                    lblAverageResult.Text = "Average: " + average.ToString("F2");
                }
                else
                {
                    // Inform the user if the grades are not between 1 and 100
                    lblAverageResult.Text = "Grades should be between 1 and 100.";
                }
            }
            else
            {
                // Inform the user if a valid numerical value is not entered
                lblAverageResult.Text = "Enter valid grades.";
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            // Clear the session
            Session.Clear();

            // Abandon the session
            Session.Abandon();

            // Redirect the user to another page (e.g., login page)
            Response.Redirect("Login.aspx");
        }
    }
}
