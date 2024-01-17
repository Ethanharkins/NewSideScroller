using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Vector2 movementDirection = Vector2.left;

    void Update()
    {
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
    }

    public void SetMovementDirection(Vector2 newDirection)
    {
        movementDirection = newDirection.normalized; // Ensure the direction is normalized
    }
}
