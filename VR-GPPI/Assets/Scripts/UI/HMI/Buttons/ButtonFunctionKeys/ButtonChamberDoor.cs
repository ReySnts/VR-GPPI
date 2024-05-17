using UnityEngine;

public class ButtonChamberDoor : ButtonScript
{
    [SerializeField] private ChamberDoor chamberDoor;

    public override void OnClick()
    {
        Button.interactable = false;
        chamberDoor.Lockable.IsLocked = false;
    }
}