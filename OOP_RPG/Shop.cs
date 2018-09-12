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
        }
    }
}
