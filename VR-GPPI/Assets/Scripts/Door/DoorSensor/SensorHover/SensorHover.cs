using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public abstract class SensorHover<TEventArgs> : MonoBehaviour where TEventArgs : BaseInteractionEventArgs
{
    [SerializeField] private Material lightColorMaterial;

    [SerializeField] protected XRSimpleInteractable simpleInteractable;

    protected abstract UnityEvent<TEventArgs> InteractableEvent { get; }

    private INotifier<Material> notifier;

    protected void Awake()
    {
        notifier = transform.parent.parent.parent.GetComponent<INotifier<Material>>();
        InteractableEvent.AddListener(call => notifier.Change(lightColorMaterial));
    }

    protected void OnDestroy()
    {
        InteractableEvent.RemoveListener(call => notifier.Change(lightColorMaterial));
        notifier = null;
    }
}