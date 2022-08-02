using System;

namespace Ex32_LiskovSubstitutionPrinciple
{
    public class Bird
    {
        static protected Random rand = new Random();
        public Coordinates Position { get; set; }
        protected int speed, spacing;
        public int Speed => speed;
        public int Spacing => spacing;
        protected string m;

        public Bird()
        {
            Position = new Coordinates(10, 10);
            this.m = "B";
        }

        protected void Mark(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(m);
        }

        private void Fly()
        {
            Mark(Position.Latitude, Position.Longitude);

            speed = 1;
            switch (rand.Next(2))
            {
                case 0: Position.Latitude += speed; break;
                default: Position.Longitude += speed; break;
            }
            spacing++;
            Mark(Position.Latitude, Position.Longitude);

        }

        public virtual void Move()
        {
            this.Fly();
        }
    }
}

  