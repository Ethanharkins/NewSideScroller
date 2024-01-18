using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Vector2 movementDirection = Vector2.left; // Default direction

    void Update()
    {
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
    }

    public void SetInitialDirection(Vector2 direction)
    {
        movementDirection = direction;
    }



public void ReverseDirection()
    {
        movementDirection *= -1;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
