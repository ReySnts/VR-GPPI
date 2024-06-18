using UnityEngine;
using UnityEngine.Events;

public abstract class NotifierAction : MonoBehaviour, INotifierAction
{
    public event UnityAction OnAllNotified;

    public void NotifyAll() => OnAllNotified.Invoke();
}