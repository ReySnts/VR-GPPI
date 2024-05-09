public interface IDoor : IGrabbable, ILockable
{
    public abstract bool IsTriggered { get; set; }
}