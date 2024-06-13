using System.Threading.Tasks;
using UnityEngine;

public abstract class ObjectPoolReleaseAll : MonoBehaviour
{
    private IObjectPool iObjectPool;

    private INotifierAction iNotifierAction;

    protected abstract void ReleaseAllFromPool();

    protected virtual void Awake()
    {
        iObjectPool = GetComponent<IObjectPool>();
        iNotifierAction = GetComponentInParent<INotifierAction>();
        iNotifierAction.OnAllNotified += ReleaseAllFromPool;
    }

    protected async Task Release()
    {
        await Task.Delay(millisecondsDelay: 1);
        iObjectPool.ReleaseFromPool();
    }

    private void OnDestroy() => iNotifierAction.OnAllNotified -= ReleaseAllFromPool;
}