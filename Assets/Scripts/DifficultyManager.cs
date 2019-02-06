using UnityEngine;

[RequireComponent(typeof(Spawner))]
public class DifficultyManager : MonoBehaviour
{
    Spawner spawner;
    float timeTillNextDifficultyIncrease = 10;
    public float timeBetweenDifficultyIncrease;
    public float movementSpeed;
    public float movementSpeedIncrease;
    public float spawnTimeDecrease;
    private void Start()
    {
        spawner = GetComponent<Spawner>();
    }

    private void Update()
    {
        if (Time.timeSinceLevelLoad > timeTillNextDifficultyIncrease)
        {
            timeTillNextDifficultyIncrease = Time.timeSinceLevelLoad + timeBetweenDifficultyIncrease;
            int difficultyIncreaseMethod = Random.Range(1, 3);
            Debug.Log(difficultyIncreaseMethod);
            switch (difficultyIncreaseMethod)
            {
                case 1:
                    IncreaseEnemyMovementSpeed();
                    break;
                case 2:
                    DecreaseSpawnTime();
                    break;
            }
            Debug.Log(movementSpeed);
            Debug.Log(spawner.timeBetweenSpawn);
        }
    }

    private void IncreaseEnemyMovementSpeed()
    {
        if (movementSpeed < 80)
        {
            movementSpeed += movementSpeedIncrease;
        }
    }

    private void DecreaseSpawnTime()
    {
        if (spawner.timeBetweenSpawn > 0.5)
        {
            spawner.timeBetweenSpawn -= spawnTimeDecrease;
        }
    }
}
