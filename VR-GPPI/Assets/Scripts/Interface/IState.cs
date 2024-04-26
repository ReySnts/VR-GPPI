public interface IState
{
    public abstract void Enter();

    public abstract void DoUpdate();

    public abstract void Exit();
}