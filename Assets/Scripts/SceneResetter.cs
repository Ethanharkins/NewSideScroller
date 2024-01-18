using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneResetter : MonoBehaviour
{
    // This method is called when you want to reset the scene
    public void ResetScene()
    {
        // You can reset object positions, variables, or any other scene-specific state here
        // Example: Reset player position to a starting point
        // Example: Reset game score or progress variables

        // Load the current scene again to effectively reset it
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
