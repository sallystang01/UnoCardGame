using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Uno
{
    public partial class ChoosePlayer : Form
    {
        public ChoosePlayer()
        {
            InitializeComponent();
        }

        
        public static Startup start = new Startup();
        public string[] Player = new string[20];
        public int[] Wins = new int[20];
        public string[] DatePlayed = new string[20];

        public string p1Name;
        public int p1Wins;
       




        private void ChoosePlayer_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr;
                string line;
                int count = 0;
                char[] delim = { ',' };

                sr = File.OpenText("Players.csv");

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] tokens = line.Split(delim);
                    lbPlayers.Items.Add(tokens[0]);
                    Player[count] = tokens[0];
                    Wins[count] = int.Parse(tokens[2]);
                    DatePlayed[count] = tokens[1];


                    count++;
                }

                sr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNewPlayer.Text == "")
                {
                    MessageBox.Show("Please enter a name!");

                }
                else
                {

                    string newPlayer = tbNewPlayer.Text;
                    StreamWriter sw = new StreamWriter("Players.csv", true);
                    sw.WriteLine("{0},{1},{2}", newPlayer, DateTime.Now.Date, 0);
                    lbPlayers.Items.Add(newPlayer);
                    sw.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblWins.Text = Wins[lbPlayers.SelectedIndex].ToString();
            lblDate.Text = DatePlayed[lbPlayers.SelectedIndex];
            lblPlayerName.Text = Player[lbPlayers.SelectedIndex];
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           

            if (p1Name == "")
            {

                MessageBox.Show("Please choose a player first!");

            }
            else
            {

                p1Name = lblPlayerName.Text;
                p1Wins = int.Parse(lblWins.Text);
                Players players = new Players(p1Name, p1Wins);

            }
            }
        }
    }

