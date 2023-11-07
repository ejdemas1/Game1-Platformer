using UnityEngine;

public class Camera3Follow : MonoBehaviour
{
    public Transform target; 
    public float smoothSpeed = 0.125f; 
    public float minY = 0f; 
    public float minX = 0f; 
    public float maxX = 40f; 

    private void FixedUpdate()
    {
        if (target != null)
        {
            float desiredX = Mathf.Clamp(target.position.x, minX, maxX);
            Vector3 desiredPosition = new Vector3(desiredX, minY, transform.position.z);

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
