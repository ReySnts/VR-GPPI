public class LockableSensorDoorLeft : Lockable<ISensorDoor>
{
    public override bool IsLocked
    {
        get => isLocked;
        protected set
        {
            var hingeJoint = lockableThing.HingeJointLimits;
            isLocked = hingeJoint.Angle >= hingeJoint.LimitsMax - hingeJoint.LimitsOffset;
        }
    }
}