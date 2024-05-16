using UnityEngine;

public abstract class State<TThing, TStateMachine> : MonoBehaviour where TThing : IThing where TStateMachine : IState
{
    protected TThing statableThing;

    protected IStateMachine<TStateMachine> stateMachine;

    protected void Awake()
    {
        var states = transform.parent;
        statableThing = states.parent.GetComponent<TThing>();
        stateMachine = states.GetComponent<IStateMachine<TStateMachine>>();
    }

    protected void OnDestroy() => stateMachine = null;
}