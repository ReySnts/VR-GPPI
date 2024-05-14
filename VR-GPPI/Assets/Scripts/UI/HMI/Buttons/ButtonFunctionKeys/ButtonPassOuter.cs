using UnityEngine;

public class ButtonPassOuter : ButtonFunctionKeys
{
    [SerializeField] private ChamberDoor passChamberOuterDoor;

    public override void OnClick()
    {
        Button.interactable = false;
        passChamberOuterDoor.Lockable.IsLocked = false;
    }
}