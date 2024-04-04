public abstract class DoorState : IState
{
    protected IStateMachine stateMachine;

    public DoorState(IStateMachine stateMachine) => this.stateMachine = stateMachine;

    public abstract void Enter();

    public abstract void Update();

    public abstract void Exit();
}