using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadBattle()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartBattle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
