using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerMachine : MonoBehaviour
{
    [SerializeField] private Material mat;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Pusher")
        {
            transform.localPosition = new Vector3(0.477543086f, 1.8455f, 2.76952243f);
            gameObject.GetComponent<MeshRenderer>().material = mat;
        }
    }

}
