public class DoorUnlockingState : DoorState
{
    public override void Enter()
    {
        stateMachine.IsLocked = true;
        //animator.Play(AnimatorParameter.DOOR_UNLOCK);
    }

    public override void Update()
    {
        //if (door.rotation.z != initialPosition) stateMachine.TransitionTo(stateMachine.UnlockedState);
    }

    public override void Exit()
    {
        stateMachine.IsLocked = false;
        //animator.StopPlayback();
    }
}