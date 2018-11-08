using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeThree
{
    public partial class ConditionalRadio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void filmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filmList.SelectedItem.Value == "ScienceFiction")
            {
                resultLabel.Text = "KLAATU BARADA NIKTO";
                filmImg.ImageUrl = "scifi.png";
            }
            else if (filmList.SelectedItem.Value == "Action")
            {
                resultLabel.Text = "EXPLOSIONS! GUNS! LARGE-BREASTED WOMEN!";
                filmImg.ImageUrl = "action.png";
            }
            else if (filmList.SelectedItem.Value == "Horror")
            {
                resultLabel.Text = "HERE'S JOHNNY!";
                filmImg.ImageUrl = "horror.png";
            }
            else if (filmList.SelectedItem.Value == "Romance")
            {
                resultLabel.Text = "RYAN GOSLING";
                filmImg.ImageUrl = "romance.png";
            }
            else if (filmList.SelectedItem.Value == "Western")
            {
                resultLabel.Text = "WAYNE > EASTWOOD";
                filmImg.ImageUrl = "western.png";
            }
            else if (filmList.SelectedItem.Value == "Comedy")
            {
                resultLabel.Text = "PENIS!";
                filmImg.ImageUrl = "comedy.png";
            }
            else
            {
                resultLabel.Text = "Please select an preference";
            }
        }
    }
}