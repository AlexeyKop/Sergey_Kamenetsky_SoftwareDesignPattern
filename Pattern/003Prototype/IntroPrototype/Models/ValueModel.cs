using System;

namespace IntroPrototype.Models
{
    public struct ValueModel
    {
        public int Data1 { get; set; }
        public char Data2 { get; set; }
        public string Data3 { get; set; }

        public override string ToString()
        {
            return String.Format("Data1: {0} Data2: {1} Data3 {2}",
                 this.Data1,
                 this.Data2,
                 this.Data3 
                 );
        }
    }
}
