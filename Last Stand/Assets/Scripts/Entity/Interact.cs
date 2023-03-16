using UnityEngine;
using UnityEngine.Events;

public class Interact : MonoBehaviour
{
    public bool isInRange;
    
    public UnityEvent interactAction;

    private void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                interactAction.Invoke();
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange= true;
        }
    }
}
