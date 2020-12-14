using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public Text coinsNumber;

    public static int coinsScore = 0;
    bool gameHasEnded = false;

    void Start()
    {
        coinsNumber.text = coinsScore.ToString();
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            coinsScore = scoreTextScript.coinAmount;
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", 1f);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        scoreTextScript.coinAmount = 0;
    }


    public void RestartFromPauseMenu()
    {
        StartMenu.GameRestarted = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
        Restart();
    }
}
