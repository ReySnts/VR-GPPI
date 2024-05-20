//using System;
using UnityEngine;

public abstract class KeyboardKeySpawner<TKey> : MonoBehaviour
{
    [SerializeField] private GameObject shadowCharacter;

    [SerializeField] private GameObject character;

    [SerializeField] protected Transform shadowParent;

    protected abstract TKey[] Keys { get; }

    protected virtual void Awake()
    {
        var keysLength = Keys.Length;
        for (int index = 0; index < keysLength; index++)
        {
            Instantiate(original: shadowCharacter, parent: shadowParent);
            var character = Instantiate(original: this.character, parent: transform);
            character.GetComponentInChildren<IKeyboardKey>().Character = Keys[index].ToString();
        }
    }
}