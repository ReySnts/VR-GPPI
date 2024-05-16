using UnityEngine;

public abstract class State<TStateMachine> : MonoBehaviour where TStateMachine : IState
{
    protected IStateMachine<TStateMachine> stateMachine;

    protected virtual void Awake() => stateMachine = transform.parent.GetComponent<IStateMachine<TStateMachine>>();

    protected void OnDestroy() => stateMachine = null;
}