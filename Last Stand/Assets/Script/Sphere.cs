using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class Sphere : MonoBehaviour

    
{
    [SerializeField] private string characterName;
    public int health;
    public int maxHealth;
    public int defense;
    public float speed;
    public int damage;
    public int heal;
    public Vector3 direction; 
    private Vector3 movement;
    public Vector3 scale;

   



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Speed(movement);
        Heal(heal);
        Damage(damage);
        MaxHealthCheck(maxHealth);
    }



    public void Speed(Vector3 movement)
    {

        direction = movement;
        movement = new Vector3(speed, 0, 0);
        transform.position += movement;
    }

    public void Heal (int healing)
    {
        if (maxHealth >= health)
        {
            health += healing;
           
        }
        else { health += 0; }
        
    }

    public void Damage (int damage)
    {
        damage = damage - defense;
        if(damage <= 0)
        {
            health -= 0;
        }
        else { health -= damage; }
        
    }

    public void MaxHealthCheck (int check)
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else
        {
            health = health;
        }
    }


}
