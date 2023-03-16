public class PlayerHealth : HealthSystem
{
    public Stats stats;

    public HealthBar healthBar;
    
    void Start()
    {
        maxHealth = stats.maxHealth;
        currentHealth = stats.currentHealth;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) EndGame();
        
        
    }
    private void EndGame()
    {        
        FindObjectOfType<GameManagerScript>().EndGame();

    }

    public override void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthBar.SetHealth(currentHealth);

    }

    
    
}
