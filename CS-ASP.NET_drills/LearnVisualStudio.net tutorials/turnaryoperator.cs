using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IfElifElse
{
    public partial class LogicalLoop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

		}
        protected void OK_Click(object sender, EventArgs e)
        {
			resultLabel.Text = (firstTextbox.text == secondTextBox.Text) ? "YES" : "NO";
			
			resultLabel2.Text = (oldCheckBox.Checked) ? "SCIENCE" : "FICTION";
			
			
			int result = (thirdTextBox.Text == fourthTextBox.Text) ? 100 : 50;
			resultLabel3.Text = result.ToString();
		}
    }
}