using UnityEngine;
using UnityEngine.Events;

public abstract class Notifier<T> : MonoBehaviour, INotifier<T>
{
    public event UnityAction<T> OnAllChanged;

    public void ChangeAll(T t) => OnAllChanged.Invoke(t);
}