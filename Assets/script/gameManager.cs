using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public Vector2 spawnPosition;
     public GameObject prefabToSpawn;
     private int score=0;
     public TextMeshProUGUI textMeshPro;
     public GameObject tap_to_start;
     bool start_game = false;
    void Start()
    {
        // SpawnObject();
        // this.score = 0;
        tap_to_start.SetActive(true);
        start_game = false;
        textMeshPro.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && start_game == false) {
            start_game = true;
            if(start_game == true){
                 textMeshPro.enabled = true;
                InvokeRepeating("SpawnObject", 2f, 1f);
                tap_to_start.SetActive(false);
            }

        }
    }

    void SpawnObject()
    {
        // Calculate a random position within spawn area
        Vector3 randomPosition = new Vector2(
            Random.Range(-spawnPosition.x , spawnPosition.x), spawnPosition.y
        );
       

        if(score <= 100000){
            textMeshPro.text = score.ToString();
        }
        score += 1;
        // Instantiate the prefab at the calculated position
        Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);
    }
}
