using UnityEngine;

public class MenuCanvas : MonoBehaviour
{
    [SerializeField] protected MenuCanvas menuCanvas;

    protected void Awake() => gameObject.SetActive(false);
}