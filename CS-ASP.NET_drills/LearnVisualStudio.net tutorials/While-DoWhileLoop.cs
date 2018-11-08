using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnVSproject
{
    public partial class While_DoWhile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            int heroHealth = 30;
            int monsterHealth = 30;

            string result = "";

            //Hero gets BONUS first attack
            monsterHealth -= random.Next(1, 10);

            int round = 0;
            result += "<br />ROUND: " + round;
            result += String.Format("<br /> Hero attacks first, leaving Monster with {0} health", monsterHealth);
            do
            {
                int heroDamage = random.Next(1, 10);
                int monsterDamage = random.Next(1, 20);

                monsterHealth -= heroDamage;
                heroHealth -= monsterDamage;

                result += "<br / >ROUND: " + ++round;
                result += String.Format("<br />Hero causes {0} damage, leaving Monster with {1} health.", heroDamage, monsterHealth);
                result += String.Format("<br />Monster causes {0} damage, leaving Hero with {1} health.", monsterDamage, heroHealth);
            } while (heroHealth > 0 && monsterHealth > 0);


                if (heroHealth == 0 && monsterHealth > 0)
            {
                result += "<br /> MONSTER WINS!";
            }
            else {
                result += "<br /> HERO WINS!";
            }
        }
    }
}