using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    
    public int maxHealth;
    public int currentHealth;
    public int damage;
    

    
    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
    }
    public void Die()
    {
        if (currentHealth <=0)
        {
            Destroy(gameObject);
        }
    }

}
