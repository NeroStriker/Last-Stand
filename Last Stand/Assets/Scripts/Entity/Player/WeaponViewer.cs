using System.Collections.Generic;
using UnityEngine;

public class WeaponViewer : MonoBehaviour
{
    

    public List<GameObject> currentWeapon;
    

    private void Start()
    {

        currentWeapon[0].SetActive(true);

    }
    private void Update()
    {
        WeaponInHand();
    }

    void WeaponInHand()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon[0].SetActive(true);
            currentWeapon[1].SetActive(false);
            currentWeapon[2].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon[0].SetActive(false);
            currentWeapon[1].SetActive(true);
            currentWeapon[2].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon[0].SetActive(false);
            currentWeapon[1].SetActive(false);
            currentWeapon[2].SetActive(true);
        }
    }





}
