using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRMoveProvider : MonoBehaviour, IMoveProvider
{
    public ActionBasedContinuousMoveProvider ActionBasedContinuous { get; private set; }

    private INotifier<bool> iNotifier;

    private float initialMoveSpeed;

    private void Awake()
    {
        ActionBasedContinuous = GetComponent<ActionBasedContinuousMoveProvider>();
        iNotifier = GetComponentInParent<INotifier<bool>>();
        iNotifier.OnAllChanged += SetSpeed;
        initialMoveSpeed = ActionBasedContinuous.moveSpeed;
    }

    private void SetSpeed(bool isPaused) => ActionBasedContinuous.moveSpeed = isPaused ? 0 : initialMoveSpeed;

    private void OnDestroy()
    {
        iNotifier.OnAllChanged -= SetSpeed;
        iNotifier = null;
        ActionBasedContinuous = null;
    }
}