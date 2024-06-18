using UnityEngine;
using UnityEngine.UI;

public class ImageSprite : MonoBehaviour, IImageSprite
{
    public Image Image { get; private set; }

    [field: SerializeField] public Sprite Sprite { get; set; }

    private void Awake() => Image = transform.parent.parent.parent.GetChild(0).GetChild(0).GetComponent<Image>();

    private void OnEnable() => Image.sprite = Sprite;
}