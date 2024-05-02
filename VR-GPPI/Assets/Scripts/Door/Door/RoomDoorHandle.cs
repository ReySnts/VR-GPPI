using UnityEngine;

public class RoomDoorHandle : MonoBehaviour
{
    //private INotifierStructOut<Transform, Vector3> notifierStructOut;

    private void Awake()
    {
        //notifierStructOut = transform.parent.parent.GetComponent<INotifierStructOut<Transform, Vector3>>();
        //notifierStructOut.OnChangeValue += transform;
    }

    private void OnDestroy()
    {
        
    }
}