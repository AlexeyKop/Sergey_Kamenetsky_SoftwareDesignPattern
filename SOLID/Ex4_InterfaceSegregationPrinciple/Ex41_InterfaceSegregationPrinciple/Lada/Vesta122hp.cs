namespace RecordPrototype.Lada
{
    public class Vesta122hp : Vesta, IVesta
    {
        public Vesta122hp(string model, string brand)
            : base(model, brand) { }
  
        public Characteristic BodyWheelArrangementTtractionWheels => Characteristic.Set("4x2/front");
        public Characteristic BodyEngineLocation  => Characteristic.Set("front lateral");
        public Characteristic BodyTypeNumberOfDoors  => Characteristic.Set("sedan/4");
        public Characteristic Bodyseats  => Characteristic.Set("5");
        public Characteristic BodyLengthWidthHeight  => Characteristic.Set("4410/1764/1497 mm");
        public Characteristic BodyWheelbase  => Characteristic.Set("2635 mm");
        public Characteristic BodyFrontRearTrack  => Characteristic.Set("1510/1510 mm");
        public Characteristic BodyRoadClearance  => Characteristic.Set("178 mm");
        public Characteristic BodyRearTrunkCapacity  => Characteristic.Set("480 mm");
        public Characteristic SuspensionFront  => Characteristic.Set("Independent suspension, MacPherson type, spring-mounted, with an anti-roll bar");
        public Characteristic SuspensionBack  => Characteristic.Set("Half-independent, lever type, spring-actuated, with oil-actuated or gas-filled telescopic shock absorbers");
        public Characteristic SteeringControlSteeringMechanism  => Characteristic.Set("Piston-rack");
        public Characteristic TiresGeneralProportions => Characteristic.Set("185/65 R15 (88/92, H/T); 195/55 R16 (91, H)");
    }
}
