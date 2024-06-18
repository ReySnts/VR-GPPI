public class TriggerableSwitchRight : Triggerable<ISwitchable>
{
    private void Update()
    {
        var hingeJoint = triggerableThing.HingeJointLimits;
        IsTriggered = hingeJoint.Angle <= hingeJoint.LimitsMin + hingeJoint.LimitsOffset;
    }
}