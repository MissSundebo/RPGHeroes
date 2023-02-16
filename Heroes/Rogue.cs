namespace RPGHeroes.Heroes
{
    public class Rogue : Hero
    {
        public override int DamagingAttribute => TotalAttributes().Dexterity;

        public Rogue(string name) : base(name)
        {
            LevelAttributes.Add(strength: 2, dexterity: 6, intelligence: 1);

            ValidWeaponTypes.Add(Enums.WeaponType.Dagger);
            ValidWeaponTypes.Add(Enums.WeaponType.Sword);
            ValidArmorTypes.Add(Enums.ArmorType.Leather);
            ValidArmorTypes.Add(Enums.ArmorType.Mail);
        }

        public override void LevelUp()
        {
            base.LevelUp();

            LevelAttributes.Add(strength: 1, dexterity: 4, intelligence: 1);
        }
    }
}
