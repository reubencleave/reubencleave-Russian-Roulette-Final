using System;

namespace Russian_Roulette
{

    class GamePlay
    {
        int shootaway = 2;
        public Boolean CanIshootaway = true;
        public bool IsShootingAway = false;

        public void ShootAwayCountDown()
        {
            //shootaway button
            shootaway--;

            if (shootaway > 0)
            {
                //boolean you can shoot
                CanIshootaway = true;
            }
            else
            {
                //you can't shoot
                CanIshootaway = false;
            }
        }
    }
}


