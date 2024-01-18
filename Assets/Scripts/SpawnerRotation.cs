using UnityEngine;

public class SpawnerRotation : MonoBehaviour
{
    [SerializeField]
    private float rotationAngle = 0.0f; // Rotation angle in degrees

    void Update()
    {
        // Rotate the spawner to the specified angle
        transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
    }
}
