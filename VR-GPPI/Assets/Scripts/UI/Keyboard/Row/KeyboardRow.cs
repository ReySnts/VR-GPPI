using UnityEngine;

public abstract class KeyboardRow<TCharacter> : MonoBehaviour
{
    protected abstract TCharacter[] Characters { get; }

    protected virtual void Awake()
    {
        var charactersLength = Characters.Length;
        var keyboardKeyFactory = GetComponent<IKeyboardKeyFactory>();
        for (int index = 0; index < charactersLength; index++) keyboardKeyFactory.GetProduct(parameter: Characters[index].ToString());
    }
}