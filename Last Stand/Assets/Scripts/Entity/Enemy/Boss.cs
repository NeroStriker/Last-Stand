using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    public Stats stats;
    public int maxHealth;
    public int currentHealth;
    public int damage;



    private void Start()
    {
        maxHealth = stats.maxHealth;
        currentHealth = stats.currentHealth;
        currentHealth = maxHealth;

    }


    private void Update()
    {
        if (currentHealth <= 0) GameWon();
        Destroy(gameObject);
    }
    

    public void GameWon()
    {
        FindObjectOfType<GameManagerScript>().GameWon();
    }
    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;

    }


}
