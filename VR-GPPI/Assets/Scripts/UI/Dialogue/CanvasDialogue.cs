using TMPro;
using UnityEngine;

public class CanvasDialogue : MonoBehaviour, IProduct<Dialogue>
{
    private TextMeshProUGUI textTitle;

    private TextMeshProUGUI textDialogue;

    public void Initialize(Dialogue dialogue)
    {
        var panelText = transform.GetChild(1);
        textTitle = panelText.GetChild(0).GetComponent<TextMeshProUGUI>();
        textDialogue = panelText.GetChild(1).GetComponent<TextMeshProUGUI>();
        textTitle.text = dialogue.dialogueTitle.ToString();
        textDialogue.text = dialogue.text;
    }
}