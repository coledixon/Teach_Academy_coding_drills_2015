using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFour
{
    public partial class PizzaOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sizeRadio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            double total;

            if (sizeRadio.SelectedItem.Value == "Small")
            {
                total = 10.0;
            }
            else if (sizeRadio.SelectedItem.Value == "Medium")
            {
                total = 13.0;
            }
            else
            {
                total = 16.0;
            }

            if (crustRadio.SelectedItem.Value == "Deep")
            {
                total += 2.0;
            }
            else if (crustRadio.SelectedItem.Value == "Stuff")
            {
                total += 3.0;
            }

            total = (pepCheck.Checked) ? total + 1.50 : total;
            total = (onionCheck.Checked) ? total + 1 : total;
            total = (greenCheck.Checked) ? total + .50 : total;
            total = (redCheck.Checked) ? total + .75 : total;
            total = (ancCheck.Checked) ? total + 2 : total;
            total = (sausageCheck.Checked) ? total + 2 : total;

            if (bonusAnch.Checked || bonusSaus.Checked)
            {
                total -= 2;
            }

            priceLabel.Text = "$" + total.ToString();

        }
    }
}