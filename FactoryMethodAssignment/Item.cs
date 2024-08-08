using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodAssignment
{
    public class Item
    {
        public string name;
        public string description;
        public enum ItemType { Potion, Weapon, Armor, Food }
    }
    public class Potion : Item
    {
        public int hp;
        public ItemType type = ItemType.Potion;
        public Potion()
        {

        }
    }
    public class Weapon : Item
    {
        public int damage;
        public ItemType type = ItemType.Weapon;
        public Weapon()
        {

        }
    }
    public class Armor : Item
    {
        public int defense;
        public ItemType type = ItemType.Armor;
        public Armor()
        {

        }
    }
    public class Food : Item
    {
        public int function;
        public ItemType type = ItemType.Food;
        public Food()
        {

        }
    }
}
