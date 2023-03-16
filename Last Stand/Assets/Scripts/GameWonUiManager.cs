using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWonUiManager : MonoBehaviour
{
    public GameObject gameOverMenu;

    public void EnableGameWonMenu()
    {
        gameOverMenu.SetActive(true);
    }
}
