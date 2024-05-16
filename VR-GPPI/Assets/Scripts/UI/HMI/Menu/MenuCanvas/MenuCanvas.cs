using UnityEngine;

public class MenuCanvas : MonoBehaviour
{
    [SerializeField] protected MenuCanvas menuCanvas;

    protected virtual void Awake() => gameObject.SetActive(false);
}