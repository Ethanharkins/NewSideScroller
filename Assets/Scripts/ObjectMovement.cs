using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed; // Horizontal movement speed
    private float rotationSpeed; // Rotation speed

    void Start()
    {
        rotationSpeed = Random.Range(-100f, 100f); // Random rotation speed
    }

    void Update()
    {
        // Move the object to the left
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Rotate the object
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
