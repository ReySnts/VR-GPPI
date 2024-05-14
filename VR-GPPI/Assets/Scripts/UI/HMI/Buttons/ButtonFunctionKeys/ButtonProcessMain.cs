using UnityEngine;

public class ButtonProcessMain : ButtonFunctionKeys
{
    [SerializeField] private ChamberDoor processChamberMainDoor;

    public override void OnClick()
    {
        Button.interactable = false;
        processChamberMainDoor.Lockable.IsLocked = false;
    }
}