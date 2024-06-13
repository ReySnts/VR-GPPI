public interface IProgress : IGameObject
{
    public abstract int ChildCount { get; }

    public abstract float Percentage { get; set; }
}