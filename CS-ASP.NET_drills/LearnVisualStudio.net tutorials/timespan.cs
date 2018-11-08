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
            // http://is.gd/timespan
            // Days.Hours:Minutes:Seconds.Milliseconds
            TimeSpan mySpan = TimeSpan.Parse("1.2:3:30.5");

            DateTime birthday = DateTime.Parse("09/12/1987");
            TimeSpan age = DateTime.Now.Subtract(birthday);

            ResultLabel.Text =  age.Hours.ToString();

            ResultLabel.Text = age.TotalDays.ToString();
        }
    }
}