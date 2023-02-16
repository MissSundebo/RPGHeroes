using RPGHeroes.Enums;

namespace RPGHeroes.Equipment
{
    public class Weapon : Item
    {
        public int WeaponDamage { get; private set; }
        public WeaponType WeaponType { get; private set; }

        public Weapon(string name, int requiredLevel,  int weaponDamage, WeaponType weaponType)
            : base(name, requiredLevel, Slot.Weapon)
        {
            this.WeaponDamage = weaponDamage;
            this.WeaponType = weaponType;
        }
    }
}