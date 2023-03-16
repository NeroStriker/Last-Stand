using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossRoom : MonoBehaviour
{
    public GameObject bossHBUI;
    //public GameObject normalBGM;
   // public GameObject bossBGM;
    

    private void Start()
    {
        
    }
    private void Update()
    {
        
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            bossHBUI.SetActive(true);

        }
    }
    




}
