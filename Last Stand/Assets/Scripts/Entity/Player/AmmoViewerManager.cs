using System.Collections.Generic;
using UnityEngine;

public class AmmoViewerManager : MonoBehaviour
{
    public List<GameObject> currentAmmoDisplay;

    private void Start()
    {

        currentAmmoDisplay[0].SetActive(true);

    }
    private void Update()
    {
        WeaponInHand();
    }

    void WeaponInHand()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentAmmoDisplay[0].SetActive(true);
            currentAmmoDisplay[1].SetActive(false);
            currentAmmoDisplay[2].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentAmmoDisplay[0].SetActive(false);
            currentAmmoDisplay[1].SetActive(true);
            currentAmmoDisplay[2].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentAmmoDisplay[0].SetActive(false);
            currentAmmoDisplay[1].SetActive(false);
            currentAmmoDisplay[2].SetActive(true);
        }
    }


}
