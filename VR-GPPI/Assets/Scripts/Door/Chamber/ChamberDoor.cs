using UnityEngine;

public class ChamberDoor : MonoBehaviour, IAnimatedDoor
{
    public IAnimator Animator { get; private set; }

    public ILockable Lockable { get; private set; }

    public IOpenable Openable { get; private set; }

    public IHandle Handle { get; private set; }

    private void Awake()
    {
        Animator = GetComponentInChildren<IAnimator>();
        Lockable = GetComponentInChildren<ILockable>();
        Openable = GetComponentInChildren<IOpenable>();
        Handle = GetComponentInChildren<IHandle>();
    }
}