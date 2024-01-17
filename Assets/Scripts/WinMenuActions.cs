using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenuActions : MonoBehaviour
{
    public void RestartLevel()
    {
        Time.timeScale = 1; // Ensure the time is running
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1; // Ensure the time is running
        SceneManager.LoadScene("MainMenu"); // Replace with your main menu scene name
    }

    public void LoadLevelSelection()
    {
        Time.timeScale = 1; // Ensure the time is running
        SceneManager.LoadScene("LevelSelection"); // Replace with your level selection scene name
    }
}
