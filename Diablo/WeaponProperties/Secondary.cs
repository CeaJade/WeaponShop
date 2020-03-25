using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Secondary
    {
        public string Type { get; set; }

        public int Value { get; set; }

        public Secondary(string type, int value)
        {
            this.Type = type;
            this.Value = value;
        }

        public static List<Secondary> GetSecondaries(int amount)
        {
            List<string> options = new List<string>();
            options.Add("Extra bleed damage");
            options.Add("Fire resistant");
            options.Add("% Extra EXP");
            options.Add("% Chance to stun");
            List<Secondary> secondaries = new List<Secondary>();
            Random rdm = new Random();
            for (int i = 0; i < amount; i++)
            {
                if (options.Count() == 0) break;

                int pick = rdm.Next(0, options.Count());
                secondaries.Add(new Secondary(options[pick], rdm.Next(rdm.Next(2, 4), rdm.Next(6, 8))));
                options.RemoveAt(pick);
            }
            return secondaries;
        }
    }
}
