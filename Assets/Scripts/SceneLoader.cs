using UnityEngine;
using UnityEngine.SceneManagement; // Make sure to include this

public class SceneLoader : MonoBehaviour
{
    // Public function to be called by the button
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // Loads the scene with the specified name
    }

    // Optional: Load scene by build index
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
