public class LockableSensorDoorRight : Lockable<ISensorDoor>
{
    public override bool IsLocked
    {
        get => isLocked;
        set
        {
            var hingeJoint = lockableThing.HingeJointLimits;
            isLocked = hingeJoint.Angle <= hingeJoint.LimitsMin + hingeJoint.LimitsOffset;
        }
    }
}