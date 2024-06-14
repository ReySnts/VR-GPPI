using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasDialogue : MonoBehaviour, IProduct<Dialogue>
{
    public void Initialize(Dialogue dialogue)
    {
        var panelText = transform.GetChild(1);
        var textTitle = panelText.GetChild(0).GetComponent<TextMeshProUGUI>();
        var textDialogue = panelText.GetChild(1).GetComponent<TextMeshProUGUI>();
        var image = transform.GetChild(2).GetComponent<Image>();
        textTitle.text = dialogue.title.ToString();
        textDialogue.text = dialogue.text;
        image.gameObject.SetActive(image.sprite = dialogue.sprite);
    }
}