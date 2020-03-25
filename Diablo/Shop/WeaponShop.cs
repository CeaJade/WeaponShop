using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public static class WeaponShop
    {

        public static List<Weapon> GetAxes(int amount)
        {
            List<Weapon> axes = new List<Weapon>();
            Random rdm = new Random();
            for (int count = 0; count < amount; count++)
            {
                int i = rdm.Next(0, 3);
                axes.Add(WeaponFactory.ForgeAxe(i));
            }
            return axes;
        }

        public static List<Weapon> GetDaggers(int amount)
        {
            List<Weapon> daggers = new List<Weapon>();
            Random rdm = new Random();
            for (int count = 0; count < amount; count++)
            {
                int i = rdm.Next(0, 3);
                daggers.Add(WeaponFactory.ForgeDagger(i));
            }
            return daggers;
        }

        public static List<Weapon> GetFistWeps(int amount)
        {
            List<Weapon> fistWeapons = new List<Weapon>();
            Random rdm = new Random();
            for (int count = 0; count < amount; count++)
            {
                int i = rdm.Next(0, 3);
                fistWeapons.Add(WeaponFactory.ForgeFistWeap(i));
            }
            return fistWeapons;
        }

        public static List<Weapon> GetFlails(int amount)
        {
            List<Weapon> flails = new List<Weapon>();
            Random rdm = new Random();
            for (int count = 0; count < amount; count++)
            {
                int i = rdm.Next(0, 3);
                flails.Add(WeaponFactory.ForgeFlail(i));
            }
            return flails;
        }

        public static List<Weapon> GetKnives(int amount)
        {
            List<Weapon> knives = new List<Weapon>();
            Random rdm = new Random();
            for (int count = 0; count < amount; count++)
            {
                int i = rdm.Next(0, 3);
                knives.Add(WeaponFactory.ForgeKnife(i));
            }
            return knives;
        }

        public static List<Weapon> GetMaces(int amount)
        {
            List<Weapon> maces = new List<Weapon>();
            Random rdm = new Random();
            for (int count = 0; count < amount; count++)
            {
                int i = rdm.Next(0, 3);
                maces.Add(WeaponFactory.ForgeMace(i));
            }
            return maces;
        }

        public static List<Weapon> GetMightyWeaps(int amount)
        {
            List<Weapon> mightyWeaps = new List<Weapon>();
            Random rdm = new Random();
            for (int count = 0; count < amount; count++)
            {
                int i = rdm.Next(0, 3);
                mightyWeaps.Add(WeaponFactory.ForgeMightyWeap(i));
            }
            return mightyWeaps;
        }

        public static List<Weapon> GetScythes(int amount)
        {
            List<Weapon> scythes = new List<Weapon>();
            Random rdm = new Random();
            for (int count = 0; count < amount; count++)
            {
                int i = rdm.Next(0, 3);
                scythes.Add(WeaponFactory.ForgeScythe(i));
            }
            return scythes;
        }

        public static List<Weapon> GetSpears(int amount)
        {
            List<Weapon> spears = new List<Weapon>();
            Random rdm = new Random();
            for (int count = 0; count < amount; count++)
            {
                int i = rdm.Next(0, 3);
                spears.Add(WeaponFactory.ForgeSpear(i));
            }
            return spears;
        }

        public static List<Weapon> GetSwords(int amount)
        {
            List<Weapon> swords = new List<Weapon>();
            Random rdm = new Random();
            for (int count = 0; count < amount; count++)
            {
                int i = rdm.Next(0, 3);
                swords.Add(WeaponFactory.ForgeSword(i));
            }
            return swords;
        }
    }
}
