namespace BrokerChainOfResponsibility
{
    class Hero
    {
        private readonly Game game;
        public string Name;
        Characteristic characteristic;
        public int Attack
        {
            get
            {
                Query query = new(Name, GameEffect.DoubleDamageRune | GameEffect.ArrmorBonus, characteristic);
                game.CallQuery(this, query);
                return query.Args.Attack;
            }
        }

        public int Armor
        {
            get
            {
                Query query = new(Name, GameEffect.DoubleDamageRune | GameEffect.ArrmorBonus, characteristic);
                game.CallQuery(this, query);
                return query.Args.Armor;
            }
        }

        public Hero(string name, int attack, int armor, Game game)
        {
            this.Name = name;
            this.characteristic.Attack = attack;
            this.characteristic.Armor = armor;
            this.game = game;
        }

        public override string ToString() => $"{Name}: [{Attack}, {Armor}]\n";
    }
}