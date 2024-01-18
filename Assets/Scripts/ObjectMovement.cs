using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Vector2 movementDirection;

    void Start()
    {
        // Default direction is left, but can be overridden by the spawner
        movementDirection = Vector2.left;
    }

    void Update()
    {
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
    }

    public void SetInitialDirection(Vector2 direction)
    {
        movementDirection = direction.normalized;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Collision handling logic...
    }

    // Other methods...
}
