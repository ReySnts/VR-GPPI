using UnityEngine;

public class OffState : IsolatorState, IStateComplete
{
    [SerializeField] private StartState startState;

    private ISwitchable switchable;

    public void Enter() => switchable = transform.parent.parent.GetComponentInChildren<ISwitchable>();

    public void DoUpdate()
    {
        if (switchable.Lockable.IsLocked)
        {
            Exit();
            stateMachine.TransitionTo(startState);
        }
    }

    public void Exit() => switchable = null;
}