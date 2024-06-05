public interface IObjectPool<T> where T : IGameObject
{
    public abstract void Return(T t);

    public abstract void Release(T t);
}