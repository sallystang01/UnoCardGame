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
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        // Backing variables for things later on
        public string[] Player = new string[20];
        public int[] Wins = new int[20];
        public string[] DatePlayed = new string[20];

        // Variables that will be passed to my Players class later on
        public string p1Name;
        public int p1Wins;
        public string p2Name;
        public int p2Wins;
        public string p3Name;
        public int p3Wins;
        public string p4Name;
        public int p4Wins;

        // Establishes my Game form that will be used later on
        public static Game frmGame = new Game();

        private void Startup_Load(object sender, EventArgs e)
        {

            // Error handeling
            try
            {

                // Stream reader that will read my players.csv file
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



            try
            {
                // Initialization of controls on the form
                tbPlayerOne.Text = "P1";
                cbPlayerTwo.Enabled = false;
                cbPlayerThree.Enabled = false;
                cbPlayerFour.Enabled = false;

                if (cbPlayerTwo.Text == "")
                {
                    tbPlayerTwo.Text = "P2";
                }
                if (cbPlayerThree.Text == "")
                {
                    tbPlayerThree.Text = "P3";
                }
                if (cbPlayerFour.Text == "")
                {
                    tbPlayerFour.Text = "P4";
                }
            }

            catch
            {
                MessageBox.Show("error..");
            }

        }

        
        // Combo box control to select how many players are going to be playing
        // Changes control propertiest depending on the number of players selected
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNumberOfPlayers.Text == "2")
            {
                btnLoadPtwo.Enabled = true;
                btnLoadPthree.Enabled = false;
                btnLoadPfour.Enabled = false;
            }
            if (cbNumberOfPlayers.Text == "3")
            {
                btnLoadPtwo.Enabled = true;
                btnLoadPthree.Enabled = true;
                btnLoadPfour.Enabled = false;
            }
            if (cbNumberOfPlayers.Text == "4")
            {
                btnLoadPtwo.Enabled = true;
                btnLoadPthree.Enabled = true;
                btnLoadPfour.Enabled = true;
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {


            try
            {
                // Prevents game from starting if these criteria are not met
                if (cbPlayerTwo.Enabled == false)
                {
                    MessageBox.Show("You need at least two players to get started!");
                }
                else if (btnLoadPtwo.Enabled == false & cbPlayerTwo.Enabled == true)
                {
                    MessageBox.Show("Please choose the player type for Player Two!");
                }

                else if (btnLoadPthree.Enabled == false & cbNumberOfPlayers.Text == "3")
                {
                    MessageBox.Show("Please choose the player type for Player Three!");
                }
                else if (btnLoadPfour.Enabled == false & cbNumberOfPlayers.Text == "4")
                {
                    MessageBox.Show("Please choose the player type for Player Four!");
                }

                else
                {
                    // If the criteria was met, start the game and set the control's properties to the below
                    this.Visible = false;
                    frmGame.lblGamePlayerOne.Text = tbPlayerOne.Text;
                    frmGame.lblGamePlayerTwo.Text = tbPlayerTwo.Text;
                    frmGame.lblGamePlayerThree.Text = tbPlayerThree.Text;
                    frmGame.lblGamePlayerFour.Text = tbPlayerFour.Text;
                    frmGame.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            try
                // Determines how many players are playing so it can change properties of controls on Game form.
                {
                if (cbNumberOfPlayers.Text == "2")
                {
                    frmGame.lblGamePlayerThree.BackColor = Color.Gray;
                    frmGame.lblGamePlayerFour.BackColor = Color.Gray;

                }
                else if (cbNumberOfPlayers.Text == "3")
                {

                    frmGame.lblGamePlayerThree.BackColor = Color.Transparent;
                    frmGame.lblGamePlayerFour.BackColor = Color.Gray;

                }

                else if (cbNumberOfPlayers.Text == "4")
                {

                    frmGame.lblGamePlayerThree.BackColor = Color.Transparent;
                    frmGame.lblGamePlayerFour.BackColor = Color.Transparent;
                }
                }
              

                catch
                {
                    MessageBox.Show("Error..");
                }

               

                



            }

        

        

        // Updates the labels and displays the information stored in the players.csv file for 
        // the current player that is selected
        private void lbPlayers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblWins.Text = Wins[lbPlayers.SelectedIndex].ToString();
            lblDate.Text = DatePlayed[lbPlayers.SelectedIndex];
            lblPlayerName.Text = Player[lbPlayers.SelectedIndex];
        }

      

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            try
            { // If not text was entered then display a messagebox
                if (tbNewPlayer.Text == "")
                {
                    MessageBox.Show("Please enter a name!");

                }
                else
                {
                    // Enter the new name into the palyers.csv text file
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

        private void btnLoadPone_Click(object sender, EventArgs e)
        {

            // When this button is clicked, the following will happen:
            lblChoose.Text = "Choose a Player1";

            lbPlayers.Visible = true;
            lblChoose.Visible = true;
            lblDate.Visible = true;
            lblWins.Visible = true;
            tbNewPlayer.Visible = true;
            btnNew.Visible = true;
            btnLoad.Visible = true;
            lblPlayerName.Visible = true;

        }

        private void btnLoad_Click_2(object sender, EventArgs e)
        {
            // If no name was selected

            if (p1Name == "")
            {

                MessageBox.Show("Please choose a player first!");

            }
            else
            {
                // Sends information about selected player to my players class then sends it back to the form
                if (lblChoose.Text == "Choose a Player1")
                {

                    p1Name = lblPlayerName.Text;
                    p1Wins = int.Parse(lblWins.Text);

                    var playerone = new Players(p1Name, p1Wins);
                    tbPlayerOne.Text = playerone.Name;

                    lbPlayers.Visible = false;
                    lblChoose.Visible = false;
                    lblDate.Visible = false;
                    lblWins.Visible = false;
                    tbNewPlayer.Visible = false;
                    btnNew.Visible = false;
                    btnLoad.Visible = false;
                    lblPlayerName.Visible = false;
                }
                else if (lblChoose.Text == "Choose a Player2")
                {

                    p2Name = lblPlayerName.Text;
                    p2Wins = int.Parse(lblWins.Text);

                    var playertwo = new Players(p2Name, p2Wins);
                    tbPlayerTwo.Text = playertwo.Name;

                    lbPlayers.Visible = false;
                    lblChoose.Visible = false;
                    lblDate.Visible = false;
                    lblWins.Visible = false;
                    tbNewPlayer.Visible = false;
                    btnNew.Visible = false;
                    btnLoad.Visible = false;
                    lblPlayerName.Visible = false;
                    cbPlayerTwo.Enabled = true;
                }
                else if (lblChoose.Text == "Choose a Player3")
                {

                    p3Name = lblPlayerName.Text;
                    p3Wins = int.Parse(lblWins.Text);

                    var playerthree = new Players(p3Name, p3Wins);
                    tbPlayerThree.Text = playerthree.Name;

                    lbPlayers.Visible = false;
                    lblChoose.Visible = false;
                    lblDate.Visible = false;
                    lblWins.Visible = false;
                    tbNewPlayer.Visible = false;
                    btnNew.Visible = false;
                    btnLoad.Visible = false;
                    lblPlayerName.Visible = false;
                    cbPlayerThree.Enabled = true;
                }
                else if (lblChoose.Text == "Choose a Player4")
                {

                    p4Name = lblPlayerName.Text;
                    p4Wins = int.Parse(lblWins.Text);

                    var playerfour = new Players(p4Name, p4Wins);
                    tbPlayerFour.Text = playerfour.Name;

                    lbPlayers.Visible = false;
                    lblChoose.Visible = false;
                    lblDate.Visible = false;
                    lblWins.Visible = false;
                    tbNewPlayer.Visible = false;
                    btnNew.Visible = false;
                    btnLoad.Visible = false;
                    lblPlayerName.Visible = false;
                    cbPlayerFour.Enabled = true;
                }
            }
        }

        private void btnLoadPtwo_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the following will happen:
            lblChoose.Text = "Choose a Player2";

            lbPlayers.Visible = true;
            lblChoose.Visible = true;
            lblDate.Visible = true;
            lblWins.Visible = true;
            tbNewPlayer.Visible = true;
            btnNew.Visible = true;
            btnLoad.Visible = true;
            lblPlayerName.Visible = true;
        }

        private void btnLoadPthree_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the following will happen:
            lblChoose.Text = "Choose a Player3";

            lbPlayers.Visible = true;
            lblChoose.Visible = true;
            lblDate.Visible = true;
            lblWins.Visible = true;
            tbNewPlayer.Visible = true;
            btnNew.Visible = true;
            btnLoad.Visible = true;
            lblPlayerName.Visible = true;
        }

        private void btnLoadPfour_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the following will happen:
            lblChoose.Text = "Choose a Player4";

            lbPlayers.Visible = true;
            lblChoose.Visible = true;
            lblDate.Visible = true;
            lblWins.Visible = true;
            tbNewPlayer.Visible = true;
            btnNew.Visible = true;
            btnLoad.Visible = true;
            lblPlayerName.Visible = true;
        }

        private void Startup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}

