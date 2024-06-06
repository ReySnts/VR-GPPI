using UnityEngine;

public class DirtyObject : MonoBehaviour
{
    private IObjectPool iPool;

    private IProgress iProgress;

    private void Awake()
    {
        iPool = GetComponentInParent<IObjectPool>();
        iProgress = GetComponentInParent<IProgress>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GameObjectTag.LAP))
        {
            iProgress.Percentage += 100 / iPool.InitialSize;
            Destroy(gameObject);
        }
    }
}