using UnityEngine;

public abstract class DoorState : MonoBehaviour, IState
{
    protected Door door;

    protected DoorStateMachine stateMachine;

    public abstract void Enter();

    public abstract void DoUpdate();

    public abstract void Exit();

    protected void Awake()
    {
        door = transform.parent.parent.GetComponent<Door>();
        stateMachine = transform.parent.GetComponent<DoorStateMachine>();
    }
}