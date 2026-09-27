using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int coins = 0;
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        instance = this;
    }

    public void AddCoin()
    {
        coins++;

        coinText.text = "COINS: " + coins;

        if (coins >= 4)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}