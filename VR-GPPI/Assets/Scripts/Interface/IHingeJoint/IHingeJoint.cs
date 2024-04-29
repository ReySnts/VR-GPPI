using UnityEngine;

public interface IHingeJoint
{
    public abstract HingeJoint HingeJoint { get; }

    public abstract float Angle { get; set; }
}