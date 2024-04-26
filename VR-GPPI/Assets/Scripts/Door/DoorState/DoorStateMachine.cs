using UnityEngine;
using UnityEngine.Events;

public class DoorStateMachine : MonoBehaviour
{
    [field: SerializeField] public bool IsLocked { get; set; } = true;

    [field: SerializeField] public DoorLockedState LockedState { get; private set; }

    [field: SerializeField] public DoorUnlockingState UnlockingState { get; private set; }

    [field: SerializeField] public DoorUnlockedState UnlockedState { get; private set; }

    private INotifier<IState> notifier;

    private IState currentState;

    private void Awake()
    {
        notifier = transform.parent.parent.parent.GetComponent<INotifier<IState>>();
        notifier.OnChangeObject += TransitionTo;
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

    private void Update() => currentState.DoUpdate();

    private void OnDestroy()
    {
        notifier.OnChangeObject -= TransitionTo;
        notifier = null;
    }
}