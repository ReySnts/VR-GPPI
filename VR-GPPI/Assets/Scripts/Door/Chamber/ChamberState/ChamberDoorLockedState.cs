using UnityEngine;

public class ChamberDoorLockedState : DoorState<IHingedDoor>, IStateEnterable
{
    [SerializeField] private ChamberDoorUnlockedState unlockedState;

    public void Enter()
    {
        
    }

    public void DoUpdate()
    {

    }
}