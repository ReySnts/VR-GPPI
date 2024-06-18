using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableActivate : XRGrabInteractable
{
    private IGameObject iGameObject;

    private IXRSelectInteractor interactor;

    protected override void Awake()
    {
        base.Awake();
        iGameObject = GetComponentInChildren<IGameObject>();
        iGameObject.GameObject.SetActive(false);
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        iGameObject.GameObject.SetActive(true);
        interactor = args.interactorObject;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        iGameObject.GameObject.SetActive(false);
        interactor = null;
    }
}