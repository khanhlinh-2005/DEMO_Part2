using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f; // dừng game
    }

    public void Retry()
    {
        Time.timeScale = 1f; // bật lại game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}