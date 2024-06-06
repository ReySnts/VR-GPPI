public interface IProgress
{
    public abstract float Percentage { get; set; }

    public abstract bool IsCompleted { get; }
}