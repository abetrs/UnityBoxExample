using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class Score : MonoBehaviour
{
    Text scoreText;
    GameManager gameManager;
    int score = 0;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        if (!gameManager.isPlayerDead)
        {
            score = (int) Time.timeSinceLevelLoad;
            scoreText.text = "score: " + score;
        } else
        {
            scoreText.text = "score: " + score + "\n oof";
        }
    }
    private void OnDestroy()
    {
        int highScore = PlayerPrefs.GetInt("High Score");
        if (highScore != 0)
        {
            if (score > highScore)
            {
                PlayerPrefs.SetInt("High Score", score);
                PlayerPrefs.SetInt("Last Score", score);
            } else
            {
                PlayerPrefs.SetInt("Last Score", score);
            }
        } else
        {
            PlayerPrefs.SetInt("High Score", score);
            PlayerPrefs.SetInt("Last Score", score);
        }
        Debug.Log("Score: " + PlayerPrefs.GetInt("Last Score"));
        Debug.Log("High Score: " + PlayerPrefs.GetInt("High Score"));
    }
}
