using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{

    public class Class1
    {
        //global variable to show the count of the gun 
        int fire = 6;
        int chnc = 1;
        //this method pass the value of the trigger and decrement by one always
        public int chance()
        {
            return fire--;
        }
        public int fireGun(int y)
        {
            if (y >= 4)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // count the fire bullet
        public int Trigger()
        {
            return chnc--;
        }
        //get the random number to trigger the bullet and generate the sound 
        public int sound()
        {
            Random obj = new Random();
            return obj.Next(1, 6);
        }

        public int shoot()
        {
            Random obj = new Random();
            return obj.Next(1, 3);

        }


    }
}
