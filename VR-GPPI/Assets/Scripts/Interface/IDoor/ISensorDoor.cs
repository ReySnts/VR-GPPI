public interface ISensorDoor : IHingedDoor
{
    public abstract ILockable Lockable { get; }

    public abstract bool IsTriggered { get; set; }
}