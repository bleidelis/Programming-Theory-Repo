using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    public Transform target;  // The object to follow
    public float smoothSpeed = 0.5f;  // The smoothness of camera movement
    public Vector3 offset;  // The offset from the target object

    private void LateUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target.position);
    }
}
