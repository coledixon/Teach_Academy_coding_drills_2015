using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnVSproject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
			//mathematical operators
            int i = 1;
			int j = 2;
			int result = i + j;
			int result = i - j;
			int result = i * j;
			int result = i / j;
			
			i = i + 1;
			i += 5;
			i++;
			i--;
			
			//order of precedence 
			/*int myInteger = (5 + 1) * 7;
			result.Text = myInteger.ToString();*/
			
			//double myDouble = 5.5;
			int myInteger = 7;
			int myOtherInteger = 4;
			
			//double myResult = myDouble + myInteger;
			
			//down-cast double (data loss)
			//int myResult = (int)myDouble + myInteger;
			
			//refined
			double myResult = (double)myInteger / (double)myOtherInteger;
			result.Text = myResult.ToString();
			
			//overflow
			int first = 2000000000;
			int second = 2000000000;
			//int result = first * second;
			long result = first * second; //still won't work
			
			//error check
			checked
			{
				reultLabel.Text = result.ToString();
			}
			
			//resultLabel.Text = result.ToString();
			
			
			
			
			
			
    }
}