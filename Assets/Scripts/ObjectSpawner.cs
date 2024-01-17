using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectPrefabs; // Assign your object prefabs here
    public float spawnInterval = 2.0f; // Initial spawn interval in seconds
    public Vector2 spawnDirection = Vector2.left; // Default spawn direction
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

        // Apply movement direction
        ObjectMovement objectMovement = spawnedObject.GetComponent<ObjectMovement>();
        if (objectMovement != null)
        {
            objectMovement.SetMovementDirection(spawnDirection);
        }
    }

    public void SetSpawnInterval(float newInterval)
    {
        spawnInterval = newInterval;
    }

    public void SetSpawnDirection(Vector2 newDirection)
    {
        spawnDirection = newDirection;
    }
}
