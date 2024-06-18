using UnityEngine;
using UnityEngine.UI;

public class HMIMenu : MonoBehaviour
{
    [SerializeField] private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
        image.sprite = null;
    }

    public void Set(Sprite sprite) => image.sprite = sprite;
}