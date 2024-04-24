using UnityEngine;

public interface IObserver<TObject> where TObject : Object
{
    public abstract void Change(TObject objectToBeChanged);
}