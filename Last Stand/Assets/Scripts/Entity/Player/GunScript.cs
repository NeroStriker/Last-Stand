using System.Collections;
using TMPro;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public int damage = 10;
    public float range = 100f;
    public ParticleSystem muzzleFlash;
    public GameObject impactEff;
    public float impactForce;
    public float fireRate;
    public float maxAmmo;
    public float currentAmmo;
    public float reloadTime;
    public bool isReloading = false;
    public Animator animator;
    public AudioSource shooting;

    public Camera fpsCam;
    private float nextTimeToFire = 0f;
    public TextMeshProUGUI ammunitionDisplay;



    void Start()
    {
        currentAmmo = maxAmmo;   
    }
    private void OnEnable()
    {
        isReloading = false;
        animator.SetBool("Reloading", false);
    }


    void Update()
    {
        if (isReloading)
            return;

        if(currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire= Time.time + 1f/fireRate;
            Shoot();
        }
        if (ammunitionDisplay != null)
        {
            ammunitionDisplay.SetText(currentAmmo.ToString() + "/" + maxAmmo);
        }
    }
    IEnumerator Reload()
    {
        isReloading= true;
        Debug.Log("Reloading...");
        animator.SetBool("Reloading", true);
        yield return new WaitForSeconds(reloadTime - .25f);
        animator.SetBool("Reloading", false);
        yield return new WaitForSeconds(.25f);
        currentAmmo = maxAmmo;
        isReloading= false;
    }
    public void Shoot()
    {
        muzzleFlash.Play();

        currentAmmo--;
        shooting.PlayOneShot(shooting.clip);

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            

            Enemy enemy= hit.transform.GetComponent<Enemy>();
            Boss boss = hit.transform.GetComponent<Boss>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            if (boss != null)
            {
                boss.TakeDamage(damage);
            }
            if (hit.rigidbody!= null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
        GameObject impactGO = Instantiate(impactEff, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impactGO, 2f);

                
    }
}
