using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public bool isPlayerDead = false;

    public void OnPlayerDeath()
    {
        isPlayerDead = true;
        Invoke("LoadSceneOnPlayerDeath", 3);
    }

    private void LoadSceneOnPlayerDeath()
    {
        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

}
