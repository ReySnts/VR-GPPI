using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DialogueFactory : MonoBehaviour, IDialogueFactory
{
    [SerializeField] private GameObject canvasDialogue;

    [field: SerializeField] public int CurrentIndex { get; private set; } = 0;

    public List<Dialogue> DialogueList { get; private set; } = new();

    private void Awake()
    {
        DialogueList = Resources.LoadAll<Dialogue>(path: ResourcePath.DIALOGUE).ToList();
        GetProduct();
    }

    public IProduct<Dialogue> GetProduct(int additionalIndex = 0)
    {
        var dialogue = DialogueList[CurrentIndex += additionalIndex];
        var instance = Instantiate(original: canvasDialogue, parent: transform, rotation: Quaternion.identity, position: dialogue.spawnPosition);
        var newProduct = instance.GetComponent<CanvasDialogue>();
        newProduct.Initialize(dialogue);
        return newProduct;
    }
}