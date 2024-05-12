using UnityEngine;

public class RoomDoorStateMachine : MonoBehaviour, IStateMachine
{
    public IState FirstState => GetComponentInChildren<RoomDoorLockedState>();

    public IState CurrentState { get; set; }

    private void Start() => TransitionTo(FirstState);

    public void TransitionTo(IState nextState)
    {
        var nextEnterableState = nextState as IStateEnterable;
        CurrentState = nextEnterableState;
        nextEnterableState.Enter();
    }

    private void Update() => CurrentState.DoUpdate();
}