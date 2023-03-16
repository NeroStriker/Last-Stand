using UnityEngine;

public class Chaser : MonoBehaviour
{
    [SerializeField] private Transform character;
    [SerializeField] private float speedToLook;
    [SerializeField] private float speed;
    [SerializeField] private float charDistance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LookAtCharacter();
        ChaseCharacter();
    }

    private void LookAtCharacter()
    {
        Quaternion newRotation = Quaternion.LookRotation((character.position - transform.position));
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);

    }
    private void ChaseCharacter()
    {
        Vector3 direction = character.position - transform.position;
        var distance = direction.magnitude;
        if (distance > charDistance)
        {
            transform.position += direction.normalized * (speed * Time.deltaTime);
        }
        
    }
}
