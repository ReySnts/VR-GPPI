using UnityEngine;

public class CanvasTransformerRotation : CanvasTransformer
{
    private void Update()
    {
        var worldPosition = new Vector3(x: mainCameraTransform.position.x, y: transform.position.y, z: mainCameraTransform.position.z);
        transform.LookAt(worldPosition);
        transform.forward *= -1f;
    }
}