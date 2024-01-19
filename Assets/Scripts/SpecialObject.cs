using UnityEngine;

public class SpecialObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.ActivateInvulnerabilityAndSpeedBoost();

                // Destroy the special object after activating the boost
                Destroy(gameObject);
            }
        }
    }
}
