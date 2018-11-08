using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeNine
{
    public partial class PostalCalculatorChallenge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            performCalculation();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            performCalculation();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            performCalculation();
        }

        protected void groundRadio_CheckedChanged(object sender, EventArgs e)
        {
            performCalculation();
        }

        protected void airRadio_CheckedChanged(object sender, EventArgs e)
        {
            performCalculation();
        }

        protected void nextRadio_CheckedChanged(object sender, EventArgs e)
        {
            performCalculation();
        }

        private void performCalculation()
        {
            if (!valuesExist()) return;

            //VOLUME
            int volume = 0;
            if (!tryGetVolume(out volume)) return;

            //BUTTON SELECTED (.15, .25, .45)
            double postageMultiplier = getPostageMultiplier();

            //CALCULATE COST
            double cost = volume * postageMultiplier;

            //RETURN RESULT
            resultLabel.Text = String.Format("PARCEL COST: {0:C}.", cost);

        }

        private bool valuesExist()
        {
            if (!airRadio.Checked && !groundRadio.Checked && !nextRadio.Checked)
                return false;

            if (TextBox1.Text.Trim().Length == 0 || TextBox2.Text.Trim().Length == 0)
                return false;

            return true;
        }

        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(TextBox1.Text.Trim(), out width)) return false;
            if (!int.TryParse(TextBox2.Text.Trim(), out height)) return false;
            if (!int.TryParse(TextBox3.Text.Trim(), out length)) length = 1;

            volume = width * height * length;
            return true;
        }

        private double getPostageMultiplier()
        {
            if (groundRadio.Checked) return .15;
            else if (airRadio.Checked) return .25;
            else if (nextRadio.Checked) return .45;
            else return 0;
        }

    }
}