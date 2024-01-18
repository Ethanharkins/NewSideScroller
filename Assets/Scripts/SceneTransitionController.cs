using UnityEngine;

public class SceneTransitionController : MonoBehaviour
{
    // Reference to the MyGameController
    private MyGameController gameController;

    private void Start()
    {
        // Find the MyGameController instance in the scene
        gameController = MyGameController.instance;

        // Ensure the GameController was found
        if (gameController == null)
        {
            Debug.LogError("MyGameController not found in the scene. Make sure it is present and properly configured.");
        }
    }

    // Load a specific scene
    public void LoadScene(string sceneName)
    {
        if (gameController != null)
        {
            gameController.LoadScene(sceneName);
        }
    }

    // Restart the current scene
    public void RestartScene()
    {
        if (gameController != null)
        {
            gameController.RestartScene();
        }
    }

    // Quit the game
    public void QuitGame()
    {
        if (gameController != null)
        {
            gameController.QuitGame();
        }
    }
}

