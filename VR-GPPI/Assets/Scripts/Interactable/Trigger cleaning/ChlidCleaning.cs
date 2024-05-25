using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChlidCleaning : MonoBehaviour
{
    [SerializeField] private TriggerCleaning parent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("lap"))
        {
            parent.clean++;
            gameObject.SetActive(false);
        }
    }
}
