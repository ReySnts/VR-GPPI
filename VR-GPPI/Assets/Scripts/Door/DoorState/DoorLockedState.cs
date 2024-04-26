using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorLockedState : DoorState
{
    [SerializeField] private InteractionLayerMask nothing;

    public override void Enter()
    {
        door.InteractionLayerMask = nothing;
        door.Rigidbody.isKinematic = true;
    }

    public override void DoUpdate() { }

    public override void Exit() => door.Animator.Play(AnimatorParameter.DOOR_UNLOCKING);
}