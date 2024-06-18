using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableDistance : XRGrabInteractable
{
    [SerializeField] private float maxDistance = .25f;

    private IXRSelectInteractor hand;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        hand = args.interactorObject;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        hand = null;
    }

    private void Update()
    {
        foreach (var collider in colliders)
        {
            if (hand is not null)
            {
                var handPosition = hand.transform.position;
                var colliderPosition = collider.transform.position;
                var currentDistance = Vector3.Distance(handPosition, colliderPosition);
                if (currentDistance > maxDistance) interactionManager.SelectExit(interactor: hand, interactable: this);
                else interactionManager.SelectEnter(interactor: hand, interactable: this);
            }
        }
    }
}