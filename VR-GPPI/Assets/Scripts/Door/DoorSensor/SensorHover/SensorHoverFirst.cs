using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SensorHoverFirst : MonoBehaviour
{
    [SerializeField] private XRSimpleInteractable simpleInteractable;

    [SerializeField] private IState doorUnlockingState;

    private INotifier<IState> notifier;

    private void Awake()
    {
        var door = transform.parent.parent.parent.parent;
        notifier = door.GetComponent<INotifier<IState>>();
        doorUnlockingState = door.GetChild(2).GetComponentInChildren<DoorUnlockingState>();
        simpleInteractable.firstHoverEntered.AddListener(call => notifier.Change(doorUnlockingState));
    }

    private void OnDestroy()
    {
        simpleInteractable.firstHoverEntered.RemoveListener(call => notifier.Change(doorUnlockingState));
        doorUnlockingState = null;
        notifier = null;
    }
}