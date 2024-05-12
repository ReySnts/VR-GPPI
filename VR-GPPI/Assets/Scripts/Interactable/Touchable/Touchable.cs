using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Touchable : MonoBehaviour, ITouchable
{
    [field: SerializeField] public InteractionLayerMask InteractionLayerMask { get; set; }

    [field: SerializeField] public Rigidbody Rigidbody { get; private set; }

    [field: SerializeField] public XRSimpleInteractable SimpleInteractable { get; private set; }
}