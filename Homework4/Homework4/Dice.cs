using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Dice
    {
        private Random rand; 

        public Dice()
        {
            this.rand = new Random();
            
        }
        public int Roll1Die()
        {
            // gives 1 random number, since it's 1 dice
            return rand.Next(1, 7);
        }
        public int Roll2Dice()
        {
            //gives 2 random numbers since it's 2
            return (rand.Next(1, 7) + rand.Next(1, 7));
        }
    }
}
