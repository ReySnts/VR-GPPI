public class DoorLeft : Door
{
    public override bool IsLocked
    {
        get => isLocked;
        set => isLocked = hingeJointLimits.Angle >= hingeJointLimits.LimitsMax - hingeJointLimits.LimitsOffset;
    }
}