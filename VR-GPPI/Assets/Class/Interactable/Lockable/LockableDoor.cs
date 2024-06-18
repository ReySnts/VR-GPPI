public class LockableDoor : Lockable<ILockableThing>
{
    public override bool IsLocked 
    {
        get => isLocked;
        set => isLocked = value;
    }
}