using System;

namespace LazySingleton
{
    class Singleton
    {
        public int Data { get; set; }

        private Singleton() { Data = 28; }
        
        static Lazy<Singleton> uniqueInstance 
            = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance => uniqueInstance.Value;
    }
}
