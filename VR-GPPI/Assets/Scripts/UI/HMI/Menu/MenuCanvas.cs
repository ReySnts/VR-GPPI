using UnityEngine;

public class MenuCanvas : MonoBehaviour
{
    [SerializeField] private MenuCanvas menuCanvas;

    public void DoTransition()
    {
        gameObject.SetActive(false);
        menuCanvas.gameObject.SetActive(true);
    }

    protected virtual void Awake() => gameObject.SetActive(false);
}