using UnityEngine;

public class GameOverUIManager : MonoBehaviour
{
    public GameObject gameOverMenu;

    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }
}
