using UnityEngine;

public class ObjectSpin : MonoBehaviour
{
    public float rotationSpeed = 360.0f; // Speed of rotation, degrees per second

    void Update()
    {
        // Rotate around its local Z-axis
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
