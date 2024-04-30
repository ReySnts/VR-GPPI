using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public abstract class Door : MonoBehaviour, IRoomDoor
{
    [field: SerializeField] public InteractionLayerMask InteractionLayerMask { get; set; }

    [field: SerializeField] public Rigidbody Rigidbody { get; private set; }

    [field: SerializeField] public HingeJoint HingeJoint { get; private set; }

    [field: SerializeField] public XRGrabInteractable GrabInteractable { get; private set; }

    [field: SerializeField] public bool IsTriggered { get; set; }

    [SerializeField] protected bool isLocked;

    public abstract bool IsLocked { get; set; }

    [field: SerializeField] public float LimitsMin { get; set; }

    [field: SerializeField] public float LimitsMax { get; set; }

    [field: SerializeField] public float Angle { get; set; }

    private void Start()
    {
        LimitsMin = HingeJoint.limits.min;
        LimitsMax = HingeJoint.limits.max;
    }

    private void Update()
    {
        Angle = HingeJoint.angle;
        IsLocked = isLocked;
    }
}