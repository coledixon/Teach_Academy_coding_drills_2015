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
            if (sizeRadio.SelectedItem.Value == "Small")
            {
                string smallprice = "$10.00";
                priceLabel.Text = smallprice;
            }
            else if (sizeRadio.SelectedItem.Value == "Medium")
            {
                string medprice = "$13.00";
                priceLabel.Text = medprice;
            }
            else if (sizeRadio.SelectedItem.Value == "Large")
            {
                string lrgprice = "$16.00";
                priceLabel.Text = lrgprice;
            }
        }

        protected void crustRadio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int smallprice = 10;
            int medprice = 13;
            int lrgprice = 16;
            if (crustRadio.SelectedItem.Value == "Deep" && sizeRadio.SelectedItem.Value == "Small")
            {
                int newPrice = smallprice += 2;
                priceLabel.Text = "$" + newPrice.ToString();
            }
            else if (crustRadio.SelectedItem.Value == "Stuff" && sizeRadio.SelectedItem.Value == "Small")
            {
                int newPrice = smallprice += 3;
                priceLabel.Text = "$" + newPrice.ToString();
            }
            else if (crustRadio.SelectedItem.Value == "Thin" && sizeRadio.SelectedItem.Value == "Small")
            {
                priceLabel.Text = "$"+smallprice.ToString();
            }

            if (crustRadio.SelectedItem.Value == "Deep" && sizeRadio.SelectedItem.Value == "Medium")
            {
                int newprice = medprice += 2;
                priceLabel.Text = "$"+newprice.ToString();
            }
            else if (crustRadio.SelectedItem.Value == "Stuff" && sizeRadio.SelectedItem.Value == "Medium")
            {
                int newPrice = medprice += 3;
                priceLabel.Text = "$"+newPrice.ToString();
            }
            else if (crustRadio.SelectedItem.Value == "Thin" && sizeRadio.SelectedItem.Value == "Medium")
            {
                priceLabel.Text = "$"+medprice.ToString();
            }

            if (crustRadio.SelectedItem.Value == "Deep" && sizeRadio.SelectedItem.Value == "Large")
            {
                int newprice = lrgprice += 2;
                priceLabel.Text = "$" + newprice.ToString();
            }
            else if (crustRadio.SelectedItem.Value == "Stuff" && sizeRadio.SelectedItem.Value == "Large")
            {
                int newPrice = lrgprice += 3;
                priceLabel.Text = "$" + newPrice.ToString();
            }
            else if (crustRadio.SelectedItem.Value == "Thin" && sizeRadio.SelectedItem.Value == "Large")
            {
                priceLabel.Text = "$"+lrgprice.ToString();
            }


        }
    }
}