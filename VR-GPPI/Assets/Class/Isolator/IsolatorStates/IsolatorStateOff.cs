using UnityEngine;

public class IsolatorStateOff : IsolatorEnterableState, IStateComplete
{
    [SerializeField] private IsolatorStateStart startState;

    private ISwitchable switchable;

    public void Enter() => switchable = transform.parent.parent.GetComponentInChildren<ISwitchable>();

    public void DoUpdate()
    {
        if (switchable.Triggerable.IsTriggered)
        {
            Exit();
            stateMachine.TransitionTo(startState);
        }
    }

    public void Exit() => switchable = null;
}