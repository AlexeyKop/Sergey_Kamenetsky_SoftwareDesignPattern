namespace BrokerChainOfResponsibility
{
    class Query
    {
        public string HeroName { get; set; }
        public GameEffect TypeEffect { get; set; }
        public Characteristic Args { get; set; }

        public Query(string heroName, GameEffect typeEffect, Characteristic values)
        {
            this.HeroName = heroName;
            this.TypeEffect = typeEffect;
            this.Args = values;
        }
    }
}