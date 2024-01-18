using UnityEngine;

public class BorderCollisionHandler : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has an ObjectMovement component
        ObjectMovement movement = collision.gameObject.GetComponent<ObjectMovement>();
        if (movement != null)
        {
            // Reverse the movement direction of the object
            movement.ReverseDirection();
        }
    }
}
