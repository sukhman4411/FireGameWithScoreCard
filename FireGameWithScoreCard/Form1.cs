using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGameWithScoreCard
{
    public partial class Form1 : Form
    {

        Game.Class1 obj = null;

        int clk = 0, click = 0;
        int sound = 0, reply = 0;
        int gun = 0, chance = 0, shoot = 0;
        public Form1()
        {
            InitializeComponent();
            obj = new Game.Class1();
            sound = obj.sound();
            shoot = obj.shoot();

        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            clk = 1;
            if (clk == 1)
            {
                //loading the empty image of the gun 
                picture.Image = FireGameWithScoreCard.Properties.Resources.emprt;
                buttonStart.Enabled = false;
                ButtonLoad.Enabled = true;
            }
            else
            {
                MessageBox.Show("follow the sequence");
            }

        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            clk = 2;
            if (clk == 2)
            {
                // loading the bullet in the gun.
                picture.Image = FireGameWithScoreCard.Properties.Resources.Loading_Bullet;
                ButtonLoad.Enabled = false;
                ButtonSpin.Enabled = true;
            }
            else
            {
                MessageBox.Show("follow the sequence");
            }


        }

        private void ButtonSpin_Click(object sender, EventArgs e)
        {
            clk = 3;
            if (clk == 3)
            {
                //spin the gun after loading the bullet in the gun u have only 2 bullet to fire in 6 trigger
                picture.Image = FireGameWithScoreCard.Properties.Resources.spingif;
                ButtonSpin.Enabled = false;
                ButtonShoot.Enabled = true;
                button1.Enabled = true;
                lblBullet.Text = "" + obj.Trigger();
            }
            else
            {
                MessageBox.Show("follow the sequence ");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gun++;
            if (gun == shoot && chance < 2)
            {
                picture.Image = FireGameWithScoreCard.Properties.Resources.shootImage;
                System.Media.SoundPlayer obj_sound = new System.Media.SoundPlayer(FireGameWithScoreCard.Properties.Resources.fire);
                obj_sound.Play();
                chance++;
                gun = 0;
                shoot = obj.shoot();
                // MessageBox.Show("ok");

            }


            if (chance == 2)
            {
                MessageBox.Show("Game is over now ");
                button1.Enabled = false;
            }

        }

        private void ButtonTry_Click(object sender, EventArgs e)
        {
            reply++;
            if (reply <= 2)
            {
                MessageBox.Show("This is your last chance to play ");
                //reload the method and variable to reset the game again 
                clk = 0;
                ButtonShoot.Enabled = false;
                buttonStart.Enabled = true;
                sound = obj.sound();
                obj = new Game.Class1();
                lblBullet.Text = "";
                lblTrigger.Text = "";
                click = 0;
            }
            else
            {
                MessageBox.Show("Chances are over now");
                System.Environment.Exit(0);
            }


        }

        private void ButtonShoot_Click(object sender, EventArgs e)
        {
            clk = 4;
            int fire = 0;
            if (obj.fireGun(clk) == 1)
            {
                click++;


                fire = obj.chance();
                if (fire > 0)
                {
                    lblTrigger.Text = "" + fire;



                    if (click == sound)
                    {

                        lblBullet.Text = "" + obj.Trigger();
                        picture.Image = FireGameWithScoreCard.Properties.Resources.shootImage;
                        System.Media.SoundPlayer obj_sound = new System.Media.SoundPlayer(FireGameWithScoreCard.Properties.Resources.fire);
                        obj_sound.Play();

                    }
                    else
                    {
                        picture.Image = FireGameWithScoreCard.Properties.Resources.emptyTrigger;

                    }

                }
                else
                {
                    ButtonShoot.Enabled = false;
                    ButtonTry.Enabled = true;

                    MessageBox.Show("Bullet finished ");

                }

            }
        }
    }
}
