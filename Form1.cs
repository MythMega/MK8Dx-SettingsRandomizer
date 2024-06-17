using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKSettingsRandomizer
{
    public partial class Form1 : Form
    {
        public string CC = "";
        public string AI = "";
        public string ItemMode = "";
        public string NumberOfRace = "";
        public string TeamMode = "";

        // Création d'un objet Random
        Random rand = new Random();

        public List<string> ListCCs = new List<string>
        {
            "150", "150 Mirror", "200"
        };

        public List<string> ListAIs = new List<string>
        {
            "easy", "normal", "hard", "No AI"
        };

        public List<string> ListItemMods = new List<string>
        {
            "Normal", "No coin No Items", "No Items", "Exploding"
        };

        public List<string> ListTeamMods = new List<string>
        {
            "Solo", "Team"
        };

        public List<string> ListNumbersOfRace = new List<string>
        {
            "4", "6", "8", "12", "16", "32", "48"
        };

        public List<Image> images = new List<Image>
        {
            Properties.Resources.banana,
            Properties.Resources.blooper,
            Properties.Resources.blueShell,
            Properties.Resources.bomb,
            Properties.Resources.boomerang,
            Properties.Resources.bullet,
            Properties.Resources.coin,
            Properties.Resources.eight,
            Properties.Resources.fireFlower,
            Properties.Resources.ghost,
            Properties.Resources.goldMushroom,
            Properties.Resources.greenShell,
            Properties.Resources.horn,
            Properties.Resources.lightning,
            Properties.Resources.multiBanana,
            Properties.Resources.multiGreenShell,
            Properties.Resources.multiRedShell,
            Properties.Resources.multiMushroom,
            Properties.Resources.mushroom,
            Properties.Resources.piranha,
            Properties.Resources.redShell,
            Properties.Resources.star,
        }
        ;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void randomize_Click(object sender, EventArgs e)
        {
            noItems();

            if(rand.Next(0,2) == 1)
            {
                rollItem();
                ItemMode = "Custom";
                lblInfoItem.Text = "Items :";
            }
            else
            {
                ItemMode = ListItemMods[rand.Next(ListItemMods.Count)];
                lblInfoItem.Text = $"Item mode : {ItemMode}";
                setItem();
            }
            AI = ListAIs[rand.Next(ListAIs.Count)];
            CC = ListCCs[rand.Next(ListCCs.Count)];
            calculNumerOfRace();
            TeamMode = ListTeamMods[rand.Next(ListTeamMods.Count)];

            setLbl();
        }

        private void calculNumerOfRace()
        {
            bool valide = false;
            while(!valide)
            {
                NumberOfRace = ListNumbersOfRace[rand.Next(ListNumbersOfRace.Count)];
                if(int.Parse(NumberOfRace) <= int.Parse(comboBox1.SelectedItem.ToString()) ) { valide = true; }
            }
        }

        private void setItem()
        {
            switch(ItemMode)
            {
                case "Normal":
                    pictureBox1.Image = Properties.Resources.item;
                    pictureBox2.Image = Properties.Resources.item;
                    pictureBox3.Image = Properties.Resources.item;
                    break;

                case "No coin No Items":
                    pictureBox1.Image = Properties.Resources.no_item_no_coin;
                    pictureBox2.Image = Properties.Resources.no_item_no_coin;
                    pictureBox3.Image = Properties.Resources.no_item_no_coin;
                    break;

                case "No Items":
                    pictureBox1.Image = Properties.Resources.no_item;
                    pictureBox2.Image = Properties.Resources.no_item;
                    pictureBox3.Image = Properties.Resources.no_item;
                    break;

                case "Exploding":
                    pictureBox1.Image = Properties.Resources.bomb;
                    pictureBox2.Image = Properties.Resources.bomb;
                    pictureBox3.Image = Properties.Resources.bomb;
                    break;
            }
        }

        private void noItems()
        {
            pictureBox1.Image = Properties.Resources.no_item;
            pictureBox2.Image = Properties.Resources.no_item;
            pictureBox3.Image = Properties.Resources.no_item;
        }

        private void rollItem()
        {
            noItems();

            List<Image> mesImages = images.OrderBy(x => rand.Next()).ToList();
            int num = new Random().NextDouble() < 0.5 ? 1 : (new Random().NextDouble() < 0.5 ? 2 : 3);

            switch (num)
            {
                case 1:
                    pictureBox1.Image = mesImages[0];
                    break;
                case 2:
                    pictureBox1.Image = mesImages[0];
                    pictureBox2.Image = mesImages[1];
                    break;
                case 3:
                    pictureBox1.Image = mesImages[0];
                    pictureBox2.Image = mesImages[1];
                    pictureBox3.Image = mesImages[2];
                    break;
            }
        }

        private void setLbl()
        {
            lblAI.Text = $"AI : {AI}";
            lblCC.Text = $"CC : {CC}";
            lblInfoItem.Text = $"Item mode : {ItemMode}";
            lblNbrCourse.Text = $"Race count : {NumberOfRace}";
            lblTeamMode.Text = $"Mode : {TeamMode}";

            setVisibles();
        }

        private void setVisibles()
        {
            lblCC.Visible = cbCC.Checked;
            lblTeamMode.Visible = cbTeam.Checked;
            lblNbrCourse.Visible = cbRaceCount.Checked;
            comboBox1.Visible = cbRaceCount.Checked;
            label1.Visible = cbRaceCount.Checked;
        }

        private void Checkboxes(object sender, EventArgs e)
        {
            setVisibles();
        }
    }
}
