using UnityEngine;

public class LivesUIManager : MonoBehaviour
{
    private bool livesLocked = false;

    public void SetLivesLocked(bool locked)
    {
        livesLocked = locked;
        // Update the UI accordingly
    }

    // Rest of the script...
}
