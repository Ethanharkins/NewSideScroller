using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SceneResetManager : MonoBehaviour
{
    private Dictionary<string, SceneInitialState> sceneInitialStates = new Dictionary<string, SceneInitialState>();

    // Call this method when the game starts to store initial state
    public void StoreInitialSceneState()
    {
        int sceneCount = SceneManager.sceneCount;

        for (int i = 0; i < sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);

            // Store initial state of each scene
            SceneInitialState initialState = new SceneInitialState();
            // Store relevant data here (positions, scores, timers, etc.)

            sceneInitialStates[scene.name] = initialState;
        }
    }


    // Call this method to reset a specific scene to its initial state
    public void ResetSceneToInitialState(string sceneName)
    {
        if (sceneInitialStates.ContainsKey(sceneName))
        {
            SceneInitialState initialState = sceneInitialStates[sceneName];
            // Reset the scene to its initial state using the stored data

            // Example: Reset player position, scores, timers, etc.
        }
        else
        {
            Debug.LogWarning("Scene name not found in initial states.");
        }
    }
}

public class SceneInitialState
{
    // Define properties to store initial state data
}
