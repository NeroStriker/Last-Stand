using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject canonBall;
    public Transform ShootPoint;

    [SerializeField] private KeyCode shootKeyCode;







    private void Update()
    {
        if (Input.GetKeyDown(shootKeyCode))
        {
            Instantiate(canonBall, ShootPoint);
            Shoot();
        }
    }

    private void Shoot()
    {
        
        Debug.Log("Shoot");
    }



}
