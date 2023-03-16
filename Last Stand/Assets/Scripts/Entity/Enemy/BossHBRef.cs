using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHBRef : MonoBehaviour
{
    public BossHealthBar healthBar;
    public int health;
    public GameObject healthBarUI;
    public Stats stats;
    
    void Start()
    {
        health = stats.currentHealth;
    }

  
    void Update()
    {
        health= stats.currentHealth;
        healthBar.SetHealth(health);
        if (health <= 0)
        {
            healthBarUI.SetActive(false);
        }
    }
}
