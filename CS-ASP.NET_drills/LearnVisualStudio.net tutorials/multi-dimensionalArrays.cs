using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnVSproject
{
    public partial class multidimensionalarrays : System.Web.UI.Page
    {
        double[,] pricegrid;

        protected void Page_Load(object sender, EventArgs e)
        {
            pricegrid = new double[3,3];
            //0 - Chicago
            //1 - Portland
            //2 - Chattanooga

            pricegrid[0, 1] = 325.0;
            pricegrid[0, 2] = 780.0;
            pricegrid[1, 0] = 440.0;
            pricegrid[1, 2] = 630.0;
            pricegrid[2, 0] = 420.0;
            pricegrid[2, 1] = 555.0;

            //resultLabel.Text = pricegrid[0, 2].ToString();
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int fromCity;
            if (chicagoFrom.Checked) fromCity = 0;
            else if (pdxFrom.Checked) fromCity = 1;
            else fromCity = 2;

            int toCity;
            if (chicagoTo.Checked) toCity = 0;
            else if (pdxTo.Checked) toCity = 1;
            else  toCity = 2;

            if (fromCity == toCity)
            {
                resultLabel.Text = "";
                return;
            }
            resultLabel.Text = pricegrid[fromCity, toCity].ToString();
        }
    }
}