using UnityEngine;
using UnityEngine.Events;

public class CollectKey : MonoBehaviour
{
    public UnityEvent OnKeyPickUp;

    private void Start()
    {
        OnKeyPickUp.AddListener(GameObject.FindGameObjectWithTag("Key").GetComponent<KeyText>().IncrementKey);
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnKeyPickUp.Invoke();

        }
    }
}
