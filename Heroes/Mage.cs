namespace RPGHeroes.Heroes
{
    internal class Mage : Hero
    {
        public override int DamagingAttribute => TotalAttributes().Intelligence;

        public Mage(string name) : base(name)
        {
            LevelAttributes.Add(strength: 1, dexterity: 1, intelligence: 8);

            ValidWeaponTypes.Add(Enums.WeaponType.Staff);
            ValidWeaponTypes.Add(Enums.WeaponType.Wand);
            ValidArmorTypes.Add(Enums.ArmorType.Cloth);
        }

        public override void LevelUp()
        {
            base.LevelUp();

            LevelAttributes.Add(strength: 1, dexterity: 1, intelligence: 5);
        }
    }
}
