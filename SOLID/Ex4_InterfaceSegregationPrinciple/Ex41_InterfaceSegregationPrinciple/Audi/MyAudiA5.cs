using RecordPrototype.Audi.Package;
using RecordPrototype.Audi.Package.Lines;

namespace RecordPrototype.Audi
{
    //public class MyAudiA5 : AudiA5 , IAmbientLighting, IHeadlightsMatrixLed, ISLine
    //{
    //    public MyAudiA5(string model, string brand)
    //        : base(model, brand) { }

    //    public Characteristic AmbientLightingPackage { get; }
    //    public Characteristic HeadlightsMatrixLedPackage { get; }
    //    public Characteristic SLinePackage { get; }
    //}

    //public class MyAudiA5 : AudiA5, ISportLine
    //{
    //    public MyAudiA5(string model, string brand)
    //        : base(model, brand) { }

    //    public Characteristic SLinePackage { get; }
    //    public Characteristic AudiConnectPackage { get; }
    //    public Characteristic AudiPreSenseFrontPackage { get; }
    //}

    //public class MyAudiA5 : AudiA5, IDesignLine, IAmbientLighting
    //{
    //    public MyAudiA5(string model, string brand)
    //        : base(model, brand) { }

    //    public Characteristic HeadlightsMatrixLedPackage { get; }
    //    public Characteristic InfotainmentPackage { get; }
    //    public Characteristic TowingPackagePackage { get; }
    //    public Characteristic AmbientLightingPackage { get; }
    //}

    public class MyAudiA5 : AudiA5, IAudiExclusive
    {
        public MyAudiA5(string model, string brand)
            : base(model, brand) { }

        public Characteristic SLinePackage { get; }
        public Characteristic AudiConnectPackage { get; }
        public Characteristic AudiPreSenseFrontPackage { get; }
        public Characteristic HeadlightsMatrixLedPackage { get; }
        public Characteristic InfotainmentPackage { get; }
        public Characteristic TowingPackagePackage { get; }
        public Characteristic AmbientLightingPackage { get; }
    }



}
