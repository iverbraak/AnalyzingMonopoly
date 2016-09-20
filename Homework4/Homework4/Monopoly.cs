using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Monopoly
    {
        private Dice dice;
        private String[] propertyNames = 
        {
	        "Go",
	        "Mediterranean Avenue",
	        "Community Chest (1)",
	        "Baltic Avenue",
	        "Income Tax",
	        "Reading Railroad",
	        "Oriental Avenue",
	        "Chance (1)", 
	        "Vermont Avenue",
	        "Connecticut Avenue",
	        "Jail",
	        "St. Charles Place",
	        "Electric Company",
	        "States Avenue",
	        "Virginia Avenue",
	        "Pennsylvania Railroad",
	        "St. James Place",
	        "Community Chest (2)",
            "Tennessee Avenue",
	        "New York Avenue",
	        "Free Parking",
	        "Kentucky Avenue",
	        "Chance (2)", 
	        "Indiana Avenue",
	        "Illinois Avenue",
	        "B&O Railroad",
	        "Atlantic Avenue",
	        "Ventnor Avenue",
	        "Water Works",
	        "Marvin Gardens",
	        "Go To Jail",
	        "Pacific Avenue",
	        "North Carolina Avenue",
	        "Community Chest (3)",
	        "Pennsylvania Avenue",
	        "Short Line Railroad",
	        "Chance (3)",
	        "Park Place",
	        "Luxury Tax",
	        "Boardwalk" 
       };
        private const int  nPlayers = 100000;
        private const int nTimes = 25;

        public Monopoly()
        {
            dice = new Dice();
            
        }
        public double[] Analyze()
        {
            int[] visits = new int[propertyNames.Length]; 
            
            for(int i=0; i<nPlayers; i++)
            {
                int pLocation = 0;
                int pTimes = 1;

                while(pTimes < nTimes)
                {
                    pLocation += dice.Roll2Dice();
                    if(pLocation > 39)
                    {
                        pLocation %= 40;
                        pTimes++; 
                    }
                    //for when they land on go to jail
                    if(pLocation == 30)
                    {
                        pTimes++;
                        visits[pLocation]++;
                        pLocation = 10;

                    }
                    else
                    {
                        visits[pLocation]++;
                    }                    
                }
            }

            double[] pPercent = new double[propertyNames.Length];
            int sumOfArray = 0;
            for(int i=0; i<propertyNames.Length; i++)
            {
                sumOfArray += visits[i];
            }
            for(int j=0; j<visits.Length; j++)
            {
                pPercent[j] = ((double)visits[j] / (double)sumOfArray) * 100;
            }
            return pPercent;
        }
        public void PrintResults(double[] percentVisit)
        {
            for(int i=0; i<propertyNames.Length; i++)
            {
                Console.WriteLine(propertyNames[i] + ": " +"{0:F2}", percentVisit[i]);
            }
        }
    }
}
