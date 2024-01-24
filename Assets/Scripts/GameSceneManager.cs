using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; // Include this for UnityEvent

public class GameSceneManager : MonoBehaviour
{
    [System.Serializable]
    public class SceneChangeEvent : UnityEvent<string> { }

    public static GameSceneManager Instance { get; private set; }

    public SceneChangeEvent onSceneChangeRequest;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    // Other methods...
}
