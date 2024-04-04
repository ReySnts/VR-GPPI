using UnityEngine;

public class DoorStateMachine : MonoBehaviour, IStateMachine
{
    [field: SerializeField] public bool IsLocked { get; set; } = true;

    private IState currentState;

    public DoorLockedState LockedState { get; private set; }

    public DoorUnlockedState UnlockedState { get; private set; }

    private void RegisterState()
    {
        LockedState = new(stateMachine: this);
        UnlockedState = new(stateMachine: this);
    }

    private void Start()
    {
        RegisterState();
        Initialize();
    }

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