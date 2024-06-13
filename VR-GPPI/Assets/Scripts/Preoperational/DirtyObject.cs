using UnityEngine;

public class DirtyObject : MonoBehaviour
{
    private IObjectPool iObjectPool;

    private IProgress iProgress;

    private void Awake()
    {
        iObjectPool = GetComponentInParent<IObjectPool>();
        iProgress = GetComponentInParent<IProgress>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GameObjectTag.LAP))
        {
            iProgress.Percentage += 100 / iObjectPool.InitialSize / iProgress.ChildCount;
            iObjectPool.ReturnToPool(gameObject);
        }
    }
}