using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public Vector2 spawnPosition;
     public GameObject prefabToSpawn;
     private float score=0;
    void Start()
    {
        // SpawnObject();
        // this.score = 0;
        InvokeRepeating("SpawnObject", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //  SpawnObject();
    }

    void SpawnObject()
    {
        // Calculate a random position within spawn area
        Vector3 randomPosition = new Vector2(
            Random.Range(-spawnPosition.x , spawnPosition.x), spawnPosition.y
        );
        score += 1;
        Debug.Log("Score================: " + score);
        // Instantiate the prefab at the calculated position
        Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);
    }
}
