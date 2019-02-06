using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class ScoreDisplay : MonoBehaviour
{
    Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        int lastScore = PlayerPrefs.GetInt("Last Score");
        int highScore = PlayerPrefs.GetInt("High Score");
        scoreText.text = "last score: " + lastScore + "\n high score: " + highScore;        
    }
}
