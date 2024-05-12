using UnityEngine;

public class PowerSwitch : MonoBehaviour, ISwitchable
{
    [SerializeField] private float duration = 5f;

    [SerializeField] private bool isActive;

    public bool IsActive
    {
        get => isActive;
        set => isActive = hingeJointLimits.Angle >= hingeJointLimits.LimitsMax - hingeJointLimits.LimitsOffset;
    }

    private IHingeJointLimits hingeJointLimits;

    private IStateMachine stateMachine;

    private void Awake()
    {
        hingeJointLimits = GetComponentInChildren<IHingeJointLimits>();
        stateMachine = transform.parent.GetComponent<IStateMachine>();
    }

    private void OnDestroy()
    {
        stateMachine = null;
        hingeJointLimits = null;
    }
}