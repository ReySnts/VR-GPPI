using UnityEngine;

public class SensorDoor : MonoBehaviour, ISensorDoor
{
    public IGrabbable Grabbable { get; private set; }

    public IHingeJointLimits HingeJointLimits { get; private set; }

    public ILockable Lockable { get; private set; }

    public ITriggerable Triggerable { get; private set; }

    private void Awake()
    {
        Grabbable = GetComponentInChildren<IGrabbable>();
        HingeJointLimits = GetComponentInChildren<IHingeJointLimits>();
        Lockable = GetComponentInChildren<ILockable>();
        Triggerable = GetComponentInChildren<ITriggerable>();
    }
}