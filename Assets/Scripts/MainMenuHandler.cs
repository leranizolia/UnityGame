using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    public Button Play;
    public Button Settings;
    public Button Exit;

    private void Start()
    {
        Play.onClick.AddListener(PlayGame);
        Settings.onClick.AddListener(ChooseSettings);
        Exit.onClick.AddListener(ExitGame);
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    private void ChooseSettings()
    {
        SceneManager.LoadScene("SettingsMenuScene");
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
