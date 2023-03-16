using UnityEngine;

public class GranadeThrower : MonoBehaviour
{
    public float force = 20f;
    public GameObject granadePref;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ThrowGranade();
        }
    }
    void ThrowGranade()
    {
        GameObject granade = Instantiate(granadePref, transform.position, transform.rotation);
        Rigidbody rb = granade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force, ForceMode.VelocityChange);
    }
}
