using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;
    public Image[] hearts; // UI Images for the hearts
    public GameObject gameOverCanvas; // Game Over Canvas
    public GameObject livesCanvas; // Lives Canvas

    void Start()
    {
        gameOverCanvas.SetActive(false);
        livesCanvas.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Example: If the player collides with an enemy or hazard
        if (other.gameObject.CompareTag("Enemy"))
        {
            LoseLife();
        }
    }

    void LoseLife()
    {
        if (lives > 0)
        {
            lives--;
            hearts[lives].enabled = false;

            if (lives <= 0)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        gameOverCanvas.SetActive(true);
        livesCanvas.SetActive(false);
        Time.timeScale = 0; // Stop the game
        // Additional game over logic
    }

    // Add any other methods related to player health.
}
