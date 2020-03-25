using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public abstract class Weapon
    {
        private string Name { get; set; }

        private int Damage { get; set; }

        public Rarity Rarity { get; set; }

        private List<Primary> PrimaryStats { get; set; }

        private List<Secondary> SecondaryStats { get; set; }

        private List<Magic> MagicStats { get; set; }
        
        public Weapon(string name, int dmg, Rarity rarity)
        {
            Name = name;
            Damage = dmg;
            Rarity = rarity;
        }

        public void AddPrimaryStats(List<Primary> primaryStats)
        {
            this.PrimaryStats = primaryStats;
        }

        public void AddSecondaryStats(List<Secondary> secondaryStats)
        {
            this.SecondaryStats = secondaryStats;
        }

        public void AddMagicStats(List<Magic> magicStats)
        {
            this.MagicStats = magicStats;
        }

        public string ToString(bool owned)
        {
            if (owned == false)
            {
                if (this.Rarity.RarityLevel == 1)
                {
                    return Rarity.GetRarity() + " " + Name + " \nDamage: " + Damage + "\nOne of 4 primary properties \nOne of 4 secondary properties \nTwo of 7 magic properties";
                }
                else if (this.Rarity.RarityLevel == 2)
                {
                    return Rarity.GetRarity() + " " + Name + " \nDamage: " + Damage + "\nTwo of 4 primary properties \nTwo of 4 secondary properties \nFour of 7 magic properties";
                }
                else if (this.Rarity.RarityLevel == 3)
                {
                    return Rarity.GetRarity() + " " + Name + " \nDamage: " + Damage + "\nThree of 4 primary properties \nThree 4 secondary properties \nSix of 7 magic properties";
                }
                else
                {
                    return Rarity.GetRarity() + " " + Name + " \nDamage: " + Damage;
                }
            }
            else
            {
                if (this.Rarity.RarityLevel >= 1)
                {
                    string primary = "";
                    foreach (Primary prim in PrimaryStats)
                    {
                        primary += " " + prim.Type + ": +" + prim.Value + "\n";
                    }
                    string secondary = "";
                    foreach (Secondary secon in SecondaryStats)
                    {
                        secondary += " " + secon.Type + ": +" + secon.Value + "\n";
                    }
                    string magic = "";
                    foreach (Magic mag in MagicStats)
                    {
                        magic += " " + mag.Type + ": +" + mag.Value + "\n";
                    }

                    return Rarity.GetRarity() + " " + Name + " \nDamage: " + Damage + "\n\nPrimary:\n" + primary + "\n\nSecondary:\n" + secondary + "\n\nMagic:\n" + magic;
                }
                else
                {
                    return Rarity.GetRarity() + " " + Name + " \nDamage: " + Damage;
                }
            }
        }
    }
}
