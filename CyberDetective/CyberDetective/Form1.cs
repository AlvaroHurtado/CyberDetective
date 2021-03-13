using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberDetective
{
    public partial class frmCyberDetective : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        bool hasKey;

        int jumpSpeed = 10;
        int force = 8;
        int playerSpeed = 10;
        int backgroundSpeed = 8;

        public frmCyberDetective()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }
        }

        private void GeneralTimer(object sender, EventArgs e)
        {
            pctPlayer.Top += jumpSpeed;

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }


            if (goleft == true && pctPlayer.Left > 60)
            {
                pctPlayer.Left -= playerSpeed;
                pctPlayer.Image = Properties.Resources.Cyber_left;
            }
            if (goright == true && pctPlayer.Left + (pctPlayer.Width + 60) < this.ClientSize.Width)
            {
                pctPlayer.Left += playerSpeed;
                pctPlayer.Image = Properties.Resources.Cyber_right;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (pctPlayer.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        pctPlayer.Top = x.Top - pctPlayer.Height;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    if (pctPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        MainTimer.Stop();
                        MessageBox.Show("Has Muerto!" + Environment.NewLine + "Pulsa ACEPTAR para jugar de nuevo");
                        RestartGame();
                    }
                }
            }

            if (pctPlayer.Bounds.IntersectsWith(pctKey.Bounds))
            {
                pctKey.Visible = false;
                hasKey = true;
            }

            if (pctPlayer.Bounds.IntersectsWith(pctDoor.Bounds) && hasKey == true)
            {
                pctDoor.Image = Properties.Resources.effect;
                MainTimer.Stop();
                MessageBox.Show("Buen trabajo, has ganado el juego!" + Environment.NewLine + "Pulsa ACEPTAR para jugar de nuevo");
                RestartGame();
            }

            if (pctPlayer.Top + pctPlayer.Height > this.ClientSize.Height)
            {
                MainTimer.Stop();
                MessageBox.Show("Has Muerto!" + Environment.NewLine + "Pulsa ACEPTAR para jugar de nuevo");
                RestartGame();
            }

            if (goleft == true && pctBackground.Left < 0)
            {
                pctBackground.Left += backgroundSpeed;
                MoveGameElements("forward");
            }

            if (goright == true && pctBackground.Left > -1216)
            {
                pctBackground.Left -= backgroundSpeed;
                MoveGameElements("back");
            }
        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RestartGame()
        {
            frmCyberDetective newWindow = new frmCyberDetective();
            newWindow.Show();
            this.Hide();
        }

        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "enemy" || x is PictureBox && (string)x.Tag == "key" || x is PictureBox && (string)x.Tag == "door")
                {
                    if (direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }
                    if (direction == "forward")
                    {
                        x.Left += backgroundSpeed;
                    }
                }
            }
        }

    }
}
