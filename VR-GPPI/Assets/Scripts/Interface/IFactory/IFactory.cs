public interface IFactory<TProduct, TParam>
{
    public abstract IProduct<TProduct> GetProduct(TParam parameter);
}