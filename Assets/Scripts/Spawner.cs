using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform SpawnPointRight;
    public Transform SpawnPointMidRight;
    public Transform SpawnPointMidLeft;
    public Transform SpawnPointLeft;
    public Transform SpawnPointLeftCover;
    Transform spawnTransform;
    public float timeBetweenSpawn = 3;
    float timeTillNextSpawn;

    void Update()
    {
        int genNum = Random.Range(1, 6);
        switch(genNum)
        {
            case 1:
                spawnTransform = SpawnPointRight;
                break;
            case 2:
                spawnTransform = SpawnPointMidRight;
                break;
            case 3:
                spawnTransform = SpawnPointMidLeft;
                break;
            case 4:
                spawnTransform = SpawnPointLeft;
                break;
            case 5:
                spawnTransform = SpawnPointLeftCover;
                break;
        }
        if (Time.timeSinceLevelLoad > timeTillNextSpawn)
        {
            timeTillNextSpawn = Time.timeSinceLevelLoad + timeBetweenSpawn;
            Instantiate(enemyPrefab, spawnTransform.position, spawnTransform.rotation);
        }

    }
}
