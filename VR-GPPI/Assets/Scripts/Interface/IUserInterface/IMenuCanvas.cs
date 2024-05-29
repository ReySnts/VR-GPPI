public interface IMenuCanvas : IUserInterface
{
    public abstract IPanel Panel { get; }

    public abstract void DoTransition();
}