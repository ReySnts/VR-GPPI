public interface IFactory<TProduct>
{
    public abstract int CurrentIndex { get; set; }

    public abstract int TotalProducts { get; }

    public abstract IProduct<TProduct> GetProduct(int index);
}