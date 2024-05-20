using UnityEngine;

public class ButtonChamberDoor : ButtonScript
{
    [SerializeField] private ChamberDoor chamberDoor;

    public override void OnClick() => chamberDoor.Lockable.IsLocked = false;
}