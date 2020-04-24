
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Russian_Roulette
{
    //todo create a random number generator between 1 and 6. Spin event between 1 and 6. Spin Event
    //todo create a counter that only holds 2 numbers so when someone shoots away it decreases by 2 or 1 or 0
    // they can only shoot away 2 times. Put this under a button

    //todo we count down from 6 to the random number on a click Fire Event
    //When the counter == the random number then the most important thing happens!

    //if the person hits the target from that click, they win.

    //otherwise if the person does not hit the target, they lose.

    // rnd          counter         shootaway only 2X
    //3             6               no
    //3             5               no
    //3             4               no
    //3             3               yes    =>  ()  your dead         <= shoots away You live

    //3             2               no      
    //3             1               no 
    public partial class Form1 : Form
    {// using (SoundPlayer player = new SoundPlayer(C:\Users\reube\source\repos\Russian Roulette\Russian Roulette\Resources.resx)  
        //http://soundbible.com/tags-gunshot.html
        GamePlay gamePlay = new GamePlay();
        Random random = new Random();
        int RNDnumber = 0;
        int shootaway = 1;
        int count = 6;

        //  Boolean IsShootingAway = true;
        bool IsShootingAway = false;

        private void btnFire_Click(object sender, EventArgs e)
        {
            //fire code
            count--;
            pbxBowandarrow.Image = Resource1.bow_and_arrow;

            //otherwise you will die

            if (RNDnumber == count && IsShootingAway == true)//IF the random number == the count number AND you are shooting away you will win.
            {
                //you win
            }

            if (RNDnumber == count && IsShootingAway == false)//IF the random number == the count number BUT you are not shooting away you will lose.
            {
                //you lose
            }



            btnFire.Text = count.ToString();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            //ShootAwayCountdown();
            gamePlay.ShootAwayCountdown();
            int count = 6;
            ShootAwayCountDown = 1;
            pbxbowandarrow.Image = Resource1.bow_and_arrow;

            soundPlayer player = new soundPlayer(Properties.Resources.Gunshot.wav);

            player.PlaySync();

        }

        private void ShootAwayCountDown()
        {
            //shootaway button
            shootaway--;

            if (shootaway > 0)
            {
                //boolean you can shoot
                IsShootingAway = true;
            }
            else
            {
                //you can't shoot
                IsShootingAway = false;
            }
        }




        private void btnRepeat_Click(object sender, EventArgs e)
        {
            //Reset Shoot Score
            shootaway Score = 0;

            RNDnumber = random.Next(7);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();

        }
    }
}
