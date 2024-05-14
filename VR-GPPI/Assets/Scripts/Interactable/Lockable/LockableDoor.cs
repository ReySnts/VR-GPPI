public class LockableDoor : Lockable<IDoor>
{
    public override bool IsLocked 
    {
        get => isLocked;
        set => isLocked = value;
    }
}