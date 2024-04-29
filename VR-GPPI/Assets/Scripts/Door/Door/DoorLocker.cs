using UnityEngine;

public class DoorLocker : MonoBehaviour
{
    [SerializeField] private Transform door;

    private IGrabbableLock grabLockable;

    private void Awake() => grabLockable = door.GetComponent<IGrabbableLock>();

    private void OnDestroy() => grabLockable = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == door.gameObject.name) grabLockable.IsLocked = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == door.gameObject.name) grabLockable.IsLocked = false;
    }
}