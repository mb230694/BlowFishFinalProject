using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyApproachBoat : MonoBehaviour
{
    [SerializeField] private NavMeshAgent enemySelf;
    public GameObject boat;
    private Vector3 targetPosition;
    
    public float rotationSpeed = 1;
    public float BlastPower = 25;
    public GameObject Cannonball;
    public Transform ShotPoint;

    private float countdownBetweenFire = 0f;
    [SerializeField] private float fireRate = 2f;

    void Start()
    {
        enemySelf = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (enemySelf.remainingDistance < 1.0f) // If the enemy is close to the target
        {
            // Randomize the target position around the boat
            targetPosition = boat.transform.position + Random.insideUnitSphere * 0.1f;
            enemySelf.SetDestination(targetPosition);
        }

        if(enemySelf.remainingDistance < 40.0f)
        {
           if(countdownBetweenFire >= 3f)
            {
                GameObject createdCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
                createdCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * BlastPower;


                countdownBetweenFire = 1f / fireRate;
            }
          
        }
        countdownBetweenFire += Time.deltaTime;
    }
}
