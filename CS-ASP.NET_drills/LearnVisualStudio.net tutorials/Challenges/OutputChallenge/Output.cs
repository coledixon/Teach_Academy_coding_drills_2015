using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeOne
{
    public partial class Challenge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void age_box_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void money_box_TextChanged(object sender, EventArgs e)
        {

        }
        protected void submitbutton_Click(object sender, EventArgs e)
        {
            string age_box = agebox.Text;
            string money_box = moneybox.Text;

            string resultbox = "At " + age_box + " you should have more than " + money_box + " in your pocket. Pathetic.";
            result.Text = resultbox;
        }
    }
}