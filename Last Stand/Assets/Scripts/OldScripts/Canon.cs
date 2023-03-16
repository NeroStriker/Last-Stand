using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject canonBall;
    public Transform ShootPoint;
    [SerializeField] private Vector3 movement;    
    public float speed;

    private void Start()
    {
        
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(canonBall, ShootPoint);
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            Instantiate(canonBall, ShootPoint);
            Shoot();
        }
        CharacterMovement();
    }

    private void Shoot()
    {
        
        Debug.Log("Shoot");
    }

    private void CharacterMovement()
    {
        float movVertical = Input.GetAxis("Vertical");
        float movHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movHorizontal, 0, movVertical) * speed * Time.deltaTime;        


    }


}
