using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed for linear movement

    void Update()
    {
        // Move the object from right to left
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        // Check if the object is off-screen and destroy it
        if (!IsObjectVisible())
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); // Destroy object on collision with player
        }
    }

    bool IsObjectVisible()
    {
        // Check if the object is still within the camera's view
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        return viewPos.x > 0 && viewPos.x < 1 && viewPos.y > 0 && viewPos.y < 1;
    }
}
