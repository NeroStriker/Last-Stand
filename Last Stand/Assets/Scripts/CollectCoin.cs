using UnityEngine;
using UnityEngine.Events;

public class CollectCoin : MonoBehaviour
{
    public UnityEvent OnCoinPickUp;

    private void Start()
    {
        OnCoinPickUp.AddListener(GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreText>().IncrementCoin);
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnCoinPickUp.Invoke();
            
        }
    }

    
}
