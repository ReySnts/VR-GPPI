using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Door : MonoBehaviour, IGrabbableLock
{
    [field: SerializeField] public InteractionLayerMask InteractionLayerMask { get; set; }

    [field: SerializeField] public Rigidbody Rigidbody { get; private set; }

    [field: SerializeField] public XRGrabInteractable GrabInteractable { get; private set; }

    [field: SerializeField] public bool IsTriggered { get; set; }

    [SerializeField] private bool isLocked = true;

    public bool IsLocked
    {
        get => isLocked;
        set => isLocked = transform.rotation.z == initialRotationZ;
    }

    private float initialRotationZ;

    private void Start() => initialRotationZ = transform.rotation.z;

    private void Update() => GrabInteractable.interactionLayers = InteractionLayerMask;
}