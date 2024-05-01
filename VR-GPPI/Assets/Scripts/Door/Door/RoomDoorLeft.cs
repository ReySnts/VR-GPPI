public class RoomDoorLeft : RoomDoor
{
    public override bool IsLocked
    {
        get => isLocked;
        set => isLocked = hingeJointLimits.Angle >= hingeJointLimits.LimitsMax - hingeJointLimits.LimitsOffset;
    }
}