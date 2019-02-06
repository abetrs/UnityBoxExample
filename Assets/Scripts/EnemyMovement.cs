using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float movementSpeed;
    Vector3 velocity = Vector3.back;
    public Spawner spawner;
    DifficultyManager difficultyManager;

    private void Start()
    {
        difficultyManager = spawner.GetComponent<DifficultyManager>();
    }

    void FixedUpdate()
    {
        movementSpeed = difficultyManager.movementSpeed;
        transform.Translate(velocity * movementSpeed * Time.fixedDeltaTime);
    }
}
