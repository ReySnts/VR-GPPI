public class RoomDoorRight : RoomDoor
{
    public override bool IsLocked
    {
        get => isLocked;
        set => isLocked = hingeJointLimits.Angle <= hingeJointLimits.LimitsMin + hingeJointLimits.LimitsOffset;
    }
}