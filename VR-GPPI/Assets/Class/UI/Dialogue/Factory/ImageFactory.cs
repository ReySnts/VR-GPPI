using UnityEngine;

public class ImageFactory : MonoBehaviour, IFactory<Sprite, Sprite>
{
    [SerializeField] private GameObject imageProduct;

    public IProduct<Sprite> GetProduct(Sprite sprite)
    {
        var instance = Instantiate(original: imageProduct, parent: transform);
        var newProduct = instance.GetComponent<ImageProduct>();
        newProduct.Initialize(sprite);
        return newProduct;
    }
}