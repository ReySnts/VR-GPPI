using UnityEngine;

public abstract class TriggerDetector : MonoBehaviour, IGameObject
{
    protected abstract string TagName {  get; }

    public GameObject GameObject => gameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tag: TagName)) transform.parent.gameObject.SetActive(false);
    }
}