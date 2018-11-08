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
            if(firstTextBox.Text == secondTextBox.Text)
			{
				resultLabel.Text = "EQUAL";
			}
			else
			{
				resultLabel.Text = "NOT EQUAL";
			}
			
			if(neatCheckBox.Checked == true)
			{
				resultLabel2.Text = "Well, you're cool.";
			}
			else
			{
				resultLabel2.Text = "You used to be cool.";
			}
			
			if(pizzaRadio.Checked)
			{
				resultLabel3.Text = "YUM!";
			}	
			else if(pbjRadio.Checked)
			{
				resultLabel3.Text = "CLASSIC!";
			}
			else if(saladRadio.Checked)
			{
				resultLabel3.Checked = "HEALTHY!";
			}
			else
			{
				resultLabel3.Text = "Please select one of the options.";
			}	
        }
    }
}