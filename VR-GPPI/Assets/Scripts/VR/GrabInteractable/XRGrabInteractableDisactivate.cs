using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableDisactivate : XRGrabInteractable
{
    private IGameObject iGameObject;

    protected override void Awake()
    {
        base.Awake();
        iGameObject = GetComponentInChildren<IGameObject>();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        iGameObject.GameObject.SetActive(false);
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        iGameObject.GameObject.SetActive(true);
        base.OnSelectExited(args);
    }
}