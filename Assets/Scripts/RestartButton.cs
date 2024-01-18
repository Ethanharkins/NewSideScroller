using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RestartButton : MonoBehaviour
{
    public SceneReset sceneReset;

    private void Start()
    {
        Button restartButton = GetComponent<Button>();
        restartButton.onClick.AddListener(ResetLevel);
    }

    public void ResetLevel()
    {
        StartCoroutine(DelayedReset());
    }

    private IEnumerator DelayedReset()
    {
        // Delay for 3 seconds
        yield return new WaitForSeconds(3f);

        // Reset the level
        sceneReset.ResetScene();
    }
}
