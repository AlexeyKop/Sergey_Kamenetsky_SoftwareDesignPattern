using IntroPrototype.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPrototype.Infrastructure
{
    public static class Repository
    {
        static Random r;
        static Repository() 
        {
            r = new Random();
            referenceModel = new ReferenceModel
            {
                Data1 = GetRandom,
                Data2 = (char)GetRandom,
                Data3 = GetGuid
            };

            valueModel = new ValueModel
            {
                Data1 = GetRandom,
                Data2 = (char)GetRandom,
                Data3 = GetGuid
            };
        }

        public static int GetRandom { get => r.Next(50, 75); }

        public static string GetGuid { get { return Guid.NewGuid().ToString().Substring(0, 10); } }

        private static ReferenceModel referenceModel;
        private static ValueModel valueModel;

        public static ReferenceModel GetReferenceType => referenceModel;
        public static ValueModel GetValueType => valueModel;

    }
}
