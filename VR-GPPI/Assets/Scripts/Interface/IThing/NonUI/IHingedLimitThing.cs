public interface IHingedLimitThing : ILockableThing
{
    public abstract IHingeJointLimits HingeJointLimits { get; }
}