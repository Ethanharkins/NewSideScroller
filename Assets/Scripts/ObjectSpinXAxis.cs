using UnityEngine;

public class ObjectSpinXAxis : MonoBehaviour
{
    public float spinSpeed = 360.0f; // Adjust the speed as needed

    void Update()
    {
        // Rotate around the X-axis
        transform.Rotate(spinSpeed * Time.deltaTime, 0, 0);
    }
}
