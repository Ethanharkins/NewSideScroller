using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isInvulnerable = false;
    private float invulnerabilityDuration = 3.0f;
    private float invulnerabilityTimer = 0.0f;

    public Transform[] movePoints;
    private int currentPointIndex = 0;

    void Update()
    {
        if (isInvulnerable)
        {
            invulnerabilityTimer -= Time.deltaTime;

            if (invulnerabilityTimer <= 0)
            {
                isInvulnerable = false;
                Time.timeScale = 1.0f; // Reset time scale to normal when invulnerability ends
            }
        }

        // Player movement logic
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveToNextPoint(-1);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveToNextPoint(1);
        }
    }

    void MoveToNextPoint(int direction)
    {
        currentPointIndex += direction;
        currentPointIndex = Mathf.Clamp(currentPointIndex, 0, movePoints.Length - 1);
        transform.position = movePoints[currentPointIndex].position;
    }

    public void ActivateInvulnerabilityAndSpeedBoost()
    {
        isInvulnerable = true;
        invulnerabilityTimer = invulnerabilityDuration;
        Time.timeScale = 2.0f; // Double the time scale
    }
}
