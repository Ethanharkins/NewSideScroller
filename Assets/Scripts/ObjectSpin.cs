using UnityEngine;

public class ObjectSpin : MonoBehaviour
{
    public float spinSpeed = 100.0f; // Degrees per second

    void Update()
    {
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }
}
