using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuMainController : MonoBehaviour
{
    [SerializeField] string menuScene = "StartScene";
    [SerializeField] string playScene = "Overworld";

    [SerializeField] GameObject optionsMenuPanel;
    [SerializeField] GameObject optionsCloseButton;
    [SerializeField] GameObject optionsOpenButton;

    public void OptionsMenuClose()
    {
        EventSystem.current.SetSelectedGameObject(optionsOpenButton);
        optionsMenuPanel.SetActive(false);
    }

    public void OptionsMenuOpen()
    {
        optionsMenuPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(optionsCloseButton);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(playScene);
        SceneManager.UnloadSceneAsync(menuScene);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
}