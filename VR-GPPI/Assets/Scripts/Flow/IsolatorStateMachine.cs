using UnityEngine;

public class IsolatorStateMachine : MonoBehaviour, IStateMachine
{
    public IState FirstState => GetComponentInChildren<OffState>();

    public IState CurrentState { get; set; }

    public void TransitionTo(IState nextState)
    {
        var nextEnterableState = nextState as IStateEnterable;
        CurrentState = nextEnterableState;
        nextEnterableState.Enter();
    }

    private void Start() => TransitionTo(FirstState);

    private void Update() => CurrentState.DoUpdate();
}