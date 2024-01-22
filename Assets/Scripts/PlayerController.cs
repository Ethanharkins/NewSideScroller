using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Transform[] movePoints; // Assign your move points here
    private int currentPointIndex = 0;
    private bool isInvulnerable = false;
    private float invulnerabilityDuration = 3.0f;
    private LivesUIManager livesUIManager; // Reference to the Lives UI Manager
    private DeathTimer deathTimer; // Reference to the DeathTimer script
    private float initialTimerValue = 40f; // Set this to your initial timer value
    private Timer gameTimer; // Reference to your existing Timer script

    void Start()
    {
        livesUIManager = FindObjectOfType<LivesUIManager>(); // Find and assign the Lives UI Manager
        deathTimer = FindObjectOfType<DeathTimer>(); // Find the DeathTimer in the scene
        gameTimer = FindObjectOfType<Timer>(); // Find the Timer in the scene
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        if (!isInvulnerable)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                MoveToNextPoint(-1); // Move up
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MoveToNextPoint(1); // Move down
            }
        }
    }

    void MoveToNextPoint(int direction)
    {
        currentPointIndex += direction;
        currentPointIndex = Mathf.Clamp(currentPointIndex, 0, movePoints.Length - 1);
        transform.position = movePoints[currentPointIndex].position;
    }

    public void ActivatePowerUp()
    {
        if (!isInvulnerable)
        {
            StartCoroutine(PowerUpRoutine());
        }
    }

    private IEnumerator PowerUpRoutine()
    {
        isInvulnerable = true;
        Time.timeScale = 2.0f; // Double the time scale
        if (livesUIManager != null) livesUIManager.SetLivesLocked(true);

        yield return new WaitForSecondsRealtime(invulnerabilityDuration); // Wait for 3 seconds in real time

        isInvulnerable = false;
        Time.timeScale = 1.0f; // Reset time scale
        if (livesUIManager != null) livesUIManager.SetLivesLocked(false);
    }

    // Method to handle the player's death
    public void HandleDeath()
    {
        float timeLived = initialTimerValue - gameTimer.GetCurrentTime();
        deathTimer.SetTimeLived(timeLived);

        // Other death handling logic...
    }

    // Collision handling, if needed...
}
