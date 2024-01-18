using UnityEngine;

public class RestartTimer : MonoBehaviour
{
    private float timer = 0f;

    public float GetTime()
    {
        return timer;
    }

    public void Reset()
    {
        timer = 0f;
    }

    public void UpdateTimer()
    {
        timer += Time.deltaTime;
    }
}
