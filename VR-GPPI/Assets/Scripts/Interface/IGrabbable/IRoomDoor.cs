public interface IRoomDoor : IGrabbable, ILockable, IHingeJointLimits
{
    public abstract bool IsTriggered { get; set; }
}