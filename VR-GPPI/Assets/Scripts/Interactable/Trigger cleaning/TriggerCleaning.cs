using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCleaning : MonoBehaviour
{
    public int clean = 0;
    [SerializeField] private GameObject cleanUI;
    [SerializeField] private int dirty = 5;

    private void Update()
    {
        if (clean == dirty)
        {
            cleanUI.SetActive(true);
        }
    }

}
