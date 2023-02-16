namespace RPGHeroes.Heroes
{
    public class Ranger : Hero
    {
        public override int DamagingAttribute => TotalAttributes().Dexterity;

        public Ranger(string name) : base(name)
        {
            LevelAttributes.Add(strength: 1, dexterity: 7, intelligence: 1);

            ValidWeaponTypes.Add(Enums.WeaponType.Bow);
            ValidArmorTypes.Add(Enums.ArmorType.Leather);
            ValidArmorTypes.Add(Enums.ArmorType.Mail);
        }

        public override void LevelUp()
        {
            base.LevelUp();

            LevelAttributes.Add(strength: 1, dexterity: 5, intelligence: 1);
        }
    }
}
