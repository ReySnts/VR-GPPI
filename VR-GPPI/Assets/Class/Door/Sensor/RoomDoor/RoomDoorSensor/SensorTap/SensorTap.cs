using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public abstract class SensorTap<TEventArgs> : MonoBehaviour where TEventArgs : BaseInteractionEventArgs
{
    [SerializeField] protected bool isTriggered;

    protected abstract UnityEvent<TEventArgs> InteractableEvent { get; }

    protected XRSimpleInteractable simpleInteractable;

    private INotifier<bool> notifier;

    protected void Awake()
    {
        simpleInteractable = transform.parent.parent.GetComponentInChildren<XRSimpleInteractable>();
        notifier = GetComponentInParent<INotifier<bool>>();
        InteractableEvent.AddListener(call => notifier.ChangeAll(isTriggered));
    }

    protected void OnDestroy()
    {
        InteractableEvent.RemoveAllListeners();
        notifier = null;
        simpleInteractable = null;
    }
}