using TMPro;
using UnityEngine;

public class CanvasDialogue : MonoBehaviour, IProduct<Dialogue>
{
    private TextMeshProUGUI textTitle;

    private TextMeshProUGUI textDialogue;

    //private Transform mainCamera;

    public void Initialize(Dialogue dialogue)
    {
        var panelText = transform.GetChild(1);
        textTitle = panelText.GetChild(0).GetComponent<TextMeshProUGUI>();
        textDialogue = panelText.GetChild(1).GetComponent<TextMeshProUGUI>();
        textTitle.text = dialogue.dialogueTitle.ToString();
        textDialogue.text = dialogue.text;
        //mainCamera = GameObject.Find("XR Origin (XR Rig)").GetComponentInChildren<Camera>().transform;
    }

    private void Update()
    {
        //var worldPosition = new Vector3(x: mainCamera.position.x, y: transform.position.y, z: mainCamera.position.z);
        //transform.LookAt(worldPosition);
        //transform.forward *= -1f;
    }
}