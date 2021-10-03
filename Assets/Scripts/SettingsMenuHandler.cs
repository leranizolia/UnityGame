using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenuHandler : MonoBehaviour
{
    public Button Cancel;
    public Button Save;

    private void Start()
    {
        Cancel.onClick.AddListener(CancelChangingSettings);
        Save.onClick.AddListener(SaveSettings);
    }

    //TODO: saving settings
    private void SaveSettings()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    private void CancelChangingSettings()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
