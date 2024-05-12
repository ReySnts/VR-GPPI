using UnityEngine;

public class ButtonPassOuter : ButtonFunctionKeys
{
    [SerializeField] private ChamberDoor passChamberOuterDoor;

    private IAnimatedDoor AnimatedDoor => passChamberOuterDoor;

    private void Awake() => button.onClick.AddListener(UnlockDoor);

    private void UnlockDoor()
    {
        button.interactable = false;
        AnimatedDoor.Lockable.IsLocked = false;
    }

    private void OnDestroy() => button.onClick.RemoveListener(UnlockDoor);
}