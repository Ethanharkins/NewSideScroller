using UnityEngine;

public class ObjectSpin : MonoBehaviour
{
    public float spinSpeed = 100.0f; // Degrees per second

    void Update()
    {
        // Rotate counterclockwise around the Z-axis
        transform.Rotate(0, 0, -spinSpeed * Time.deltaTime);
    }
}
