using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("!WEAPON SHOP!");

                Console.Write("\nWhat type of weapon do you want to buy? \n1) Axe \n2) Dagger \n3) Fist weapon \n4) Flail \n5) Knife \n6) Mace \n7) Mighty Weapon \n8) Scythe \n9) Spear \n10) Sword \n\n0) Exit Shop \nInput: ");
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("\nInvalid input, Try something else");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

         
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        BoughtWeapon(AxeMenu());
                        break;

                    case 2:
                        Console.Clear();
                        BoughtWeapon(DaggerMenu());
                        break;

                    case 3:
                        Console.Clear();
                        BoughtWeapon(FistWeapMenu()); 
                        break;

                    case 4:
                        Console.Clear();
                        BoughtWeapon(FlailMenu()); 
                        break;

                    case 5:
                        Console.Clear();
                        BoughtWeapon(KnifeMenu()); 
                        break;

                    case 6:
                        Console.Clear();
                        BoughtWeapon(MaceMenu()); 
                        break;

                    case 7:
                        Console.Clear();
                        BoughtWeapon(MightWeapMenu()); 
                        break;

                    case 8:
                        Console.Clear();
                        BoughtWeapon(ScytheMenu()); 
                        break;

                    case 9:
                        Console.Clear();
                        BoughtWeapon(SpearMenu()); 
                        break;

                    case 10:
                        Console.Clear();
                        BoughtWeapon(SwordMenu()); 
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nInvalid input, Try something else");
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BoughtWeapon(Weapon weapon)
        {
            Console.Clear();
            Console.WriteLine("\nYou have bought:\n");
            Console.ForegroundColor = weapon.Rarity.GetRarityColor();
            Console.Write(weapon.ToString(true));
            Console.ResetColor();
        }

        public static Weapon AxeMenu()
        {
            bool valid;
            int input;
            List<Weapon> axes = WeaponShop.GetAxes(2);
            do
            {
                valid = true;
                Console.Write("Which axe would you like to buy?\n");
                int i = 0;
                foreach (Axe axe in axes)
                {
                    i++;
                    Console.ForegroundColor = axe.Rarity.GetRarityColor();
                    Console.WriteLine("\n" + i + ")\n" + axe.ToString(false));
                    Console.ResetColor();
                }

                Console.Write("\nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > axes.Count() || input < 1)
                {
                    Console.WriteLine("Invalid input, try something else");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }
                
            } while (valid == false);

            return axes[input - 1];
        }

        public static Weapon DaggerMenu()
        {
            bool valid;
            int input;
            List<Weapon> daggers = WeaponShop.GetDaggers(2);
            do
            {
                valid = true;
                Console.Write("Which dagger would you like to buy?\n");
                int i = 0;
                foreach (Dagger dagger in daggers)
                {
                    i++;
                    Console.ForegroundColor = dagger.Rarity.GetRarityColor();
                    Console.WriteLine("\n" + i + ")\n" + dagger.ToString(false));
                    Console.ResetColor();
                }

                Console.Write("\nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > daggers.Count() || input < 1)
                {
                    Console.WriteLine("Invalid input, try something else");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }

            } while (valid == false);

            return daggers[input - 1];
        }

        public static Weapon FistWeapMenu()
        {
            bool valid;
            int input;
            List<Weapon> fistWeaps = WeaponShop.GetFistWeps(2);
            do
            {
                valid = true;
                Console.Write("Which fist weapon would you like to buy?\n");
                int i = 0;
                foreach (FistWeapon fistWeapon in fistWeaps)
                {
                    i++;
                    Console.ForegroundColor = fistWeapon.Rarity.GetRarityColor();
                    Console.WriteLine("\n" + i + ")\n" + fistWeapon.ToString(false));
                    Console.ResetColor();
                }

                Console.Write("\nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > fistWeaps.Count() || input < 1)
                {
                    Console.WriteLine("Invalid input, try something else");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }

            } while (valid == false);

            return fistWeaps[input - 1];
        }

        public static Weapon FlailMenu()
        {
            bool valid;
            int input;
            List<Weapon> flails = WeaponShop.GetFlails(2);
            do
            {
                valid = true;
                Console.Write("Which flail would you like to buy?\n");
                int i = 0;
                foreach (Flail flail in flails)
                {
                    i++;
                    Console.ForegroundColor = flail.Rarity.GetRarityColor();
                    Console.WriteLine("\n" + i + ")\n" + flail.ToString(false));
                    Console.ResetColor();
                }

                Console.Write("\nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > flails.Count() || input < 1)
                {
                    Console.WriteLine("Invalid input, try something else");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }

            } while (valid == false);

            return flails[input - 1];
        }

        public static Weapon KnifeMenu()
        {
            bool valid;
            int input;
            List<Weapon> knives = WeaponShop.GetKnives(2);
            do
            {
                valid = true;
                Console.Write("Which knife would you like to buy?\n");
                int i = 0;
                foreach (Knife knife in knives)
                {
                    i++;
                    Console.ForegroundColor = knife.Rarity.GetRarityColor();
                    Console.WriteLine("\n" + i + ")\n" + knife.ToString(false));
                    Console.ResetColor();
                }

                Console.Write("\nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > knives.Count() || input < 1)
                {
                    Console.WriteLine("Invalid input, try something else");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }

            } while (valid == false);

            return knives[input - 1];
        }

        public static Weapon MaceMenu()
        {
            bool valid;
            int input;
            List<Weapon> maces = WeaponShop.GetMaces(2);
            do
            {
                valid = true;
                Console.Write("Which mace would you like to buy?\n");
                int i = 0;
                foreach (Mace mace in maces)
                {
                    i++;
                    Console.ForegroundColor = mace.Rarity.GetRarityColor();
                    Console.WriteLine("\n" + i + ")\n" + mace.ToString(false));
                    Console.ResetColor();
                }

                Console.Write("\nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > maces.Count() || input < 1)
                {
                    Console.WriteLine("Invalid input, try something else");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }

            } while (valid == false);

            return maces[input - 1];
        }

        public static Weapon MightWeapMenu()
        {
            bool valid;
            int input;
            List<Weapon> mightyWeaps = WeaponShop.GetMightyWeaps(2);
            do
            {
                valid = true;
                Console.Write("Which mighty weapon would you like to buy?\n");
                int i = 0;
                foreach (MightyWeapon mightyWeapon in mightyWeaps)
                {
                    i++;
                    Console.ForegroundColor = mightyWeapon.Rarity.GetRarityColor();
                    Console.WriteLine("\n" + i + ")\n" + mightyWeapon.ToString(false));
                    Console.ResetColor();
                }

                Console.Write("\nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > mightyWeaps.Count() || input < 1)
                {
                    Console.WriteLine("Invalid input, try something else");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }

            } while (valid == false);

            return mightyWeaps[input - 1];
        }

        public static Weapon ScytheMenu()
        {
            bool valid;
            int input;
            List<Weapon> scythes = WeaponShop.GetScythes(2);
            do
            {
                valid = true;
                Console.Write("Which scythe would you like to buy?\n");
                int i = 0;
                foreach (Scythe scythe in scythes)
                {
                    i++;
                    Console.ForegroundColor = scythe.Rarity.GetRarityColor();
                    Console.WriteLine("\n" + i + ")\n" + scythe.ToString(false));
                    Console.ResetColor();
                }

                Console.Write("\nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > scythes.Count() || input < 1)
                {
                    Console.WriteLine("Invalid input, try something else");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }

            } while (valid == false);

            return scythes[input - 1];
        }

        public static Weapon SpearMenu()
        {
            bool valid;
            int input;
            List<Weapon> spears = WeaponShop.GetSpears(2);
            do
            {
                valid = true;
                Console.Write("Which spear would you like to buy?\n");
                int i = 0;
                foreach (Spear spear in spears)
                {
                    i++;
                    Console.ForegroundColor = spear.Rarity.GetRarityColor();
                    Console.WriteLine("\n" + i + ")\n" + spear.ToString(false));
                    Console.ResetColor();
                }

                Console.Write("\nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > spears.Count() || input < 1)
                {
                    Console.WriteLine("Invalid input, try something else");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }

            } while (valid == false);

            return spears[input - 1];
        }

        public static Weapon SwordMenu()
        {
            bool valid;
            int input;
            List<Weapon> swords = WeaponShop.GetSwords(2);
            do
            {
                valid = true;
                Console.Write("Which sword would you like to buy?\n");
                int i = 0;
                foreach (Sword sword in swords)
                {
                    i++;
                    Console.ForegroundColor = sword.Rarity.GetRarityColor();
                    Console.WriteLine("\n" + i + ")\n" + sword.ToString(false));
                    Console.ResetColor();
                }

                Console.Write("\nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > swords.Count() || input < 1)
                {
                    Console.WriteLine("Invalid input, try something else");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }

            } while (valid == false);

            return swords[input - 1];
        }
    }
}
