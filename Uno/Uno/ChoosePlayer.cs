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

       
        public int[] Wins = new int[20];
        public string[] DatePlayed = new string[20];

        Players cPlayers = new Players();
        Startup frmStart = new Startup();

        private void ChoosePlayer_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("Players.csv");
            string line;
            int count = 0;

            char[] delim = { ',' };

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                string[] tokens = line.Split(delim);
                lbPlayers.Items.Add(tokens[0]);
            }
            sr.Close();
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
                    sw.Close();

                    lbPlayers.Items.Add(newPlayer);
                }
            }
            catch
            {
                MessageBox.Show("Error...");
            }
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

