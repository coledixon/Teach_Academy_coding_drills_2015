using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnVSproject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //string result = String.Format("Thank you, {0}, for your business", 
                //nameBox.Text);
            int SSN = int.Parse(ssnBox.Text);
            //string result = String
                //.Format("Thank you, {0}, for your business.
                //<br />Your SSN is {1:000-00-0000}", nameBox.Text, SSN);
            int phone = int.Parse(phoneBox.Text);
            double salary = double.Parse(salaryBox.Text);

            string result = String
                .Format("Thank you, {0}, for your business." +
                "<br />Your SSN is {1:000-00-0000}." +
                "<br / >Phone: {2:(000)000.0000}" +
                "<br />Loan Date: {3:ddd -- d, M, yy}" +
                "<br / > Salary: {4:C}", nameBox.Text, 
                SSN, phone, myCalendar.SelectedDate, salary);



            ResultLabel.Text = result;

        }
    }
}