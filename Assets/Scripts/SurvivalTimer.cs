using UnityEngine;
using TMPro;

public class SurvivalTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Assign your UI TextMeshPro element here
    private float elapsedTime;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        DisplayTime(elapsedTime);
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
