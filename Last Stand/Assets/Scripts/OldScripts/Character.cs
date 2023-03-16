using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    private Animator animator;
    public int currentHealth;
    public int maxHealth;
    public Transform shootingPoint;
    public Transform shootingPointFireball;
    public GameObject firebolt;
    public GameObject fireball;

    private CharacterController characterController;
    [SerializeField] private Transform cameraTransform;

    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();    
    }

    // Update is called once per frame
    void Update()
    {
        FireBolt();
        FireBall();
        CharacterMovementControl();
        CharacterDead();
        HealthControl();
    }

    private void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void CharacterMovementControl()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        Vector3 movDirection = new Vector3(movHorizontal, 0, movVertical);
        movDirection.Normalize();

        float magnitude = Mathf.Clamp01(movDirection.magnitude) * speed;

        movDirection = Quaternion.AngleAxis(cameraTransform.eulerAngles.y, Vector3.up) * movDirection;

        characterController.SimpleMove(movDirection * magnitude);

        if (movDirection != Vector3.zero)
        {
            animator.SetBool("isMoving", true);
            Quaternion toRotation = Quaternion.LookRotation(movDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotateSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

    void CharacterDead()
    {
        if(currentHealth <= 0)
        {
            animator.SetBool("Death", true);
        }
        else
        {
            animator.SetBool("Death", false);
        }
    }

    void HealthControl()
    {
        if (currentHealth > maxHealth) 
        {
            currentHealth = maxHealth;
        }
    }

    void FireBolt()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("FireBolt");
            Instantiate(firebolt, shootingPoint.position, shootingPoint.rotation);

        }
    }

    void FireBall()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            animator.SetTrigger("FireBall");
            Instantiate(fireball, shootingPointFireball.position, shootingPointFireball.rotation);

        }
    }




}
