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
            DateTime myValue = DateTime.Now;
            //ResultLabel.Text = myValue.ToString();
            //ResultLabel2.Text = myValue.ToShortTimeString();
            //ResultLabel3.Text = myValue.ToShortDateString();
            //ResultLabel4.Text = myValue.ToLongDateString();
            //ResultLabel5.Text = myValue.ToLongTimeString();

            //ResultLabel.Text = myValue.AddDays(2).ToString();
            ResultLabel2.Text = myValue.AddMonths(-2).ToString();
            ResultLabel3.Text = myValue.AddHours(12).ToString();
            ResultLabel5.Text = myValue.AddYears(5).ToString();
            ResultLabel4.Text = myValue.Month.ToString();

            ResultLabel.Text = myValue.IsDaylightSavingTime().ToString();

            ResultLabel2.Text = myValue.DayOfYear.ToString();
            ResultLabel3.Text = myValue.DayOfWeek.ToString();

            DateTime newValue = DateTime.Parse("09/12/1987");
            ResultLabel.Text = newValue.ToLongDateString();
        }
    }
}