using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Elements
{
    public partial class ElementTest : MaterialForm
    {

        static HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
        HtmlAgilityPack.HtmlDocument doc = web.Load("https://en.wikipedia.org/wiki/List_of_chemical_elements");
        int randomNum = 1;
        Random rnd = new Random();


        public ElementTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roll();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(randomNum - 4);
            label3.Text = doc.DocumentNode.SelectSingleNode("/html/body/div[3]/div[3]/div[5]/div[1]/table/tbody/tr[" + randomNum + "]/td[3]/a").InnerText;
            
            if (nameCheck.Checked)
            {
                ScoreName();
            }

            if (numCheck.Checked)
            {
                ScoreNum();
            }

            button2.Enabled = false;
        }

        void ScoreName()
        {
            if (nameIn.Text.Equals(label3.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                nameScore.Text = (Convert.ToInt32(nameScore.Text) + 1).ToString();
            }
            else
            {
                nameScore.Text = (Convert.ToInt32(nameScore.Text) - 1).ToString();
            }
        }

        void ScoreNum()
        {
            if (numIn.Text == label2.Text)
            {
                numScore.Text = (Convert.ToInt32(numScore.Text) + 1).ToString();
            }
            else
            {
                numScore.Text = (Convert.ToInt32(numScore.Text) - 1).ToString();
            }
        }

        void Roll()
        {
            randomNum = rnd.Next(Convert.ToInt32(numericUpDown1.Value) + 4, Convert.ToInt32(numericUpDown2.Value) + 5);
            Console.WriteLine(randomNum);
            Console.WriteLine("/html/body/div[3]/div[3]/div[5]/div[1]/table/tbody/tr[" + randomNum + "]/td[2]");
            label1.Text = doc.DocumentNode.SelectSingleNode("/html/body/div[3]/div[3]/div[5]/div[1]/table/tbody/tr[" + randomNum + "]/td[2]").InnerText;
            label2.Text = "?";
            label3.Text = "?";
            nameIn.Clear();
            numIn.Clear();
        }
    }
}


