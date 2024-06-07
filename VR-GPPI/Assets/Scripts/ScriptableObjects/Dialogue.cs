using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Dialogue", menuName = "ScriptableObjects/Dialogue")]
public class Dialogue : ScriptableObject
{
    [FormerlySerializedAs(oldName: FirstVariableName.SPAWN_POSITION), Space(height: 10f)] public Vector3 spawnPosition;

    [FormerlySerializedAs(oldName: FirstVariableName.DIALOGUE_TITLE), Space(height: 10f)] public EDialogueTitle title;

    [FormerlySerializedAs(oldName: FirstVariableName.TEXT), Space(height: 10f), TextArea(minLines: 1, maxLines: 20)] public string text;

    [Space(height: 10f)] public bool isCompleted;
}