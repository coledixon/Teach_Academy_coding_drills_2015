using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEight
{
    public partial class X_MenBattles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] name = new string[] { "Wolverine", "NightCrawler", "Professor X", "Pheonix", "Rogue", "Beast" };
            int[] battles = new int[] { 11, 4, 12, 17, 9, 10 };

            string result = "";

            int largestIndex = 0;
            int smallestIndex = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (battles[i] > battles[largestIndex])
                {
                    largestIndex = i;
                }

                if (battles[i] < battles[smallestIndex])
                {
                    smallestIndex = i;
                }
            }

            result = String.Format("Most battles belong to: {0} (BATTLES: {1})", name[largestIndex], battles[largestIndex]);
            result += String.Format("<br />Least battles belong to: {0} (BATTLES: {1})", name[smallestIndex], battles[smallestIndex]);

            Label1.Text = result;
        }
    }
}