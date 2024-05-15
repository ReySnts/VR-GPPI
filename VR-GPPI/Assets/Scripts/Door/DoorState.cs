using UnityEngine;

public abstract class DoorState<TDoor> : MonoBehaviour where TDoor : ILockableThing
{
    protected TDoor door;

    protected IStateMachine stateMachine;

    protected void Awake()
    {
        var states = transform.parent;
        door = states.parent.GetComponent<TDoor>();
        stateMachine = states.GetComponent<IStateMachine>();
    }
}