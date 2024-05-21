using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DialogueFactory : MonoBehaviour, IFactory<Dialogue>
{
    [SerializeField] private GameObject canvasDialogue;

    public int CurrentIndex { get; set; }

    public int TotalProducts { get; private set; }

    private List<Dialogue> dialogueList = new();

    public IProduct<Dialogue> GetProduct(int index)
    {
        if (index < 0 || index > dialogueList.Count - 1) return null;
        var dialogue = dialogueList[index];
        var instance = Instantiate(original: canvasDialogue, parent: transform, rotation: Quaternion.identity, position: dialogue.spawnPosition);
        var newProduct = instance.GetComponent<CanvasDialogue>();
        newProduct.Initialize(dialogue);
        return newProduct;
    }

    private void Awake()
    {
        dialogueList = Resources.LoadAll<Dialogue>("ScriptableObjects/Dialogues").ToList();
        TotalProducts = dialogueList.Count;
        GetProduct(0);
    }
}