using Unity.XR.CoreUtils;

public interface IScene : IGameObject
{
    public abstract XROrigin XROrigin { get; }
}