using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform[] movePoints;
    private int currentPointIndex = 0;

    void Update()
    {
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
}
