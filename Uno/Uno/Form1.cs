using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }
        public static Game frmGame = new Game();
        private void Startup_Load(object sender, EventArgs e)
        {
            try
            {
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

        private void cbPlayerTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbPlayerTwo.Text != "Player Type..")
            {
                tbPlayerTwo.Enabled = true;
                tbPlayerTwo.Focus();
            }
        }

        private void cbPlayerThree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlayerThree.Text != "Player Type..")
            {
                tbPlayerThree.Enabled = true;
                tbPlayerThree.Focus();
            }
        }

        private void cbPlayerFour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlayerFour.Text != "Player Type..")
            {
                tbPlayerFour.Enabled = true;
                tbPlayerFour.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNumberOfPlayers.Text == "2")
            {
                cbPlayerTwo.Enabled = true;
                cbPlayerThree.Enabled = false;
                cbPlayerFour.Enabled = false;
            }
            if (cbNumberOfPlayers.Text == "3")
            {
                cbPlayerTwo.Enabled = true;
                cbPlayerThree.Enabled = true;
                cbPlayerFour.Enabled = false;
            }
            if (cbNumberOfPlayers.Text == "4")
            {
                cbPlayerTwo.Enabled = true;
                cbPlayerThree.Enabled = true;
                cbPlayerFour.Enabled = true;
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {


            try
            {
               
                if (cbPlayerTwo.Enabled == false)
                {
                    MessageBox.Show("You need at least two players to get started!");
                }
                else if (tbPlayerTwo.Enabled == false & cbPlayerTwo.Enabled == true)
                {
                    MessageBox.Show("Please choose the player type for Player Two!");
                }

                else if (tbPlayerThree.Enabled == false & cbNumberOfPlayers.Text == "3")
                {
                    MessageBox.Show("Please choose the player type for Player Three!");
                }
                else if (tbPlayerFour.Enabled == false & cbNumberOfPlayers.Text == "4")
                {
                    MessageBox.Show("Please choose the player type for Player Four!");
                }

                else
                {
                    this.Visible = false;
                    frmGame.Show();
                    
                }

                if (cbNumberOfPlayers.Text == "2")
                {
                    frmGame.lblGamePlayerThree.BackColor = Color.Gray;
                    frmGame.lblGamePlayerFour.BackColor = Color.Gray;

                }
                else if (cbNumberOfPlayers.Text == "3")
                {

                    frmGame.lblGamePlayerFour.BackColor = Color.Gray;

                }


            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void Startup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
