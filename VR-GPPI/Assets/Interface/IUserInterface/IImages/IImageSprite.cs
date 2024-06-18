using UnityEngine;

public interface IImageSprite : IImage
{
    public abstract Sprite Sprite { get; set; }
}