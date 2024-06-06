using UnityEngine;

public interface IObjectPool
{
    public abstract int InitialSize {  get; }

    public abstract void Return(GameObject gameObject);

    public abstract void Release(GameObject gameObject);
}