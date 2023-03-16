using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endgame : MonoBehaviour
{
    public ScoreText score;
    private void Start()
    {
        
    }
    public void GameOverScreen()
    {
        gameObject.SetActive(true);
        
    }
    public void GameOverScreen2()
    {
        gameObject.SetActive(false);
    }
}
