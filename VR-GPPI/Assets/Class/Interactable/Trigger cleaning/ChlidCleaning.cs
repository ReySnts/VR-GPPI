using UnityEngine;

public class ChlidCleaning : MonoBehaviour
{
    [SerializeField] private TriggerCleaning parent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GameObjectTag.LAP))
        {
            parent.clean++;
            gameObject.SetActive(false);
        }
    }
}