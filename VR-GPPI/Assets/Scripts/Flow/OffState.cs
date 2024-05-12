using UnityEngine;

public class OffState : IsolatorState, IStateComplete
{
    [SerializeField] private StartState startState;

    public void Enter()
    {
        
    }

    public void DoUpdate()
    {
        //stateMachine.TransitionTo(startState);
    }

    public void Exit()
    {

    }
}