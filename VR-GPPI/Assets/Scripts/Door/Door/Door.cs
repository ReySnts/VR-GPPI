using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Door : MonoBehaviour, IGrabbableLock
{
    [field: SerializeField] public InteractionLayerMask InteractionLayerMask { get; set; }

    [field: SerializeField] public Rigidbody Rigidbody { get; private set; }

    [field: SerializeField] public XRGrabInteractable GrabInteractable { get; private set; }

    [field: SerializeField] public bool IsLocked { get; set; }

    [field: SerializeField] public bool IsTriggered { get; set; }

    private void Update() => GrabInteractable.interactionLayers = InteractionLayerMask;
}