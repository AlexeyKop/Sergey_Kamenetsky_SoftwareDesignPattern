namespace WithoutFactory
{

    class Program
    {
        static void NotFactory1()
        {
            //// Логика...
            //var rs4 = new RacingCar();
            //rs4.Drive();
            //// Логика...
            //var cayenneTurbo = new RacingCar();
            //cayenneTurbo.Drive();


            //// Логика...
            //var kamazConcreteMixer = new ConcreteMixerCar();
            //kamazConcreteMixer.Drive();


            //// Логика...
            //var liebherrConcreteMixer = new ConcreteMixerCar();
            //liebherrConcreteMixer.Drive();

            //// Логика...
            //var volvoConcreteMixer = new ConcreteMixerCar();
            //volvoConcreteMixer.Drive();
            //// Логика...
        }

        static void NotFactory2()
        {
            //// Логика...
            //var rs4 = new RacingCar(engine: 3.2);
            //rs4.Drive();
            //// Логика...
            //var cayenneTurbo = new RacingCar(engine: 4.8);
            //cayenneTurbo.Drive();


            //// Логика...
            //var kamazConcreteMixer = new ConcreteMixerCar(engine: 3.9);
            //kamazConcreteMixer.Drive();


            //// Логика...
            //var liebherrConcreteMixer = new ConcreteMixerCar(engine: 6.9);
            //liebherrConcreteMixer.Drive();

            //// Логика...
            //var volvoConcreteMixer = new ConcreteMixerCar(engine: 4.0);
            //volvoConcreteMixer.Drive();
            //// Логика...
        }

        static void NotFactory3()
        {
            // Логика...
            var rs4 = new RacingCar(model: "Audi rs4", engine: 3.2);
            rs4.Drive();
            // Логика...
            var cayenneTurbo = new RacingCar(model: "Porsche Cayenne Turbo", engine: 4.8);
            cayenneTurbo.Drive();


            // Логика...
            var kamazConcreteMixer = new ConcreteMixerCar(model: "Kamaz", engine: 3.9);
            kamazConcreteMixer.Drive();


            // Логика...
            var liebherrConcreteMixer = new ConcreteMixerCar(model: "liebherr", engine: 6.9);
            liebherrConcreteMixer.Drive();

            // Логика...
            var volvoConcreteMixer = new ConcreteMixerCar(model: "volvo", engine: 4.0);
            volvoConcreteMixer.Drive();
            // Логика...
        }


        static void Main()
        {
            NotFactory1();
            NotFactory2();
            NotFactory3();
        }
    }
}
