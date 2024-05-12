using UnityEngine;

public class ChamberDoorStateMachine : MonoBehaviour, IStateMachine
{
    public IState FirstState => GetComponentInChildren<ChamberDoorLockedState>();

    public IState CurrentState { get; set; }

    public void TransitionTo(IState nextState)
    {
        
    }

    private void Start() => TransitionTo(FirstState);

    private void Update() => CurrentState.DoUpdate();
}