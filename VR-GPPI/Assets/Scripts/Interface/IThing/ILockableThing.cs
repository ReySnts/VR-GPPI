public interface ILockableThing : IThing
{
    public abstract ILockable Lockable { get; }
}