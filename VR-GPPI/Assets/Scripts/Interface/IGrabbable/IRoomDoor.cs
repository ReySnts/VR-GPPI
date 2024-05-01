public interface IRoomDoor : IGrabbable, ILockable
{
    public abstract bool IsTriggered { get; set; }
}