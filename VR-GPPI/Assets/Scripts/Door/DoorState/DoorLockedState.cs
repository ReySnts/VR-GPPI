public class DoorLockedState : DoorState
{
    public override void Enter()
    {
        stateMachine.IsLocked = true;
    }

    public override void Update()
    {
        
    }

    public override void Exit()
    {
        stateMachine.IsLocked = true;
    }
}