using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public abstract class SensorNotifier<TEventArgs> : MonoBehaviour, INotifier<TEventArgs, Material> where TEventArgs : BaseInteractionEventArgs
{
    [SerializeField] protected XRSimpleInteractable simpleInteractable;

    [SerializeField] protected Material lightColorMaterial;

    public event Action<Material> OnAllNotified;

    public abstract UnityEvent<TEventArgs> InteractableEvent { get; }

    private IObserver<Material> observer;

    protected void Awake()
    {
        observer = transform.parent.parent.GetComponentInChildren<IObserver<Material>>();
        OnAllNotified += LetObserverToChange;
        InteractableEvent.AddListener(args => NotifyAllToChange(lightColorMaterial));
    }

    public void LetObserverToChange(Material material) => observer.Change(material);

    public void NotifyAllToChange(Material objectToBeChanged) => OnAllNotified.Invoke(lightColorMaterial);

    protected void OnDestroy()
    {
        InteractableEvent.RemoveListener(args => NotifyAllToChange(lightColorMaterial));
        OnAllNotified -= LetObserverToChange;
        observer = null;
    }
}