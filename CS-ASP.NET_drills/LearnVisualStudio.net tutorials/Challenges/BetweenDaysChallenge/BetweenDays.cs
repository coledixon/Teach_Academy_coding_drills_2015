using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFive
{
    public partial class BetweenDaysCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime selection1 = Calendar1.SelectedDate.Date;
            DateTime selection2 = Calendar2.SelectedDate.Date;

            TimeSpan result = selection2.Subtract(selection1);

            if (Calendar1.SelectedDate.Date == DateTime.MinValue.Date)
            {
                resultLabel.Text = "PLEASE SELECT A DATE FROM CALENDAR ONE";
            }
            else if (Calendar2.SelectedDate.Date == DateTime.MinValue.Date)
            {
                resultLabel.Text = "PLEASE SELECT A DATE FROM CALENDAR TWO";
            }
            else
            {
                if (Calendar1.SelectedDate > Calendar2.SelectedDate)
                {
                    resultLabel.Text = Calendar1.SelectedDate
                        .Subtract(Calendar2.SelectedDate).TotalDays.ToString() + " day(s) have elapsed.";
                }
                else
                {
                    resultLabel.Text = Calendar2.SelectedDate
                        .Subtract(Calendar1.SelectedDate).TotalDays.ToString() + " day(s) have elapsed.";
                }
            }
        }
   }
}