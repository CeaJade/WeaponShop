using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public static class WeaponFactory
    {
        public static Weapon ForgeAxe(int type)
        {
            Axe axe;
            if (type == 0)
            {
                axe = new Axe("Heavy Axe", 30, new Rarity());
            }

            if (type == 1)
            {
                axe = new Axe("Hand Axe", 15, new Rarity());
            }

            if (type == 2)
            {
                axe = new Axe("Double Axe", 23, new Rarity());
            }

            else
            {
                axe = new Axe("Hatchet", 13, new Rarity());
            }

            if (axe.Rarity.RarityLevel == 1)
            {
                axe.AddPrimaryStats(Primary.GetPrimaries(1));
                axe.AddSecondaryStats(Secondary.GetSecondaries(1));
                axe.AddMagicStats(Magic.GetMagic(2));
            }

            else if (axe.Rarity.RarityLevel == 2)
            {
                axe.AddPrimaryStats(Primary.GetPrimaries(2));
                axe.AddSecondaryStats(Secondary.GetSecondaries(2));
                axe.AddMagicStats(Magic.GetMagic(4));
            }

            else if (axe.Rarity.RarityLevel == 3)
            {
                axe.AddPrimaryStats(Primary.GetPrimaries(3));
                axe.AddSecondaryStats(Secondary.GetSecondaries(3));
                axe.AddMagicStats(Magic.GetMagic(6));
            }

            return axe;
        }

        public static Weapon ForgeDagger(int type)
        {
            Dagger dagger;
            if (type == 0)
            {
                dagger = new Dagger("Short Dagger", 2, new Rarity());
            }

            if (type == 1)
            {
                dagger = new Dagger("Envious Blade", 20, new Rarity());
            }

            if (type == 2)
            {
                dagger = new Dagger("Skumbanan", 999, new Rarity());
            }

            else
            {
                dagger = new Dagger("Poignard", 16, new Rarity());
            }

            if (dagger.Rarity.RarityLevel == 1)
            {
                dagger.AddPrimaryStats(Primary.GetPrimaries(1));
                dagger.AddSecondaryStats(Secondary.GetSecondaries(1));
                dagger.AddMagicStats(Magic.GetMagic(2));
            }

            else if (dagger.Rarity.RarityLevel == 2)
            {
                dagger.AddPrimaryStats(Primary.GetPrimaries(2));
                dagger.AddSecondaryStats(Secondary.GetSecondaries(2));
                dagger.AddMagicStats(Magic.GetMagic(4));
            }

            else if (dagger.Rarity.RarityLevel == 3)
            {
                dagger.AddPrimaryStats(Primary.GetPrimaries(3));
                dagger.AddSecondaryStats(Secondary.GetSecondaries(3));
                dagger.AddMagicStats(Magic.GetMagic(6));
            }

            return dagger;
        }

        public static Weapon ForgeFistWeap(int type)
        {
            FistWeapon fistWeap;
            if (type == 0)
            {
                fistWeap = new FistWeapon("Panther Claw", 19, new Rarity());
            }

            if (type == 1)
            {
                fistWeap = new FistWeapon("Knuckles", 4, new Rarity());
            }

            if (type == 2)
            {
                fistWeap = new FistWeapon("Spiked Knuckles", 13, new Rarity());
            }

            else
            {
                fistWeap = new FistWeapon("Fleshrake", 15, new Rarity());
            }

            if (fistWeap.Rarity.RarityLevel == 1)
            {
                fistWeap.AddPrimaryStats(Primary.GetPrimaries(1));
                fistWeap.AddSecondaryStats(Secondary.GetSecondaries(1));
                fistWeap.AddMagicStats(Magic.GetMagic(2));
            }

            else if (fistWeap.Rarity.RarityLevel == 2)
            {
                fistWeap.AddPrimaryStats(Primary.GetPrimaries(2));
                fistWeap.AddSecondaryStats(Secondary.GetSecondaries(2));
                fistWeap.AddMagicStats(Magic.GetMagic(4));
            }

            else if (fistWeap.Rarity.RarityLevel == 3)
            {
                fistWeap.AddPrimaryStats(Primary.GetPrimaries(3));
                fistWeap.AddSecondaryStats(Secondary.GetSecondaries(3));
                fistWeap.AddMagicStats(Magic.GetMagic(6));
            }

            return fistWeap;
        }

        public static Weapon ForgeFlail(int type)
        {
            Flail flail;
            if (type == 0)
            {
                flail = new Flail("Spiked Flail", 6, new Rarity());
            }

            if (type == 1)
            {
                flail = new Flail("Templars Chain", 9, new Rarity());
            }

            if (type == 2)
            {
                flail = new Flail("Thresher", 23, new Rarity());
            }

            else
            {
                flail = new Flail("Darklight", 34, new Rarity());
            }

            if (flail.Rarity.RarityLevel == 1)
            {
                flail.AddPrimaryStats(Primary.GetPrimaries(1));
                flail.AddSecondaryStats(Secondary.GetSecondaries(1));
                flail.AddMagicStats(Magic.GetMagic(2));
            }

            else if (flail.Rarity.RarityLevel == 2)
            {
                flail.AddPrimaryStats(Primary.GetPrimaries(2));
                flail.AddSecondaryStats(Secondary.GetSecondaries(2));
                flail.AddMagicStats(Magic.GetMagic(4));
            }

            else if (flail.Rarity.RarityLevel == 3)
            {
                flail.AddPrimaryStats(Primary.GetPrimaries(3));
                flail.AddSecondaryStats(Secondary.GetSecondaries(3));
                flail.AddMagicStats(Magic.GetMagic(6));
            }

            return flail;
        }

        public static Weapon ForgeKnife(int type)
        {
            Knife knife;
            if (type == 0)
            {
                knife = new Knife("Stone Knife", 13, new Rarity());
            }

            if (type == 1)
            {
                knife = new Knife("Kris Blade", 8, new Rarity());
            }

            if (type == 2)
            {
                knife = new Knife("Jagged Edge", 16, new Rarity());
            }

            else
            {
                knife = new Knife("Flint Knife", 19, new Rarity());
            }

            if (knife.Rarity.RarityLevel == 1)
            {
                knife.AddPrimaryStats(Primary.GetPrimaries(1));
                knife.AddSecondaryStats(Secondary.GetSecondaries(1));
                knife.AddMagicStats(Magic.GetMagic(2));
            }

            else if (knife.Rarity.RarityLevel == 2)
            {
                knife.AddPrimaryStats(Primary.GetPrimaries(2));
                knife.AddSecondaryStats(Secondary.GetSecondaries(2));
                knife.AddMagicStats(Magic.GetMagic(4));
            }

            else if (knife.Rarity.RarityLevel == 3)
            {
                knife.AddPrimaryStats(Primary.GetPrimaries(3));
                knife.AddSecondaryStats(Secondary.GetSecondaries(3));
                knife.AddMagicStats(Magic.GetMagic(6));
            }

            return knife;
        }

        public static Weapon ForgeMace(int type)
        {
            Mace dagger;
            if (type == 0)
            {
                dagger = new Mace("Cudgel", 8, new Rarity());
            }

            if (type == 1)
            {
                dagger = new Mace("Morning Star", 17, new Rarity());
            }

            if (type == 2)
            {
                dagger = new Mace("War Gavel", 30, new Rarity());
            }

            else
            {
                dagger = new Mace("Bludgeon", 18, new Rarity());
            }

            if (dagger.Rarity.RarityLevel == 1)
            {
                dagger.AddPrimaryStats(Primary.GetPrimaries(1));
                dagger.AddSecondaryStats(Secondary.GetSecondaries(1));
                dagger.AddMagicStats(Magic.GetMagic(2));
            }

            else if (dagger.Rarity.RarityLevel == 2)
            {
                dagger.AddPrimaryStats(Primary.GetPrimaries(2));
                dagger.AddSecondaryStats(Secondary.GetSecondaries(2));
                dagger.AddMagicStats(Magic.GetMagic(4));
            }

            else if (dagger.Rarity.RarityLevel == 3)
            {
                dagger.AddPrimaryStats(Primary.GetPrimaries(3));
                dagger.AddSecondaryStats(Secondary.GetSecondaries(3));
                dagger.AddMagicStats(Magic.GetMagic(6));
            }

            return dagger;
        }

        public static Weapon ForgeMightyWeap(int type)
        {
            MightyWeapon mightyWeapon;
            if (type == 0)
            {
                mightyWeapon = new MightyWeapon("Carver", 10, new Rarity());
            }

            if (type == 1)
            {
                mightyWeapon = new MightyWeapon("Fjord Cutter", 14, new Rarity());
            }

            if (type == 2)
            {
                mightyWeapon = new MightyWeapon("War Blade", 30, new Rarity());
            }

            else
            {
                mightyWeapon = new MightyWeapon("Machete", 28, new Rarity());
            }

            if (mightyWeapon.Rarity.RarityLevel == 1)
            {
                mightyWeapon.AddPrimaryStats(Primary.GetPrimaries(1));
                mightyWeapon.AddSecondaryStats(Secondary.GetSecondaries(1));
                mightyWeapon.AddMagicStats(Magic.GetMagic(2));
            }

            else if (mightyWeapon.Rarity.RarityLevel == 2)
            {
                mightyWeapon.AddPrimaryStats(Primary.GetPrimaries(2));
                mightyWeapon.AddSecondaryStats(Secondary.GetSecondaries(2));
                mightyWeapon.AddMagicStats(Magic.GetMagic(4));
            }

            else if (mightyWeapon.Rarity.RarityLevel == 3)
            {
                mightyWeapon.AddPrimaryStats(Primary.GetPrimaries(3));
                mightyWeapon.AddSecondaryStats(Secondary.GetSecondaries(3));
                mightyWeapon.AddMagicStats(Magic.GetMagic(6));
            }

            return mightyWeapon;
        }

        public static Weapon ForgeScythe(int type)
        {
            Scythe scythe;
            if (type == 0)
            {
                scythe = new Scythe("Scythe", 3, new Rarity());
            }

            if (type == 1)
            {
                scythe = new Scythe("Falx", 10, new Rarity());
            }

            if (type == 2)
            {
                scythe = new Scythe("Shotel", 18, new Rarity());
            }

            else
            {
                scythe = new Scythe("Khopesh", 24, new Rarity());
            }

            if (scythe.Rarity.RarityLevel == 1)
            {
                scythe.AddPrimaryStats(Primary.GetPrimaries(1));
                scythe.AddSecondaryStats(Secondary.GetSecondaries(1));
                scythe.AddMagicStats(Magic.GetMagic(2));
            }

            else if (scythe.Rarity.RarityLevel == 2)
            {
                scythe.AddPrimaryStats(Primary.GetPrimaries(2));
                scythe.AddSecondaryStats(Secondary.GetSecondaries(2));
                scythe.AddMagicStats(Magic.GetMagic(4));
            }

            else if (scythe.Rarity.RarityLevel == 3)
            {
                scythe.AddPrimaryStats(Primary.GetPrimaries(3));
                scythe.AddSecondaryStats(Secondary.GetSecondaries(3));
                scythe.AddMagicStats(Magic.GetMagic(6));
            }

            return scythe;
        }

        public static Weapon ForgeSpear(int type)
        {
            Spear spear;
            if (type == 0)
            {
                spear = new Spear("Lance", 7, new Rarity());
            }

            if (type == 1)
            {
                spear = new Spear("Javelin", 10, new Rarity());
            }

            if (type == 2)
            {
                spear = new Spear("Spear", 16, new Rarity());
            }

            else
            {
                spear = new Spear("Hasta", 22, new Rarity());
            }

            if (spear.Rarity.RarityLevel == 1)
            {
                spear.AddPrimaryStats(Primary.GetPrimaries(1));
                spear.AddSecondaryStats(Secondary.GetSecondaries(1));
                spear.AddMagicStats(Magic.GetMagic(2));
            }

            else if (spear.Rarity.RarityLevel == 2)
            {
                spear.AddPrimaryStats(Primary.GetPrimaries(2));
                spear.AddSecondaryStats(Secondary.GetSecondaries(2));
                spear.AddMagicStats(Magic.GetMagic(4));
            }

            else if (spear.Rarity.RarityLevel == 3)
            {
                spear.AddPrimaryStats(Primary.GetPrimaries(3));
                spear.AddSecondaryStats(Secondary.GetSecondaries(3));
                spear.AddMagicStats(Magic.GetMagic(6));
            }

            return spear;
        }

        public static Weapon ForgeSword(int type)
        {
            Sword sword;
            if (type == 0)
            {
                sword = new Sword("Griswold's Edge", 7, new Rarity());
            }

            if (type == 1)
            {
                sword = new Sword("Ghoul Blade", 4, new Rarity());
            }

            if (type == 2)
            {
                sword = new Sword("Monster Hunter", 20, new Rarity());
            }

            else
            {
                sword = new Sword("Wildwood", 14, new Rarity());
            }

            if (sword.Rarity.RarityLevel == 1)
            {
                sword.AddPrimaryStats(Primary.GetPrimaries(1));
                sword.AddSecondaryStats(Secondary.GetSecondaries(1));
                sword.AddMagicStats(Magic.GetMagic(2));
            }

            else if (sword.Rarity.RarityLevel == 2)
            {
                sword.AddPrimaryStats(Primary.GetPrimaries(2));
                sword.AddSecondaryStats(Secondary.GetSecondaries(2));
                sword.AddMagicStats(Magic.GetMagic(4));
            }

            else if (sword.Rarity.RarityLevel == 3)
            {
                sword.AddPrimaryStats(Primary.GetPrimaries(3));
                sword.AddSecondaryStats(Secondary.GetSecondaries(3));
                sword.AddMagicStats(Magic.GetMagic(6));
            }

            return sword;
        }
    }
}
