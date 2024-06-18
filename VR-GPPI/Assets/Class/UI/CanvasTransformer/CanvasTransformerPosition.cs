using UnityEngine;
using UnityEngine.Serialization;

public class CanvasTransformerPosition : CanvasTransformer
{
    [FormerlySerializedAs(oldName: FirstVariableName.DISTANCE_TO_MAIN_CAMERA), SerializeField] private float distanceToMainCamera;

    protected override void Awake()
    {
        base.Awake();
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        var mainCameraForwardX = mainCameraTransform.forward.x;
        var mainCameraForwardZ = mainCameraTransform.forward.z;
        var normalizedForward = new Vector3(x: mainCameraForwardX, y: 0, z: mainCameraForwardZ).normalized;
        transform.position = mainCameraTransform.position + normalizedForward * distanceToMainCamera;
    }
}