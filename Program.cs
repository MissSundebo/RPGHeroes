using RPGHeroes.Enums;
using RPGHeroes.Equipment;

namespace RPGHeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage("Marge");
            Warrior warrior = new Warrior("Homer");
            Rogue rogue = new Rogue("Bart");
            Ranger ranger = new Ranger("Lisa");

            Weapon weapon = new Weapon("Gimle's Axe", 1, 5, WeaponType.Axe);
            Armor armor = new Armor("Armored Hat", 1, Slot.Head, ArmorType.Plate, new HeroAttribute(3, 0, 0));

            warrior.Equip(armor);
            warrior.Equip(weapon);
            warrior.LevelUp();
            warrior.Display();
        }
    }
}