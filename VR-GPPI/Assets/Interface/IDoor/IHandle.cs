public interface IHandle
{
    public abstract ITouchable Touchable { get; }

    public abstract IRenderer Renderer { get; }
}