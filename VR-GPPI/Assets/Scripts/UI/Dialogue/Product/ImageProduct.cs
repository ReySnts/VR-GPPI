using UnityEngine;
using UnityEngine.UI;

public class ImageProduct : MonoBehaviour, IProduct<Sprite>
{
    public void Initialize(Sprite sprite) => GetComponent<Image>().sprite = sprite;
}