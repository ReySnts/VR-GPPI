using UnityEngine;

public class MenuCanvas : MonoBehaviour, IMenuCanvas
{
    [SerializeField] private MenuCanvas menuCanvas;

    public void DoTransition()
    {
        gameObject.SetActive(false);
        menuCanvas.gameObject.SetActive(true);
    }

    private void Awake() => gameObject.SetActive(false);
}