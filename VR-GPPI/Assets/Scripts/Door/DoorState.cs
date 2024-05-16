using UnityEngine;

public abstract class DoorState<TDoor> : State<IState> where TDoor : IDoor
{
    protected TDoor door;

    protected override void Awake()
    {
        base.Awake();
        door = transform.parent.parent.GetComponent<TDoor>();
    }
}