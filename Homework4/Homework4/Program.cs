using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //making a new dice obj, calling both dice methods 100 times
            Dice newDie = new Dice();
            
            for(int i=0; i < 101; i++)
            {
                Console.WriteLine(newDie.Roll1Die());
                Console.WriteLine(newDie.Roll2Dice());
            }

            Monopoly newGame = new Monopoly();
            double[] gResults = newGame.Analyze();
            newGame.PrintResults(gResults);
        }
    }
}
