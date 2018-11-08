using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnVSproject
{
    public partial class arraylength : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] hours = new double[0];
                ViewState.Add("HOURS", hours);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double[] hours = (double[])ViewState["HOURS"];

            Array.Resize(ref hours, hours.Length +1);
            int newestItem = hours.GetUpperBound(0);
            hours[newestItem] = double.Parse(TextBox1.Text);

            ViewState["HOURS"] = hours;
            resultLabel.Text = String
                .Format("Total hours: {0}<br />Most hours: {1}<br />"
				"Least hours: {2}<br />Average hours: {3:N2}", 
                hours.Sum(), hours.Max(), hours.Min(), hours.Average());
        }
    }
}