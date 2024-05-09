using UnityEngine;

public abstract class DoorState : MonoBehaviour
{
    protected IDoor door;

    protected IStateMachine stateMachine;

    protected void Awake()
    {
        var states = transform.parent;
        door = states.parent.GetComponent<IDoor>();
        stateMachine = states.GetComponent<IStateMachine>();
    }
}