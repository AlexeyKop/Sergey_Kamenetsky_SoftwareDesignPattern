namespace Ex32_LiskovSubstitutionPrinciple
{
    public class Coordinates
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }

        public Coordinates(int x, int y)
        {
            Latitude = x;
            Longitude = y;
        }

        public override string ToString()
        {
            return $"Широта: {Latitude}  Долгота: {Longitude}";
        }
    }
}
