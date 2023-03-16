using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] waypoints;
    private int currentWaypoint;
    public int speed;
    public Transform player;
    public float playerDistance;
    public LayerMask whatIsPlayer;
    public GameObject projectile;
    public Transform shootPoint;

    private void Awake()
    {
        currentWaypoint= 0;
        player = GameObject.Find("Player").transform;
        
    }
    private void Update()
    {
        
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patrol();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInSightRange && playerInAttackRange) AttackPlayer();
    }
    void Move(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
        transform.LookAt(waypoints[currentWaypoint]);
    }

    void Patrol()
    {
        var l_currentWaypoint = waypoints[currentWaypoint];
        var distance = (l_currentWaypoint.position - transform.position);
        var direction = distance.normalized;
        var distance2 = distance.magnitude;
        Move(direction);

        if (distance2 <= 0.5f) 
        {
            NextWaypoint();
        }
    }

    void NextWaypoint()
    {
        currentWaypoint++;
        if (currentWaypoint > waypoints.Length-1)
        {
            currentWaypoint= 0;
        }
    }

    //attack
    public float timeBetweeenAttacks;
    bool alreadyAttacked;

    //states

    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private void ChasePlayer()
    {
        var l_playerPos = player;
        var distance = (l_playerPos.position - transform.position);
        var direction = distance.normalized;
        var distance2 = distance.magnitude;

        transform.position += direction * speed * Time.deltaTime;
        transform.LookAt(player);

    }
    private void AttackPlayer()
    {
        transform.position = transform.position;
        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            Rigidbody rb = Instantiate(projectile, shootPoint.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            



            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweeenAttacks);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }

}
