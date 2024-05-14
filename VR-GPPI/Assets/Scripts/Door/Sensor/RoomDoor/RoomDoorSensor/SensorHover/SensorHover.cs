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
        var sensor = transform.parent.parent;
        simpleInteractable = sensor.GetComponentInChildren<XRSimpleInteractable>();
        notifier = sensor.parent.GetComponent<INotifier<Material>>();
        InteractableEvent.AddListener(call => notifier.Change(lightColorMaterial));
    }

    protected void OnDestroy()
    {
        InteractableEvent.RemoveAllListeners();
        notifier = null;
        simpleInteractable = null;
    }
}