namespace RPGHeroes.Heroes
{
    public class Warrior : Hero
    {
        public override int DamagingAttribute => TotalAttributes().Strength;

        public Warrior(string name) : base(name)
        {
            LevelAttributes.Add(strength: 5, dexterity: 2, intelligence: 1);

            ValidWeaponTypes.Add(Enums.WeaponType.Axe);
            ValidWeaponTypes.Add(Enums.WeaponType.Hammer);
            ValidWeaponTypes.Add(Enums.WeaponType.Sword);
            ValidArmorTypes.Add(Enums.ArmorType.Mail);
            ValidArmorTypes.Add(Enums.ArmorType.Plate);
        }

        public override void LevelUp()
        {
            base.LevelUp();

            LevelAttributes.Add(strength: 3, dexterity: 2, intelligence: 1);
        }
    }
}
