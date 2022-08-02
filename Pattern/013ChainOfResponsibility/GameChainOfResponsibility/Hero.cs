namespace GameChainOfResponsibility
{
    public class Hero
    {
        public string Name;
        public int Attack { get; set; }
        public int Armor { get; set; }

        public Hero(string name, int attack, int armor)
        {
            Name = name;
            Attack = attack;
            Armor = armor;
        }

        public override string ToString() => $"{Name}: [{Attack}, {Armor}]\n";
    }
}