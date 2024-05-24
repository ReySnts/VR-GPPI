using UnityEngine;

public abstract class MenuState : MonoBehaviour, IMenuState
{
    public GameObject GameObject => gameObject;

    public abstract EMenuState EMenuState { get; }

    public IImageSprite ImageSprite { get; private set; }

    private void Awake() => ImageSprite = GetComponentInChildren<IImageSprite>();
}