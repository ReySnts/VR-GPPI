public interface IKeyboard : IUserInterface, IGameObject
{
    public abstract IInputField CurrentInputField { get; set; }
}