using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnVSproject
{
    public partial class arrays : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            /*string[] values = new string[5];
            values[0] = TextBox1.Text;
            values[1] = TextBox2.Text;
            values[2] = TextBox3.Text;
            values[3] = TextBox4.Text;
            values[4] = TextBox5.Text;*/

            //resultLabel.Text = values[4];
            //resultLabel.Text = values.Length.ToString();

            string[] values = new string[4] {"bob", "tabor", "light", "sabre"};
            ViewState.Add("MyValues", values);
            resultLabel.Text = "VALUES ADDED...";
        }

        protected void removeButton_Click(object sender, EventArgs e)
        {
            string[] values = (string[])ViewState["MyValue"];
            TextBox1.Text = values[0];
            TextBox2.Text = values[1];
            TextBox3.Text = values[2];
            TextBox4.Text = values[3];

            resultLabel.Text = "VALUES RETRIEVED...";

        }
    }
}