using UnityEngine;

public abstract class State<TThing, TStateMachine> : MonoBehaviour where TThing : IThing where TStateMachine : IState
{
    protected TThing statableThing;

    protected IStateMachine<TStateMachine> stateMachine;

    protected void Awake()
    {
        statableThing = GetComponentInParent<TThing>();
        stateMachine = GetComponentInParent<IStateMachine<TStateMachine>>();
    }

    protected void OnDestroy() => stateMachine = null;
}