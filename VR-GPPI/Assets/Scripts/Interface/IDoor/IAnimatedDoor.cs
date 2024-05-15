public interface IAnimatedDoor : ILockableThing
{
    public abstract INotifier<string> Notifier { get; }

    public abstract IOpenable Openable { get; }

    public abstract IHandle Handle { get; }
}