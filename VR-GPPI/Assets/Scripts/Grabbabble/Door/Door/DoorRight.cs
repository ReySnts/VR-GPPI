public class DoorRight : Door
{
    public override bool IsLocked
    {
        get => isLocked;
        set => isLocked = hingeJointLimits.Angle <= hingeJointLimits.LimitsMin + hingeJointLimits.LimitsOffset;
    }
}