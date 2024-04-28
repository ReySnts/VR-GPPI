using UnityEngine;

public class DoorStateMachine : MonoBehaviour
{
    public IStateEnterable LockedState { get; private set; }

    public IStateComplete UnlockingState { get; private set; }

    public IStateEnterable UnlockedState { get; private set; }

    private IState currentState;

    private void Awake()
    {
        LockedState = GetComponentInChildren<DoorLockedState>();
        UnlockingState = GetComponentInChildren<DoorUnlockingState>();
        UnlockedState = GetComponentInChildren<DoorUnlockedState>();
    }

    private void Start() => TransitionTo(LockedState);

    public void TransitionTo(IStateEnterable nextState)
    {
        currentState = nextState;
        nextState.Enter();
    }

    private void Update() => currentState.DoUpdate();
}