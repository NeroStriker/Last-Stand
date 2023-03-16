using UnityEngine.SceneManagement;
using UnityEngine;



public class MainMenuManager : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("GameQuit");
        Application.Quit();
        
    }
}
