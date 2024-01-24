using UnityEngine;

public class NewObjectMovement : MonoBehaviour
{
    public float speed = 5.0f; // Speed of the object
    public float frequency = 1.0f; // Frequency of the sine wave
    public float magnitude = 1.0f; // Magnitude of the sine wave

    private Vector3 pos;
    private float totalRun = 0.0f;

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        totalRun += Time.deltaTime;
        pos -= transform.right * Time.deltaTime * speed;
        transform.position = pos + transform.up * Mathf.Sin(totalRun * frequency) * magnitude;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object collided with an object tagged as "Player" and is marked as a trigger
        if (other.CompareTag("Player") && other.isTrigger)
        {
            // Destroy the enemy object
            Destroy(gameObject);
        }
    }
}
