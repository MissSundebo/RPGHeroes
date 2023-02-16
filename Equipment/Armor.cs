using RPGHeroes.Enums;
using RPGHeroes.Heroes;

namespace RPGHeroes.Equipment
{
    public class Armor : Item
    {
        public ArmorType ArmorType { get; private set; }
        public HeroAttribute ArmorAttribute { get; private set; }

        public Armor(string name, int requiredLevel, Slot slot, ArmorType armorType, HeroAttribute armorAttribute)
            : base(name, requiredLevel, slot)
        {
            this.ArmorType = armorType;
            this.ArmorAttribute = armorAttribute;
        }
    }
}