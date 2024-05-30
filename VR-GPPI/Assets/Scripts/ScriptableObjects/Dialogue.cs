using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Dialogue", menuName = "ScriptableObjects/Dialogue")]
public class Dialogue : ScriptableObject
{
    [FormerlySerializedAs(oldName: "spawnPosition"), Space(height: 10f)] public Vector3 spawnPosition;

    [FormerlySerializedAs(oldName: "dialogueTitle"), Space(height: 10f)] public EDialogueTitle dialogueTitle;

    [FormerlySerializedAs(oldName: "text"), Space(height: 10f), TextArea(minLines: 1, maxLines: 20)] public string text;
}