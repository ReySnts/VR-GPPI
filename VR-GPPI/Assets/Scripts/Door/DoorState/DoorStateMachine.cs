using UnityEngine;

public class DoorStateMachine : MonoBehaviour
{
    [field: SerializeField] public bool IsLocked { get; set; } = true;

    [field: SerializeField] public DoorLockedState LockedState { get; private set; }

    [field: SerializeField] public DoorUnlockingState UnlockingState { get; private set; }

    [field: SerializeField] public DoorUnlockedState UnlockedState { get; private set; }

    private IState currentState;

    private void Start() => Initialize();

    private void Initialize()
    {
        currentState = LockedState;
        LockedState.Enter();
    }

    public void TransitionTo(IState nextState)
    {
        currentState.Exit();
        currentState = nextState;
        nextState.Enter();
    }

    private void Update() => currentState.Update();
}