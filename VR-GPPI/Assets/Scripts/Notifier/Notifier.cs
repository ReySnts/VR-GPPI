using UnityEngine;
using UnityEngine.Events;

public abstract class Notifier<TObject> : MonoBehaviour, INotifier<TObject> where TObject : class
{
    public event UnityAction<TObject> OnChangeObject;

    public void Change(TObject _object) => OnChangeObject.Invoke(_object);
}