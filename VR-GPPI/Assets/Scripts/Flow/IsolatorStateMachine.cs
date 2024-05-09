using UnityEngine;

public class IsolatorStateMachine : MonoBehaviour, IStateMachine
{
    public IState FirstState => transform.GetChild(index: 0).GetComponentInChildren<StartState>();

    public IState CurrentState { get; set; }

    public void TransitionTo(IState nextState)
    {
        var newState = nextState as IStateExitable;
    }
}