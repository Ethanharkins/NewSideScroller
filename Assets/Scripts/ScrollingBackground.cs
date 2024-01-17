using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public GameObject[] backgrounds; // Two background images
    public float scrollSpeed = 0.5f;

    private float backgroundWidth; // Width of a single background image

    void Start()
    {
        // Assuming both backgrounds are the same size
        backgroundWidth = backgrounds[0].GetComponent<Renderer>().bounds.size.x;

        // Position the second background immediately after the first
        Vector3 startPosition = backgrounds[0].transform.position;
        startPosition.x += backgroundWidth;
        backgrounds[1].transform.position = startPosition;
    }

    void Update()
    {
        foreach (GameObject bg in backgrounds)
        {
            // Move each background to the left
            bg.transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

            // Check if the background has moved completely off-screen
            if (bg.transform.position.x <= -backgroundWidth)
            {
                // Reposition the background to the end of the other background
                Vector3 newPosition = bg.transform.position;
                newPosition.x += backgroundWidth * 2;
                bg.transform.position = newPosition;
            }
        }
    }
}
