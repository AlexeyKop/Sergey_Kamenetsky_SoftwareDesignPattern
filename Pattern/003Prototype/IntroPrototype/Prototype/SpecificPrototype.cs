using IntroPrototype.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPrototype.Prototype
{
    public class SpecificPrototype : Prototype
    {
        public SpecificPrototype(string value1, ValueModel value2, ReferenceModel value3)
            : base(value1, value2, value3) { }

        public override Prototype Clone()
        {
            ReferenceModel temporary = new ReferenceModel()
            {
                Data1 = Field3.Data1,
                Data2 = Field3.Data2,
                Data3 = Field3.Data3
            };


            return new SpecificPrototype(
                value1: base.Field1,
                value2: base.Field2,
                //value3: base.Field3
                value3: temporary
                );

        }

        public override string ToString()
        {
            return String.Format("Field1: {0} \nField2: {1} \nField3: {2}\n",
                 base.Field1,
                 base.Field2,
                 base.Field3
                 );
        }
    }
}
