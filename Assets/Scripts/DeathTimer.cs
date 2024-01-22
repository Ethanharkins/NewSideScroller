using UnityEngine;
using TMPro; // Namespace for TextMeshPro

public class DeathTimer : MonoBehaviour
{
    public TextMeshProUGUI deathTimeText; // Change to TextMeshProUGUI for UI text

    public void SetTimeLived(float timeLived)
    {
        deathTimeText.text = $"{timeLived:0.0} seconds";
    }
}
