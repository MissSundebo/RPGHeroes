namespace RPGHeroes.Heroes
{
    public class HeroAttribute
    {
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Intelligence { get; private set; }

        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public void Add(int strength, int dexterity, int intelligence)
        {
            Strength += strength;
            Dexterity += dexterity;
            Intelligence += intelligence;
        }

        public void Add(HeroAttribute attribute)
        {
            Strength += attribute.Strength;
            Dexterity += attribute.Dexterity;
            Intelligence += attribute.Intelligence;
        }
    }
}
