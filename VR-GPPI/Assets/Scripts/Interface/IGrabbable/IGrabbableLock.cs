public interface IGrabbableLock : IGrabbable
{
    public abstract bool IsLocked { get; set; }

    public abstract bool IsTriggered { get; set; }
}