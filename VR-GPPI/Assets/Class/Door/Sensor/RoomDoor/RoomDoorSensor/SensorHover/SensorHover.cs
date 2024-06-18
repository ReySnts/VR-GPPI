using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public abstract class SensorHover<TEventArgs> : MonoBehaviour where TEventArgs : BaseInteractionEventArgs
{
    [SerializeField] private Material lightColorMaterial;

    protected abstract UnityEvent<TEventArgs> InteractableEvent { get; }

    protected XRSimpleInteractable simpleInteractable;

    private INotifier<Material> notifier;

    protected void Awake()
    {
        simpleInteractable = transform.parent.parent.GetComponentInChildren<XRSimpleInteractable>();
        notifier = GetComponentInParent<INotifier<Material>>();
        InteractableEvent.AddListener(call => notifier.ChangeAll(lightColorMaterial));
    }

    protected void OnDestroy()
    {
        InteractableEvent.RemoveAllListeners();
        notifier = null;
        simpleInteractable = null;
    }
}