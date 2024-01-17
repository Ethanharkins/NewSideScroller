using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectPrefabs; // Assign your object prefabs here
    private float spawnInterval = 2.0f; // Initial spawn interval in seconds
    private float initialSpawnInterval;
    private float timer;

    void Start()
    {
        initialSpawnInterval = spawnInterval;
    }

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
        Instantiate(objectPrefabs[index], transform.position, Quaternion.identity);
    }

    public void IncreaseSpawnRate(float multiplier)
    {
        spawnInterval /= multiplier;
    }

    public void ResetSpawnRate()
    {
        spawnInterval = initialSpawnInterval;
    }
}
