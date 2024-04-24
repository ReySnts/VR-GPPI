using System;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public interface INotifier<TEventArgs, TObject> where TEventArgs : BaseInteractionEventArgs where TObject : UnityEngine.Object
{
    public abstract event Action<TObject> OnAllNotified;

    public abstract UnityEvent<TEventArgs> InteractableEvent { get; }

    public abstract void LetObserverToChange(TObject objectToBeChanged);

    public abstract void NotifyAllToChange(TObject objectToBeChanged);
}