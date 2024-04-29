using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DistanceReleaseGrabInteractable : XRGrabInteractable
{
    [SerializeField] private float maxGrabDistance = .25f;

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
        var handleFirstPosition = colliders[0].transform.position;
        var handleSecondPosition = colliders[1].transform.position;
        if (hand is not null)
        {
            var handPosition = hand.transform.position;
            var distanceFirst = Vector3.Distance(handPosition, handleFirstPosition);
            var distanceSecond = Vector3.Distance(handPosition, handleSecondPosition);
            if (distanceFirst > maxGrabDistance || distanceSecond > maxGrabDistance) interactionManager.SelectExit(hand, this);
        }
    }
}