using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Function to load a scene by its name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Function to go back to the MainMenu scene
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Function to quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
