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
        public Game game { get; set; }
        public Hero hero { get; set; }

        public Shop(Game game, Hero hero)
        {
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
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
        public int itemNumber { get; set; }

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

        public void Menu()
        {
            Console.WriteLine("Welcome to my shop! What would you like to do?");
            Console.WriteLine("1. Buy Item");
            Console.WriteLine("2. Sell Item");
            Console.WriteLine("3. Return to Game Menu");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.ShowInventory();
            }
            else if (input == "2")
            {
                this.BuyfromUser();
            }
            else
            {
                return;
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("What you want to buy?");
            Console.WriteLine("1.Weapons");
            Console.WriteLine("2.Armors");
            Console.WriteLine("3.Potions");

            var input = Console.ReadLine();
            if (input == "1")
            {
              foreach( var weapon in this.Weapons)
            {
              Console.WriteLine($"{weapon.Name} - {weapon.OriginalValue} Gold");
            }    
            }
            else if (input == "2")
            {
            foreach( var armor in this.Armors)
            {
              Console.WriteLine($"{armor.Name} - {armor.OriginalValue} Gold");
            } 
            }
            else if (input == "3")
            {
              foreach( var potion in this.Potions)
            {
              Console.WriteLine($"{potion.Name} - {potion.OriginalValue} Gold");
            }
            }
            else
            {
             return;
             this.Menu;
            }
        }

        public void BuyfromUser()
        {
            Console.WriteLine("What you want to Buy?");
            Console.WriteLine("1.Weapons");
            Console.WriteLine("2.Armors");
            Console.WriteLine("3.Potions");            var input = Console.ReadLine();
            if (input == "itemNumber")
            {
             Console.WriteLine("Buy");   
            }
            else if (input == "r")
            {
                this.Menu();
            }
            else
            {
                return;
            }
        }


        public void Sell(int inputNumber, string name)
        {
            Console.WriteLine("Sell your items here.");
        }

        public void SellFromUser()
        {

        }
    }
}
