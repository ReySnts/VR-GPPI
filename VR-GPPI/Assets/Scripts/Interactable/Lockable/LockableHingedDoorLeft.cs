public class LockableHingedDoorLeft : Lockable<IHingedDoor>
{
    public override bool IsLocked
    {
        get => isLocked;
        set
        {
            var hingeJoint = lockableThing.HingeJointLimits;
            isLocked = hingeJoint.Angle >= hingeJoint.LimitsMax - hingeJoint.LimitsOffset;
        }
    }
}