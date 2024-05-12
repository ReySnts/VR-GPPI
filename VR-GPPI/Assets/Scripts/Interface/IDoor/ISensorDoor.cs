public interface ISensorDoor : IHingedDoor
{
    public abstract ILockable Lockable { get; }

    public abstract ITriggerable Triggerable { get; }
}