using UnityEngine;

public enum CurrenState
{
    Chase,
    Observe
}

public class Hunter : MonoBehaviour
{
    [SerializeField] private Transform character;
    [SerializeField] private float speedToLook;
    [SerializeField] private float speed;
    [SerializeField] private float charDistance;
    [SerializeField] private CurrenState currentState;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetCurrentState();
    }

    private void LookAtCharacter()
    {
        Quaternion newRotation = Quaternion.LookRotation((character.position - transform.position));
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);

    }
    private void ChaseCharacter()
    {

        Quaternion newRotation = Quaternion.LookRotation((character.position - transform.position));
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);

        Vector3 direction = character.position - transform.position;
        var distance = direction.magnitude;
        if (distance > charDistance)
        {
            transform.position += direction.normalized * (speed * Time.deltaTime);
        }

    }

    private void SetCurrentState()
    {
        switch(currentState)
        {
            case CurrenState.Chase:
                ChaseCharacter();
                    break;
            case CurrenState.Observe:
                LookAtCharacter(); 
                    break;
            default:
                break;
        }
    }
}
