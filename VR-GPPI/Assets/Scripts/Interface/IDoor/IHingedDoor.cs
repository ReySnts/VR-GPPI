public interface IHingedDoor : IDoor
{
    public abstract IGrabbable Grabbable { get; }

    public abstract IHingeJointLimits HingeJointLimits { get; }
}