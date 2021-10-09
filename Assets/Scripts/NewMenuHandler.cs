using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewMenuHandler : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Exit()
    {
        Application.Quit();    
    }

    public void LowSettings()
    {
        QualitySettings.SetQualityLevel(0, true);    
    }

    public void MiddleSettings()
    {
        QualitySettings.SetQualityLevel(1, true);
    }

    public void HighSettings()
    {
        QualitySettings.SetQualityLevel(2, true);
    }
}
