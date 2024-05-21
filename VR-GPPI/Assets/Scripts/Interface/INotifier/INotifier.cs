using UnityEngine.Events;

public interface INotifier<T>
{
    public abstract event UnityAction<T> OnAllChanged;

    public abstract void ChangeAll(T t);
}