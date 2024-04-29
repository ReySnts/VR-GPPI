using UnityEngine;

public abstract class DoorState : MonoBehaviour
{
    protected IRoomDoor roomDoor;

    protected DoorStateMachine stateMachine;

    protected void Awake()
    {
        var states = transform.parent;
        roomDoor = states.parent.GetComponent<IRoomDoor>();
        stateMachine = states.GetComponent<DoorStateMachine>();
    }
}