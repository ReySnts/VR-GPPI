using UnityEngine;

public abstract class DoorState : MonoBehaviour
{
    protected IGrabbableLock grabLockable;

    protected DoorStateMachine stateMachine;

    protected void Awake()
    {
        var states = transform.parent;
        grabLockable = states.parent.GetComponent<IGrabbableLock>();
        stateMachine = states.GetComponent<DoorStateMachine>();
    }
}