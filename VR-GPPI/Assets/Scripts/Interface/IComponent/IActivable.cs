public interface IActivable<T>
{
    public abstract void Activate(T t);

    public abstract void Deactivate();
}