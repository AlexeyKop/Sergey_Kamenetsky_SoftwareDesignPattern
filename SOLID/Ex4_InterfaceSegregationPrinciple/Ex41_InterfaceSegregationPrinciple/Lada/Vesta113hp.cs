using System;

namespace RecordPrototype.Lada
{
    public class Vesta113hp : Vesta, IVesta
    {
        public Vesta113hp(string model, string brand)
            : base(model, brand) { }

        public Characteristic BodyWheelArrangementTtractionWheels => throw new NotImplementedException();
        public Characteristic BodyEngineLocation => throw new NotImplementedException();
        public Characteristic BodyTypeNumberOfDoors => throw new NotImplementedException();
        public Characteristic Bodyseats => Characteristic.Set("5");
        public Characteristic BodyLengthWidthHeight => Characteristic.Set("4410/1764/1497 mm");
        public Characteristic BodyWheelbase => Characteristic.Set("2635 mm");
        public Characteristic BodyFrontRearTrack => Characteristic.Set("1510/1510 mm");
        public Characteristic BodyRoadClearance => Characteristic.Set("178 mm");
        public Characteristic BodyRearTrunkCapacity => Characteristic.Set("480 mm");
        public Characteristic SuspensionFront => throw new NotImplementedException();
        public Characteristic SuspensionBack => throw new NotImplementedException();
        public Characteristic SteeringControlSteeringMechanism => throw new NotImplementedException();
        public Characteristic TiresGeneralProportions => Characteristic.Set("185/65 R15 (88/92, H/T); 195/55 R16 (91, H)");
    }
}
