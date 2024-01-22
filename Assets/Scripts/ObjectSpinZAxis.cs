using UnityEngine;

public class ObjectSpinZAxis : MonoBehaviour
{
    public float spinSpeed = 360.0f; // Speed of the spin, adjust as needed

    void Update()
    {
        // Rotate around the Z-axis
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }
}

