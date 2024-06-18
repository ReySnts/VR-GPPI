using UnityEngine;

public class ChamberDoor : MonoBehaviour, IAnimatedDoor
{
    public INotifier<string> Notifier { get; private set; }

    public ILockable Lockable { get; private set; }

    public IOpenable Openable { get; private set; }

    public IHandle Handle { get; private set; }

    private void Awake()
    {
        Notifier = GetComponentInParent<INotifier<string>>();
        Lockable = GetComponentInChildren<ILockable>();
        Openable = GetComponentInChildren<IOpenable>();
        Handle = GetComponentInChildren<IHandle>();
    }
}