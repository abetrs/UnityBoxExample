using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 velocity = Vector3.right;
    public float speed = 10;
    float userinput;
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (gameManager.isPlayerDead)
        {
            this.enabled = false;
        }
        userinput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.Translate(velocity * speed * userinput * Time.fixedDeltaTime);
    }

}
