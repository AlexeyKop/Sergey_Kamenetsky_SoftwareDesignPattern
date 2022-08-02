namespace LazySingleton
{
    class Singleton
    {
        static Singleton uniqueInstance;
        private Singleton() { Data = 28; }

        public static Singleton Instance 
        {
            get
            {
                if (uniqueInstance == null)
                    uniqueInstance = new Singleton();

                return uniqueInstance;
            }
        }

        public int Data { get; set; }
    }
}
