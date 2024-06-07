using System.Collections;

public interface ICollectionGeneric<TCollection> where TCollection : ICollection
{
    public abstract TCollection Collection { get; }
}