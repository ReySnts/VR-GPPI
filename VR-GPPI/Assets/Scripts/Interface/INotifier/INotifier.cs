using UnityEngine.Events;

public interface INotifier<TObject> where TObject : class
{
    public abstract event UnityAction<TObject> OnChangeObject;

    public abstract void Change(TObject _object);
}