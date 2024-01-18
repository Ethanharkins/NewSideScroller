using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    public float spawnInterval = 2.0f;
    private float timer;
    private bool isSpawning = true;

    void Start()
    {
        // Start spawning objects after a delay of 3 seconds (adjust as needed)
        Invoke("StartSpawning", 3f);
    }

    void Update()
    {
        if (isSpawning)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                SpawnObject();
                timer = spawnInterval;
            }
        }
    }

    void SpawnObject()
    {
        if (objectPrefabs.Length == 0)
        {
            Debug.LogWarning("No object prefabs assigned to ObjectSpawner.");
            return;
        }

        int index = Random.Range(0, objectPrefabs.Length);
        GameObject spawnedObject = Instantiate(objectPrefabs[index], transform.position, Quaternion.identity);

        // Add a script to destroy objects after a certain time if needed
        // Example: Destroy(spawnedObject, 7f);
    }

    // Method to start spawning (called from GameManager or your scene management system)
    public void StartSpawning()
    {
        isSpawning = true;
    }

    // Method to stop spawning (called from GameManager or your scene management system)
    public void StopSpawning()
    {
        isSpawning = false;
    }
}
