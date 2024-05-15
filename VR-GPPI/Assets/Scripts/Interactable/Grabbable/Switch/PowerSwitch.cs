using UnityEngine;

public class PowerSwitch : MonoBehaviour, ISwitchable
{
    public IHingeJointLimits HingeJointLimits { get; private set; }

    public ILockable Lockable { get; private set; }

    private void Awake()
    {
        HingeJointLimits = GetComponentInChildren<IHingeJointLimits>();
        Lockable = GetComponentInChildren<ILockable>();
    }

    private void OnDestroy()
    {
        Lockable = null;
        HingeJointLimits = null;
    }
}