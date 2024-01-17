using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Transform[] movePoints; // Assign your move points here
    private int currentPointIndex = 0;
    public bool IsInvincible { get; private set; } = false;

    void Update()
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

    void MoveToNextPoint(int direction)
    {
        currentPointIndex += direction;
        currentPointIndex = Mathf.Clamp(currentPointIndex, 0, movePoints.Length - 1);
        transform.position = movePoints[currentPointIndex].position;
    }

    public void ActivateInvincibility(float duration)
    {
        StartCoroutine(InvincibilityCoroutine(duration));
    }

    private IEnumerator InvincibilityCoroutine(float duration)
    {
        IsInvincible = true;
        yield return new WaitForSeconds(duration);
        IsInvincible = false;
    }

    // Example method handling collision/damage
    public void TakeDamage()
    {
        if (!IsInvincible)
        {
            // Handle damage here
        }
    }
}
