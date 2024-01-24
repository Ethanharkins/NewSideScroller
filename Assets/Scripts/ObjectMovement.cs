using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed for linear movement
    public AudioClip collisionSound; // Assign the collision sound clip in the Inspector
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

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

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object collided with an object tagged as "Player" and is marked as a trigger, and if the object itself has the "Enemy" tag
        if (other.CompareTag("Player") && other.isTrigger && gameObject.CompareTag("Enemy"))
        {
            // Play the collision sound
            PlayCollisionSound();

            // Destroy the enemy object
            Destroy(gameObject);
        }
    }

    bool IsObjectVisible()
    {
        // Check if the object is still within the camera's view
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        return viewPos.x > 0 && viewPos.x < 1 && viewPos.y > 0 && viewPos.y < 1;
    }

    void PlayCollisionSound()
    {
        if (audioSource != null && collisionSound != null)
        {
            // Play the collision sound
            audioSource.clip = collisionSound;
            audioSource.Play();
        }
    }
}
