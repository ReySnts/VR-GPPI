using UnityEngine;

public class HingeJointLimits : MonoBehaviour, IHingeJointLimits
{
    [field: SerializeField] public HingeJoint HingeJoint { get; private set; }

    [field: SerializeField] public float LimitsMin { get; set; }

    [field: SerializeField] public float LimitsMax { get; set; }

    [field: SerializeField] public float LimitsOffset { get; set; } = 0.1f;

    [field: SerializeField] public float Angle { get; set; }

    private void Start()
    {
        LimitsMin = HingeJoint.limits.min;
        LimitsMax = HingeJoint.limits.max;
    }

    private void Update() => Angle = HingeJoint.angle;
}