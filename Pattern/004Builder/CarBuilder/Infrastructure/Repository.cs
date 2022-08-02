using CarBuilder.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder.Infrastructure
{

    public static class Repository
    {
        public static AbstractBuilder GetBuilder(TypeBuilder type)
        {
            switch (type)
            {
                case TypeBuilder.Bolide: return new BolideBuilder();
                case TypeBuilder.Motorbike: return new MotorbikeBuilder();
                default: return new InternBuilder();
            }
        }
    }
}
