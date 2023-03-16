using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{
    
    
    
    
    bool gameHasEnded = false;

    bool gameWon = false;

    public void GameWon()
    {
        if (gameWon == false)
        {
            gameWon = true;
            FindObjectOfType<GameWonUiManager>().EnableGameWonMenu();
            FindObjectOfType<PlayerMovement>().speed = 0;
            FindObjectOfType<PlayerController>().mouseSensitivity = 0;

            Invoke("Restart", 4f);

        }
    }
    

    public void EndGame () 
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;     
            
            FindObjectOfType<GameOverUIManager>().EnableGameOverMenu();
            FindObjectOfType<PlayerMovement>().speed= 0;
            FindObjectOfType<PlayerController>().mouseSensitivity= 0;
            
            Invoke("Restart", 4f);           

        }
        
    } 

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
