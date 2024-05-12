public interface IOpenable
{
    public abstract bool IsAllowedToOpen { get; set; }

    public abstract bool IsAllowedToClose { get; set; }
}