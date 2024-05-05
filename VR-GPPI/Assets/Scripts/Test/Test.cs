using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private List<Dialogue> dialogueList = new();

    private void Start()
    {
        dialogueList = Resources.LoadAll<Dialogue>("ScriptableObjects/Dialogues").ToList();
    }
}