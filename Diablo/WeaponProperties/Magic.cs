using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Magic
    {
        public string Type { get; set; }

        public int Value { get; set; }

        public Magic(string type, int value)
        {
            this.Type = type;
            this.Value = value;
        }

        public static List<Magic> GetMagic(int amount)
        {
            List<string> options = new List<string>();
            options.Add("Strength");
            options.Add("Intelligence");
            options.Add("Dextarity");
            options.Add("Charisma");
            options.Add("Stamina");
            options.Add("Luck");
            options.Add("Endurance");
            List<Magic> magic = new List<Magic>();
            Random rdm = new Random();
            for (int i = 0; i < amount; i++)
            {
                if (options.Count() == 0) break;

                int pick = rdm.Next(0, options.Count());
                magic.Add(new Magic(options[pick], rdm.Next(rdm.Next(2, 4), rdm.Next(6, 8))));
                options.RemoveAt(pick);
            }
            return magic;
        }
    }
}
