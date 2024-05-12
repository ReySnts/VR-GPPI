using UnityEngine;

public class HingedDoor : MonoBehaviour, IHingedDoor
{
    public IGrabbable Grabbable { get; private set; }

    public IHingeJointLimits HingeJointLimits { get; private set; }

    private void Awake()
    {
        Grabbable = GetComponentInChildren<IGrabbable>();
        HingeJointLimits = GetComponentInChildren<IHingeJointLimits>();
    }
}