using UnityEngine;

public class ToolKBS : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GameObjectTag.LAP))
        {
            Destroy(other.gameObject);
            Debug.Log("YEAH");
        }
    }
}