using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeTwo
{
    public partial class SimpleCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ADD_Click(object sender, EventArgs e)
        {
            string Value1 = valueInput.Text;
            string Value2 = valueInput2.Text;

            int addition = int.Parse(Value1) + int.Parse(Value2);

            string add_result = addition.ToString();

            resultLabel.Text = add_result;
        }

        protected void SUB_Click(object sender, EventArgs e)
        {
            string Value1 = valueInput.Text;
            string Value2 = valueInput2.Text;

            int subtraction = int.Parse(Value1) - int.Parse(Value2);

            string sub_result = subtraction.ToString();

            resultLabel.Text = sub_result;
        }

        protected void MULTI_Click(object sender, EventArgs e)
        {
            string Value1 = valueInput.Text;
            string Value2 = valueInput2.Text;

            int multiplication = int.Parse(Value1) * int.Parse(Value2);

            string multi_result = multiplication.ToString();

            resultLabel.Text = multi_result;
        }

        protected void DIV_Click(object sender, EventArgs e)
        {
            string Value1 = valueInput.Text;
            string Value2 = valueInput2.Text;

            double division = double.Parse(Value1) / double.Parse(Value2);

            string div_result = division.ToString();

            resultLabel.Text = div_result;
        }

        protected void CLEAR_Click(object sender, EventArgs e)
        {
            valueInput.Text = String.Empty;
            valueInput2.Text = String.Empty;

        }
    }
}