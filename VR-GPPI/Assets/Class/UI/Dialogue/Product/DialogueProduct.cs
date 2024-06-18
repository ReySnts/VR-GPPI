using TMPro;
using UnityEngine;

public class DialogueProduct : MonoBehaviour, IProduct<Dialogue>
{
    public void Initialize(Dialogue dialogue)
    {
        var panelText = transform.GetChild(index: 1);
        var textTitle = panelText.GetChild(index: 0).GetComponent<TextMeshProUGUI>();
        var textDialogue = panelText.GetChild(index: 1).GetComponent<TextMeshProUGUI>();
        var iImageFactory = transform.GetChild(index: 2).GetComponent<IFactory<Sprite, Sprite>>();
        textTitle.text = dialogue.title.ToString();
        textDialogue.text = dialogue.text;
        foreach (var sprite in dialogue.spriteArray) iImageFactory.GetProduct(parameter: sprite);
    }
}