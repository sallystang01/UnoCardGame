namespace Uno
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGamePlayerFour = new System.Windows.Forms.Label();
            this.lblGamePlayerThree = new System.Windows.Forms.Label();
            this.lblGamePlayerTwo = new System.Windows.Forms.Label();
            this.lblGamePlayerOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGamePlayerFour
            // 
            this.lblGamePlayerFour.AutoSize = true;
            this.lblGamePlayerFour.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePlayerFour.Location = new System.Drawing.Point(12, 299);
            this.lblGamePlayerFour.Name = "lblGamePlayerFour";
            this.lblGamePlayerFour.Size = new System.Drawing.Size(86, 23);
            this.lblGamePlayerFour.TabIndex = 16;
            this.lblGamePlayerFour.Text = "Player 4:";
            this.lblGamePlayerFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamePlayerThree
            // 
            this.lblGamePlayerThree.AutoSize = true;
            this.lblGamePlayerThree.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePlayerThree.Location = new System.Drawing.Point(12, 196);
            this.lblGamePlayerThree.Name = "lblGamePlayerThree";
            this.lblGamePlayerThree.Size = new System.Drawing.Size(86, 23);
            this.lblGamePlayerThree.TabIndex = 14;
            this.lblGamePlayerThree.Text = "Player 3:";
            this.lblGamePlayerThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamePlayerTwo
            // 
            this.lblGamePlayerTwo.AutoSize = true;
            this.lblGamePlayerTwo.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePlayerTwo.Location = new System.Drawing.Point(12, 94);
            this.lblGamePlayerTwo.Name = "lblGamePlayerTwo";
            this.lblGamePlayerTwo.Size = new System.Drawing.Size(86, 23);
            this.lblGamePlayerTwo.TabIndex = 12;
            this.lblGamePlayerTwo.Text = "Player 2:";
            this.lblGamePlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamePlayerOne
            // 
            this.lblGamePlayerOne.AutoSize = true;
            this.lblGamePlayerOne.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePlayerOne.Location = new System.Drawing.Point(12, 15);
            this.lblGamePlayerOne.Name = "lblGamePlayerOne";
            this.lblGamePlayerOne.Size = new System.Drawing.Size(86, 23);
            this.lblGamePlayerOne.TabIndex = 10;
            this.lblGamePlayerOne.Text = "Player 1:";
            this.lblGamePlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 399);
            this.Controls.Add(this.lblGamePlayerFour);
            this.Controls.Add(this.lblGamePlayerThree);
            this.Controls.Add(this.lblGamePlayerTwo);
            this.Controls.Add(this.lblGamePlayerOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblGamePlayerFour;
        public System.Windows.Forms.Label lblGamePlayerThree;
        public System.Windows.Forms.Label lblGamePlayerTwo;
        public System.Windows.Forms.Label lblGamePlayerOne;
    }
}