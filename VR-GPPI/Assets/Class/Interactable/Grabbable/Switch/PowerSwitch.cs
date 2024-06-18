using UnityEngine;

public class PowerSwitch : MonoBehaviour, ISwitchable
{
    public IHingeJointLimits HingeJointLimits { get; private set; }

    public ITriggerable Triggerable { get; private set; }

    private void Awake()
    {
        HingeJointLimits = GetComponentInChildren<IHingeJointLimits>();
        Triggerable = GetComponentInChildren<ITriggerable>();
    }

    private void OnDestroy()
    {
        Triggerable = null;
        HingeJointLimits = null;
    }
}