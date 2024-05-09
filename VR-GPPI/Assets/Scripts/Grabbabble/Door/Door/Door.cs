using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public abstract class Door : MonoBehaviour, IDoor
{
    [field: SerializeField] public InteractionLayerMask InteractionLayerMask { get; set; }

    [field: SerializeField] public Rigidbody Rigidbody { get; private set; }

    [field: SerializeField] public XRGrabInteractable GrabInteractable { get; private set; }

    [field: SerializeField] public bool IsTriggered { get; set; }

    [SerializeField] protected bool isLocked;

    public abstract bool IsLocked { get; set; }

    protected IHingeJointLimits hingeJointLimits;

    private void Start() => hingeJointLimits = GetComponentInChildren<IHingeJointLimits>();

    private void Update() => IsLocked = isLocked;
}