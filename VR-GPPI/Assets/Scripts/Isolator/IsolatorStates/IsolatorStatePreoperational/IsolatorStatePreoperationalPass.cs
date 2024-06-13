using UnityEngine;

public class IsolatorStatePreoperationalPass : IsolatorEnterableState, IStateEnterable
{
    [SerializeField] private NotifierAction notifierAction;

    public void Enter() => notifierAction.NotifyAll();

    public void DoUpdate()
    {

    }
}