using UnityEngine;

public class IsolatorStatePreoperationalPass : IsolatorEnterableState, IStateEnterable
{
    [SerializeField] private ObjectPoolReleaseAll objectPoolReleaseAll;

    public void Enter()
    {
        objectPoolReleaseAll.ReleaseAllFromPool();
    }

    public void DoUpdate()
    {

    }
}