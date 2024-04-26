using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Door : MonoBehaviour, IGrabbable
{
    [field: SerializeField] public InteractionLayerMask InteractionLayerMask { get; set; }

    [field: SerializeField] public Rigidbody Rigidbody { get; private set; }

    [field: SerializeField] public XRGrabInteractable GrabInteractable { get; private set; }

    [field: SerializeField] public Animator Animator { get; private set; }

    public float InitialRotationZ { get; set; }

    private void Start() => InitialRotationZ = transform.rotation.z;

    private void Update() => GrabInteractable.interactionLayers = InteractionLayerMask;
}