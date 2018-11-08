using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSeven
{
    public partial class SpyTracker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] kills = new int[0];

                ViewState.Add("ASSETS", assets);
                ViewState.Add("ELECTIONS", elections);
                ViewState.Add("KILLS", kills);

            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] asset = (string[])ViewState["ASSETS"];
            int[] elections = (int[])ViewState["ELECTIONS"];
            int[] kills = (int[])ViewState["KILLS"];

            int newLength = asset.Length + 1;
            Array.Resize(ref asset, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref kills, newLength);

            int newIndex = asset.GetUpperBound(0);

            asset[newIndex] = nameBox.Text;
            elections[newIndex] = int.Parse(electBox.Text);
            kills[newIndex] = int.Parse(killBox.Text);

            ViewState["ASSETS"] = asset;
            ViewState["ELECTIONS"] = elections;
            ViewState["KILLS"] = kills;


            resultLabel.Text = String.Format("ASSET: {0}<br/>" +
                "{1} HAS RIGGED {2} ELECTIONS.<br/>" +
                "{3} HAS PERFORMED {4:N2} ASSASSINATIONS.<br/>"+
                "[NEWEST ADDITION: {5}]", nameBox.Text, nameBox.Text,  elections.Sum(), nameBox.Text, kills.Average(), asset[newIndex]);

            nameBox.Text = "";
            electBox.Text = "";
            killBox.Text = "";
        }
    }
}