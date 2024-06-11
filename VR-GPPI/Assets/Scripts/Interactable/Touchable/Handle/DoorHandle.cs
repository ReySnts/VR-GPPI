using UnityEngine;

public class DoorHandle : MonoBehaviour
{
    //private INotifierStructOut<Transform, Vector3> notifierStructOut;

    private void Awake()
    {
        //notifierStructOut = GetComponentInParent<INotifierStructOut<Transform, Vector3>>();
        //notifierStructOut.OnChangeValue += transform;
    }

    private void OnDestroy()
    {
        
    }
}