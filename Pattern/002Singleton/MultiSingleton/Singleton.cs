using System.Collections.Generic;

namespace MultiSingleton
{
    public sealed class Singleton
    {
        static Singleton() { index = 0; }
        static int index;
        static List<Singleton> instances;

        public int Data { get; set; }
        Singleton(int data) { Data = data; }

        public static int Max
        {
            get { return instances.Count; }
            set
            {
                if (instances == null) instances = new List<Singleton>();
                for (int i = instances.Count; i < value; i++)
                {
                    if (i <= instances.Count || instances[i] != null)
                    { instances.Add(new Singleton(i)); }
                }
            }
        }
        public static Singleton Instance => instances[index];

        public static int WorkingIndex
        {
            get { return index; }
            set { index = value >= 0 && value < instances.Count ? value : 0; }
        }
    }

}
