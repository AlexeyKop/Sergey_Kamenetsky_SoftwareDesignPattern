namespace RecordPrototype.Lada
{
    public interface IVesta
    {
        Characteristic BodyWheelArrangementTtractionWheels { get; }
        Characteristic BodyEngineLocation { get; }
        Characteristic BodyTypeNumberOfDoors { get; }
        Characteristic Bodyseats { get; }
        Characteristic BodyLengthWidthHeight { get; }
        Characteristic BodyWheelbase { get; }
        Characteristic BodyFrontRearTrack { get; }
        Characteristic BodyRoadClearance { get; }
        Characteristic BodyRearTrunkCapacity { get; }

        Characteristic SuspensionFront { get; }
        Characteristic SuspensionBack { get; }

        Characteristic SteeringControlSteeringMechanism { get; }

        Characteristic TiresGeneralProportions { get; }
    }
}