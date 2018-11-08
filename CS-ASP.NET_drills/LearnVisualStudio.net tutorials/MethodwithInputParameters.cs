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
            calculateCups(2.0, "PINTS");
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
            calculateCups(4.0, "QUARTS");
            //CODE REMOVED FOR HELPER METHOD
            /*if (textBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(textBox.Text, out quantity))
                return;

            double cups = quantity * 4.0;
            resultLabel.Text = "NUMBER OF CUPS: " + cups.ToString();*/
        }

        private void calculateCups(double measureToCupRatio, string measurment)
        {
            //DEFINING HELPER METHOD FUNCTION
            if (textBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(textBox.Text, out quantity))
                return;

            double cups = quantity * measureToCupRatio;

            //REMOVED FOR INPUT PARAMETER
            /*if (cupRadio.Checked) cups = quantity;
            else if (pintRadio.Checked) cups = quantity * 2;
            else if (quartRadio.Checked) cups = quantity * 4;
            else if (gallonRadio.Checked) cups = quantity * 16;*/

            resultLabel.Text = string.Format("{0:N2} {1} IS EQUAL TO {2:N2} CUPS.", quantity, measurment, cups);

        }

        protected void cupRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(1.0, "CUPS");
        }

        protected void gallonRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(16.0, "GALLONS");
        }

        protected void textBox_TextChanged(object sender, EventArgs e)
        {
            //calculateCups()
        }
    }
}