using UnityEngine;

public class SpecialObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            PlayerController playerController = collider.gameObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.ActivatePowerUp();
                Destroy(gameObject); // Optional: Destroy the special object
            }
        }
    }
}
