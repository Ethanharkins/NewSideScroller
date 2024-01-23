using UnityEngine;
using TMPro; // Include this for TextMeshPro

public class DeathTimer : MonoBehaviour
{
    public TextMeshProUGUI deathTimeText; // Reference to the TextMeshProUGUI component
    private TimerUp gameTimer; // Reference to the TimerUp script

    void Start()
    {
        gameTimer = FindObjectOfType<TimerUp>(); // Find the TimerUp script in the scene
    }

    public void SetTimeLived(float timeLived)
    {
        deathTimeText.text = FormatTime(timeLived) + " survived";
    }

    private string FormatTime(float time)
    {
        // Format the time as needed, e.g., into minutes and seconds
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Other methods...
}
