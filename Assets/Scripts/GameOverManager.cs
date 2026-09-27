using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverText;

    public void ShowGameOver()
    {
        gameOverText.SetActive(true);

        Invoke("RestartLevel", 3f);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene("Level1");
    }
}
