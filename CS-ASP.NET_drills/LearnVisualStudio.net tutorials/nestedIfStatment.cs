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

            //NESTED
            /*if (nameBox.Checked)
            {
                if (box2.Checked)
                {
                    if (box3.Checked)
                    {
                        ResultLabel = "ALL ARE CHECKED!";
                    }
                }
            }*/

            //LOGICAL
            /*if (box.Checked && box2.Checked && box3.Checked)
            {
                ResultLabel = "CHECK MATE!"
            }*/

            //SIMPLE
            if (box.Checked) return;
            if (box2.Checked) return;
            if (box3.Checked) return;
            ResultLabel = "THEY'RE ALL CHECKED!";


        }
    }
}