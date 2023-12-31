using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPauseController : MonoBehaviour
{
    [SerializeField] private string menuScene = "StartScene";
    [SerializeField] private string playScene = "Overworld";

    public GameObject pauseMenuPanel;

    public void Resume()
    {
        pauseMenuPanel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    public void Restart()
    {
        pauseMenuPanel.SetActive(false);
        SceneManager.LoadScene(playScene);
    }

    public void QuitToMainMenu()
    {
        pauseMenuPanel.SetActive(false);
        SceneManager.LoadScene(menuScene);
    }
}