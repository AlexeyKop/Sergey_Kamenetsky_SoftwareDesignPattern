namespace Ex32_LiskovSubstitutionPrinciple
{
    public class Kiwi : Bird
    {
        public Kiwi()
        {
            Position = new Coordinates(30, 10);
            base.m = "K";
        }


        private void Run()
        {
            Mark(Position.Latitude, Position.Longitude);
            speed = 1;
            switch (rand.Next(4))
            {
                case 0: Position.Latitude += speed; break;
                case 1: Position.Latitude -= speed; break;
                case 2: Position.Longitude += speed; break;
                default: Position.Longitude -= speed; break;
            }
            spacing++;
            Mark(Position.Latitude, Position.Longitude);
        }

        public override void Move()
        {
            this.Run();
        }

    }
}
