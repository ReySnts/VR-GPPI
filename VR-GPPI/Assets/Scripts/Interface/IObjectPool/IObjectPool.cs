using UnityEngine;

public interface IObjectPool
{
    public abstract int InitialSize {  get; }

    public abstract void ReturnToPool(GameObject gameObject);

    public abstract void ReleaseFromPool();
}