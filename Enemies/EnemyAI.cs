using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent; 

    public Transform player; 

    public LayerMask theGround, thePlayer; 

    public float hp;

    //Patroling  
    public Vector3 walkLocation; 
    bool walkLocationSet; 
    public float walkLocationRange; 

    //Attacking 
    public float timeInBetweenAttacks; 
    bool attacked;  
    public GameObject bullet;

    //States 
    public float sightRange, attackRange; 
    public bool playerWithinSightRange, playerWithinAttackRange; 

    private void Awake() { 
        player = GameObject.Find("FPSController").transform; 
        agent = GetComponent<NavMeshAgent>();
    }  

    private void Update() { 
        //Check for sight and attack range 
        playerWithinSightRange = Physics.CheckSphere(transform.position, sightRange, thePlayer);

        playerWithinAttackRange = Physics.CheckSphere(transform.position, attackRange, thePlayer); 

        if (!playerWithinSightRange && !playerWithinAttackRange) Patroling(); 

        if (playerWithinSightRange && !playerWithinAttackRange) Chase();  

        if (playerWithinAttackRange && playerWithinSightRange) Attack();
    }

    private void Patroling() { 
           if (!walkLocationSet)  SearchWalkLocation(); 

           if (walkLocationSet) 
                agent.SetDestination(walkLocation); 

            Vector3 distanceToWalkLocation = transform.position - walkLocation; 

            //WalkPoint reached 
            if (distanceToWalkLocation.magnitude < 1f) 
                walkLocationSet = false;
    } 

    private void SearchWalkLocation() { 
        //Calculate random point in range 
        float randomZ = Random.Range(-walkLocationRange, walkLocationRange);

        float randomX = Random.Range(-walkLocationRange, walkLocationRange); 

        walkLocation = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ); 

        if (Physics.Raycast(walkLocation, -transform.up, 2f, theGround))
        walkLocationSet = true;
    }

    private void Chase() { 
        agent.SetDestination(player.position);
    }

    private void Attack() { 
        //Make sure enemy doesn't move 
        agent.SetDestination(transform.position); 

        transform.LookAt(player);

        if (!attacked) {  

            ///Attack code here 
            Rigidbody rb = Instantiate(bullet, transform.position, Quaternion.identity).GetComponent<Rigidbody>(); 

            rb.AddForce(transform.forward *32f, ForceMode.Impulse); 
            rb.AddForce(transform.up * 8f, ForceMode.Impulse); 

            attacked = true; 
            Invoke(nameof(ResetAttack), timeInBetweenAttacks);
        }
    } 

    private void ResetAttack() { 
        attacked = false;
    } 

    public void TakeDamage(int damage) { 
        hp -= damage; 

        if (hp <= 0) Invoke(nameof(KillEnemy), 0.5f);
    } 

    private void KillEnemy() { 
        Destroy(gameObject);
    } 

    private void OnDrawGizmosSelected() { 
        Gizmos.color = Color.red; 
        Gizmos.DrawWireSphere(transform.position, attackRange); 
        Gizmos.color = Color.yellow; 
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }

}
