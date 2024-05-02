using System;

public interface INotifierStructOut<TObject, TStruct> where TObject : class where TStruct : struct
{
    public abstract event Func<TObject, TStruct> OnChangeValue;

    public abstract TStruct Change(TObject _object);
}