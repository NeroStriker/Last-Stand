using UnityEngine;

public class BulletsPhysics : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject explosion;
    public LayerMask whatIsEnemies;

    [Range(0f, 1f)]
    public float bounciness;
    public bool useGravity;

    public int explosionDamage;
    public float explosionRange;

    public int maxCollisions;
    public float maxLifeTime;
    public bool explodeOnTouch = true;

    int collisions;

    PhysicMaterial physics_mat;

    private void Start()
    {
        Setup();
    }

    private void Update()
    {
        if (collisions > maxCollisions) Explode();

        maxLifeTime -= Time.deltaTime;
        if (maxLifeTime <= 0) Explode();
    }

    private void Explode()
    {
        if (explosion != null) Instantiate(explosion, transform.position, Quaternion.identity);

        Collider[] enemies = Physics.OverlapSphere(transform.position, explosionRange, whatIsEnemies);
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].GetComponent<Enemy>().TakeDamage(explosionDamage);
            
        }
        
       
        
        
        Invoke("Delay", 0.05f);

        
    }

    private void Delay()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisions++;

        if (collision.collider.CompareTag("Enemy") && explodeOnTouch) Explode();

        
    }

    private void Setup()
    {
        physics_mat = new PhysicMaterial();
        physics_mat.bounciness = bounciness;
        physics_mat.frictionCombine = PhysicMaterialCombine.Minimum;
        physics_mat.bounceCombine = PhysicMaterialCombine.Maximum;

        GetComponent<SphereCollider>().material = physics_mat;


        rb.useGravity = useGravity;
    }


}
