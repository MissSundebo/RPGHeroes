using RPGHeroes.Enums;
using RPGHeroes.Equipment;
using RPGHeroes.Exceptions;
using System.Text;

namespace RPGHeroes.Heroes
{
    public abstract class Hero
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public HeroAttribute LevelAttributes { get; private set; }
        public Dictionary<Slot, Item?> Equipment { get; private set; }
        protected List<WeaponType> ValidWeaponTypes { get; private set; }
        protected List<ArmorType> ValidArmorTypes { get; private set; }
        public abstract int DamagingAttribute { get; }

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute(0, 0, 0);

            Equipment = new Dictionary<Slot, Item?>
            {
                { Slot.Weapon, null },
                { Slot.Head, null },
                { Slot.Body, null },
                { Slot.Legs, null }
            };

            ValidWeaponTypes = new List<WeaponType>();
            ValidArmorTypes = new List<ArmorType>();
        }

        public virtual void LevelUp()
        {
            Level++;
        }

        //Looping through equip
        public void Equip(Weapon weapon)
        {
            if (weapon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException("Your level is too low");
            }

            if (!ValidWeaponTypes.Contains(weapon.WeaponType))
            {
                throw new InvalidWeaponException("Your weapon type is not allowed");
            }

            Equipment[weapon.Slot] = weapon;
        }

        public void Equip(Armor armor)
        {
            if (armor.RequiredLevel > Level)
            {
                throw new InvalidArmorException("Your level is too low");
            }

            if (!ValidArmorTypes.Contains(armor.ArmorType))
            {
                throw new InvalidArmorException("Your armor type is not allowed");
            }

            Equipment[armor.Slot] = armor;
        }

        //loop through Damage
        public double Damage()
        {
            int weaponDamage = 1;

            if (Equipment[Slot.Weapon] != null)
            {
                weaponDamage = (Equipment[Slot.Weapon] as Weapon).WeaponDamage;
            }

            return weaponDamage * (1 + DamagingAttribute / 100.0);
        }

        public HeroAttribute TotalAttributes()
        {
            var total = new HeroAttribute(0, 0, 0);

            // Add the hero's LevelAttributes property to total above
            total.Add(LevelAttributes);

            var nonWeapons = Equipment.Values.Where(x => x != null && x is Armor).Cast<Armor>().ToList();

            // Loop through all non-weapon equipment slots and add each ArmorAttribute to the total above
            foreach (Armor armor in nonWeapons)
            {
                total.Add(armor.ArmorAttribute);
            }

            return total;
        }

        public void Display()
        {
            var total = TotalAttributes();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Class: {GetType().Name}");
            sb.AppendLine($"Level: {Level}");
            sb.AppendLine($"Total strength: {total.Strength}");
            sb.AppendLine($"Total dexterity: {total.Dexterity}");
            sb.AppendLine($"Total intelligence: {total.Intelligence}");
            sb.AppendLine($"Damage: {Damage():0.00}");

            Console.WriteLine(sb.ToString());
        }
    }
}
