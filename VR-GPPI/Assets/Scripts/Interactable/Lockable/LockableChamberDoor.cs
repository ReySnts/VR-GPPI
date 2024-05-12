public class LockableChamberDoor : Lockable<IAnimatedDoor>
{
    public override bool IsLocked 
    {
        get => isLocked;
        set => isLocked = value;
    }
}