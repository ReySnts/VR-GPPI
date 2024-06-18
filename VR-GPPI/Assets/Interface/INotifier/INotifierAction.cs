using UnityEngine.Events;

public interface INotifierAction
{
    public abstract event UnityAction OnAllNotified;

    public abstract void NotifyAll();
}