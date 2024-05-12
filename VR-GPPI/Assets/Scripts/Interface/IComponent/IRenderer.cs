using UnityEngine;

public interface IRenderer
{
    public abstract MeshRenderer MeshRenderer { get; set; }

    public abstract Material Material { get; set; }
}