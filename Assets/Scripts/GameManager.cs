using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        if (Application.isPlaying)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
#else
        Application.Quit();
#endif
    }
}