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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        Startup frmStart = new Startup();
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            frmStart.Show();
        }

        private void Game_Load(object sender, EventArgs e)
        {

            
        }

       
    }
}
