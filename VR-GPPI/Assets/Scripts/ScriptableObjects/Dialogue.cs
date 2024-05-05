using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "ScriptableObjects/Dialogue")]
public class Dialogue : ScriptableObject
{
    [Space(height: 10f)] public Vector3 spawnPosition;

    [Space(height: 10f)] public EDialogueTitle dialogueTitle;

    [Space(height: 10f), TextArea(minLines: 1, maxLines: 20)] public string text;
}