using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                // Find the instance in the scene
                _instance = FindObjectOfType<GameManager>();

                // If it's still null, create a new instance
                if (_instance == null)
                {
                    GameObject gameManagerObj = new GameObject("GameManager");
                    _instance = gameManagerObj.AddComponent<GameManager>();
                }

                // Ensure it persists across scenes
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Method to load the MainMenu scene
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Method to load the Level1 scene
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    // Method to load the Controls scene
    public void LoadControls()
    {
        SceneManager.LoadScene("Controls");
    }

    // Method to load the LevelSelection scene
    public void LoadLevelSelection()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    // Method to load the Tutorial scene
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    // Method to load the Survival scene
    public void LoadSurvival()
    {
        SceneManager.LoadScene("Survival");
    }

    // Restart current level
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Quit the game
    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
