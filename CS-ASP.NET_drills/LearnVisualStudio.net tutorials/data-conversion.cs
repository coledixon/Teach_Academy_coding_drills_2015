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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //int i;
			//i = "3";

			//up-cast	
			long i = 2000000000;
			long j = i;
				
			//cast	
			long i = 2000000000;
			int j = (int)i;
			
			double k = 2.5;
			int j = (int)k;
			
			result.Text = j.ToString();
			
			//string to int to string
			string i = inputTextBox.Text;
			int j = int.Parse(i);
			int k = j + 1;
			result = k.ToString();
			
			
    }
}