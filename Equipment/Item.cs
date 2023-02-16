using RPGHeroes.Enums;

namespace RPGHeroes.Equipment
{
    public abstract class Item
    {
        public string Name { get; private set; }
        public int RequiredLevel { get; private set; }
        public Slot Slot { get; private set; }

        public Item(string name, int requiredLevel, Slot slot)
        {
            this.Name = name;
            this.RequiredLevel = requiredLevel;
            this.Slot = slot;
        }
    }
}
