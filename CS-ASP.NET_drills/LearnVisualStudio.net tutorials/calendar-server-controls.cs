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

        protected void getButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = myCalendar.SelectedDate.ToShortDateString();
        }

        protected void setButton_Click(object sender, EventArgs e)
        {
            myCalendar.SelectedDate = DateTime.Parse("9/12/2015");
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            myCalendar.VisibleDate = DateTime.Parse("09/12/1987");
        }

        protected void weekButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = "Week of " + myCalendar.SelectedDate.ToShortDateString();
        }

        protected void myCalendar_SelectionChanged(object sender, EventArgs e)
        {
            ResultLabel.Text = myCalendar.SelectedDate.ToShortDateString();
        }
    }
}