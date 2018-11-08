using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnVSproject
{
    public partial class HelperMethods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pintRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups();
            //CODE REMOVED FOR HELPER METHOD
            /*if (textBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(textBox.Text, out quantity))
                return;

            double cups = quantity * 2.0;
            resultLabel.Text = "NUMBER OF CUPS: " + cups.ToString();*/
        }

        protected void quartRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups();
            //CODE REMOVED FOR HELPER METHOD
            /*if (textBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(textBox.Text, out quantity))
                return;

            double cups = quantity * 4.0;
            resultLabel.Text = "NUMBER OF CUPS: " + cups.ToString();*/
        }

        private void calculateCups()
        {
            //DEFINING HELPER METHOD FUNCTION
            if (textBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(textBox.Text, out quantity))
                return;

            double cups = 0.0;

            if (cupRadio.Checked) cups = quantity;
            else if (pintRadio.Checked) cups = quantity * 2;
            else if (quartRadio.Checked) cups = quantity * 4;
            else if (gallonRadio.Checked) cups = quantity * 16;

            resultLabel.Text = "NUMBER OF CUPS: " + cups.ToString();

        }

        protected void cupRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups();
        }

        protected void gallonRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups();
        }
    }
}