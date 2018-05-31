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
                btnLoadPlayerTwo.Enabled = true;
                btnLoadPlayerTwo.Focus();
            }
        }

        private void cbPlayerThree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlayerThree.Text != "Player Type..")
            {
                btnLoadPlayerThree.Enabled = true;
                btnLoadPlayerThree.Focus();
            }
        }

        private void cbPlayerFour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlayerFour.Text != "Player Type..")
            {
                btnLoadPlayerFour.Enabled = true;
                btnLoadPlayerFour.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNumberOfPlayers.Text == "2")
            {
                btnLoadPlayerTwo.Enabled = true;
                btnLoadPlayerThree.Enabled = false;
                btnLoadPlayerFour.Enabled = false;
            }
            if (cbNumberOfPlayers.Text == "3")
            {
                btnLoadPlayerTwo.Enabled = true;
                btnLoadPlayerThree.Enabled = true;
                btnLoadPlayerFour.Enabled = false;
            }
            if (cbNumberOfPlayers.Text == "4")
            {
                btnLoadPlayerTwo.Enabled = true;
                btnLoadPlayerThree.Enabled = true;
                btnLoadPlayerFour.Enabled = true;
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
                else if (btnLoadPlayerTwo.Enabled == false & cbPlayerTwo.Enabled == true)
                {
                    MessageBox.Show("Please choose the player type for Player Two!");
                }

                else if (btnLoadPlayerThree.Enabled == false & cbNumberOfPlayers.Text == "3")
                {
                    MessageBox.Show("Please choose the player type for Player Three!");
                }
                else if (btnLoadPlayerFour.Enabled == false & cbNumberOfPlayers.Text == "4")
                {
                    MessageBox.Show("Please choose the player type for Player Four!");
                }

                else
                {
                    this.Visible = false;
                    frmGame.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            try
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

            
        

        private void Startup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Startup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLoadPlayerOne_Click(object sender, EventArgs e)
        {
            ChoosePlayer frmChoose = new ChoosePlayer();

            frmChoose.Show();

        }
    }
}
