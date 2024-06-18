using UnityEngine;

public class KeyboardCharacterFactory : MonoBehaviour, IKeyboardKeyFactory
{
    [SerializeField] private GameObject character;

    [SerializeField] private GameObject shadowCharacter;

    [SerializeField] private Transform shadowParent;

    public IProduct<string> GetProduct(string character)
    {
        Instantiate(original: shadowCharacter, parent: shadowParent);
        var instance = Instantiate(original: this.character, parent: transform);
        var newProduct = instance.GetComponentInChildren<IProduct<string>>();
        newProduct.Initialize(product: character);
        return newProduct;
    }
}