using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChamberHandle : MonoBehaviour, ITouchable
{
    [field: SerializeField] public InteractionLayerMask InteractionLayerMask { get; set; }

    [field: SerializeField] public Rigidbody Rigidbody { get; set; }

    [field: SerializeField] public XRSimpleInteractable SimpleInteractable { get; set; }
}