using UnityEngine;

public class AutomaticCanon : MonoBehaviour
{


    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform ShootingPoint;
    [SerializeField] private float ShootingCooldown = 1;
    private float CanonCooldown;
    // Start is called before the first frame update
    void Start()
    {
        ShootingCooldown += Time.time;
        CanonCooldown = ShootingCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        Cooldown();
    }

    private void Shoot()
    {
        Instantiate(bullet, ShootingPoint.position, ShootingPoint.rotation);
    }

    private void Cooldown()
    {
        
        if ( CanonCooldown <= Time.time )
        {
            Shoot();
            CanonCooldown = ShootingCooldown + Time.time;
        }
    }
}
