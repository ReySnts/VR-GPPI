public interface IAnimatedDoor : IDoor
{
    public abstract IAnimator Animator { get; }

    public abstract ILockable Lockable { get; }

    public abstract IOpenable Openable { get; }

    public abstract IHandle Handle { get; }
}