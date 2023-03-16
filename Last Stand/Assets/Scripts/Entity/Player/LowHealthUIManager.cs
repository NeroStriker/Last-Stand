using UnityEngine;
using System;

public class LowHealthUIManager : MonoBehaviour
{
    public PlayerHealth p_health;
    public event Action<GameObject> OnLowHealth, OnGoodHealth;
    public GameObject vignette;
    private void Start()
    {
        OnLowHealth += OnLowHealthHandler;
        OnGoodHealth+= OnGoodHealthHandler;
    }

    private void Update()
    {
        if (p_health.currentHealth <= p_health.maxHealth/2)
        {
            OnLowHealth?.Invoke(vignette);
        }
        if (p_health.currentHealth >= p_health.maxHealth / 2)
        {
            OnGoodHealth?.Invoke(vignette);
        }
    }
   public void OnLowHealthHandler(GameObject a)
    {
        a.SetActive(true);
        Debug.Log("Evento enviado y recibido por LowHealthUIManager, OnLowHealthtHandler, el evento de recuperar vida no tiene debuglog porque llena la consola");
    }
    public void OnGoodHealthHandler(GameObject a)
    {
        a.SetActive(false);
        
    }
}
