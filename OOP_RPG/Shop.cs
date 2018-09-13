using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {
        List<Armor> Armors { get; set; }
        List<Weapon> Weapons { get; set; }
        List<Potion> Potions { get; set; }


        public Shop () {
            this.Armors = new List<Armor>();
            this.Weapons = new List<Weapon>();
            this.Potions = new List<Potion>();
            this.AddWeapon("Sword", 10, 2, 3);
            this.AddWeapon("Axe", 12, 3, 4);
            this.AddWeapon("LongSword", 20, 5, 7);
            this.AddArmor("Wooden Armor", 10, 2, 3);
            this.AddArmor("Metal Armor", 20, 5, 7);
            this.AddPotions("Healing Potion", 5, 5, 2);
        }

        public void AddWeapon(string name, int originalValue, int resellValue, int strength)
        {
            var weapon = new Weapon(name, originalValue, resellValue, strength);

            this.Weapons.Add(weapon);

        }
        public void AddArmor(string name, int originalValue, int resellValue, int defense)
        {
            var armor = new Armor(name, originalValue, resellValue, defense);

            this.Armors.Add(armor);

        }
        public void AddPotions(string name, int originalValue, int resellValue, int hp)
        {
            var potion = new Potion(name, hp, originalValue, resellValue);

            this.Potions.Add(potion);
        }
    }
}
