using UnityEngine;
using TMPro;

public class TimerUp : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Assign your UI TextMeshPro element here
    private float elapsedTime;
    private bool isPlayerAlive = true; // Player's status

    void Update()
    {
        if (isPlayerAlive)
        {
            elapsedTime += Time.deltaTime;
            DisplayTime(elapsedTime);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void PlayerDied()
    {
        isPlayerAlive = false;
    }
}
