using UnityEngine;

public abstract class StateMachine<TState> : MonoBehaviour, IStateMachine<TState> where TState : IState
{
    protected abstract TState FirstState { get; }

    private IState currentState;

    public virtual void TransitionTo(TState nextState) => currentState = nextState;

    protected void Start() => TransitionTo(FirstState);

    protected void Update() => currentState.DoUpdate();
}