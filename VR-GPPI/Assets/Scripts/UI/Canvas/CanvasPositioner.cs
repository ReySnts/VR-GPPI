using UnityEngine;
using UnityEngine.Serialization;

public class CanvasPositioner : MonoBehaviour, IGameObject
{
    [FormerlySerializedAs(oldName: FirstVariableName.DISTANCE_TO_MAIN_CAMERA), SerializeField] private float distanceToMainCamera;

    public GameObject GameObject => gameObject; 
    
    private Transform mainCamera;

    private void Awake()
    {
        mainCamera = GameObject.Find(GameObjectName.MAIN_CAMERA).transform;
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        var mainCameraForwardX = mainCamera.forward.x;
        var mainCameraForwardZ = mainCamera.forward.z;
        var normalizedForward = new Vector3(x: mainCameraForwardX, y: 0, z: mainCameraForwardZ).normalized;
        transform.position = mainCamera.position + normalizedForward * distanceToMainCamera;
    }
}