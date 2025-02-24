using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("exited game");
    }
}
