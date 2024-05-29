public interface IKeyboard : IUserInterface, IActivable<IInputField>
{
    public abstract IInputField CurrentInputField { get; }
}