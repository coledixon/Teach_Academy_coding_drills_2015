using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSix
{
    public partial class EpicSpies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                prevCalendar.SelectedDate = DateTime.Now;
                startCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endCalendar.SelectedDate = DateTime.Now.Date.AddDays(24);
            }
        }

        protected void endCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void startCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void prevCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void missionButton_Click(object sender, EventArgs e)
        {
            //$500 per day
            TimeSpan durationOfMission = endCalendar.SelectedDate.Subtract(startCalendar.SelectedDate);
            double totalCost = durationOfMission.TotalDays * 500.0;

            //>21 days + $1000
            if (durationOfMission.TotalDays > 21)
            {
                totalCost += 1000.0;
            }

            TimeSpan betweenMissions = startCalendar.SelectedDate.Subtract(prevCalendar.SelectedDate);

            if (betweenMissions.TotalDays < 14)
            {
                resultLabel.Text = "ERROR: 14 DAY REHABILITATION PERIOD AFTER EACH MISSION IS REQUIRED FOR ALL AGENTS.";
            }
            else
            {
                resultLabel.Text = String.Format("Welcome, Agent {0}. <br / >Your mission, if you choose to accept it, is entitled {1}." +
                    "<br />The details of your mission will be told to you en route to your destination." +
                    "<br />The cost of this mission to the agency will be {2:C}. DO NOT BOTCH THIS MISSION!" +
                    "<br />You will departing from Heathrow on {3:dd/M/Y}." +
                    "<br />Good luck, and god speed!", codeBox.Text, assignBox.Text, totalCost, startCalendar.SelectedDate.ToShortDateString());

            }

        }

    }
}