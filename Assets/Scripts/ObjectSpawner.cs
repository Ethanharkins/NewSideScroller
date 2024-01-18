using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    public float spawnInterval = 2.0f;
    private float timer;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnObject();
            timer = spawnInterval;
        }
    }

    void SpawnObject()
    {
        int index = Random.Range(0, objectPrefabs.Length);
        GameObject spawnedObject = Instantiate(objectPrefabs[index], transform.position, Quaternion.identity);

        // Set the initial direction to left
        Vector2 spawnDirection = Vector2.left; // Left direction in 2D
        ObjectMovement objectMovement = spawnedObject.GetComponent<ObjectMovement>();
        if (objectMovement != null)
        {
            objectMovement.SetInitialDirection(spawnDirection);
        }
    }


}
