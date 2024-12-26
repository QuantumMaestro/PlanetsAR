using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSceneController : MonoBehaviour
{
    // Load a scene by name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Reload the current scene
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Quit the application
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting...");
    }
}
