using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    
    public PlayerHealth playerHealth;
    public float BulletTime = 2;
    public BulletType bulletType;

    void Start()
    {
        BulletTime += Time.time;
    }
    private void Update()
    {
        CountDown();
    }
    private void CountDown()
    {
        if (BulletTime <= Time.time)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            var playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if(playerHealth != null)
            {
                playerHealth.TakeDamage(bulletType.damage);
                
            }
            
        }
        
    }



}
