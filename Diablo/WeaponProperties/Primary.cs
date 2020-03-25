using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Primary
    {
        public string PrimPropType { get; set; }

        public int Value { get; set; }

        public Primary(string type, int value)
        {
            this.PrimPropType = type;
            this.Value = value;
        }

        public static List<Primary> GetPrimaries(int amount)
        {
            List<string> options = new List<string>();
            options.Add("Attack");
            options.Add("Armor");
            options.Add("Crit damage");
            options.Add("% Crit rate");
            List<Primary> primaries = new List<Primary>();
            Random rdm = new Random();
            for (int i = 0; i < amount; i++)
            {
                if (options.Count() == 0) break;

                int pick = rdm.Next(0, options.Count());
                primaries.Add(new Primary(options[pick], rdm.Next(rdm.Next(2, 4), rdm.Next(6, 8))));
                options.RemoveAt(pick);
            }
            return primaries;
        }
    }
}
