public class LeftDoor : Door
{
    public override bool IsLocked
    {
        get => isLocked;
        set => isLocked = Angle >= LimitsMax - 0.1f;
    }
}