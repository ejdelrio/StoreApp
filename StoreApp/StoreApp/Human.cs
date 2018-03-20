using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    abstract public class Human
    {
        private string status = "Alive";
        private int numberOfLegs = 2;
        private int numberOfArms = 2;


        public void loseArm()
        {
            if (numberOfArms == 0) throw new ArgumentException("No arms left to lose");
            numberOfArms--;
        }

        public void loseLeg()
        {
            if (numberOfLegs == 0) throw new ArgumentException("No legs left to lose");
            numberOfLegs--;
        }

        public void die()
        {
            if (status == "Dead") throw new ArgumentException("Person is already dead.");
            status = "Dead";
        }
    }
}
