using UnityEngine;

public class CanvasRotator : MonoBehaviour
{
    private Transform mainCamera;

    private void Awake() => mainCamera = GameObject.Find(GameObjectName.MAIN_CAMERA).transform;

    private void Update()
    {
        var worldPosition = new Vector3(x: mainCamera.position.x, y: transform.position.y, z: mainCamera.position.z);
        transform.LookAt(worldPosition);
        transform.forward *= -1f;
    }
}