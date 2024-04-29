public interface IHingeJointLimits : IHingeJoint
{
    public abstract float LimitsMin { get; set; }

    public abstract float LimitsMax { get; set; }
}