using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public Vector2 spawnPosition;
     public GameObject prefabToSpawn;
     private int score=0;
     public TextMeshProUGUI textMeshPro;
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
        // Instantiate the prefab at the calculated position
        textMeshPro.text = score.ToString();
        Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);
    }
}
