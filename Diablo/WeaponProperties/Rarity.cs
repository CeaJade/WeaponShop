using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Diablo
{
    public class Rarity
    {
        public int RarityLevel { get; set; }

        static private Random rdm = new Random();

        public Rarity()
        {
            int i;
            i = rdm.Next(0, 100);
            if (i <= 50)
                RarityLevel = 0;
            else if (i <= 75)
                RarityLevel = 1;
            else if (i <= 90)
                RarityLevel = 2;
            else 
                RarityLevel = 3;
        }

        public ConsoleColor GetRarityColor()
        {
            if (RarityLevel == 1)
            {
                return ConsoleColor.Green;
            }
            if (RarityLevel == 2)
            {
                return ConsoleColor.Blue;
            }
            if (RarityLevel == 3)
            {
                return ConsoleColor.Yellow;
            }
            else
            {
                return ConsoleColor.White;
            }
        }

        public string GetRarity()
        {
            if (RarityLevel == 0)
            {
                return "Common";
            }
            else if (RarityLevel == 1)
            {
                return "Uncommon";
            }
            else if (RarityLevel == 2)
            {
                return "Rare";
            }
            else 
            {
                return "Legendary";
            }
        }
    }
}
