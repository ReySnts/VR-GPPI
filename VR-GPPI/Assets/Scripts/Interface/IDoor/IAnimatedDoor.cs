public interface IAnimatedDoor : IDoor
{
    public abstract INotifier<string> Notifier { get; }

    public abstract ILockable Lockable { get; }

    public abstract IOpenable Openable { get; }

    public abstract IHandle Handle { get; }
}