using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider other = collision.collider;
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameManager.OnPlayerDeath();
        }
    }

    private void Update()
    {
        if (transform.position.y < 0)
        {
            gameManager.OnPlayerDeath();
        }
    }
}
