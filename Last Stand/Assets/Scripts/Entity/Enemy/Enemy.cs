using UnityEngine;
using UnityEngine.Events;

public class Enemy : HealthSystem
{

    public Stats stats;
    

    private void Start()
    {
        maxHealth = stats.maxHealth;
        currentHealth = stats.currentHealth;
        currentHealth = maxHealth;
        
    }


    private void Update()
    {
        if (currentHealth <= 0)
        {
            
            Die();
        }
    }

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);

            }

        }

    }

}
