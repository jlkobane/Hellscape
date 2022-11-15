using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonFollow : MonoBehaviour
{
    public GameObject ignoreAmmo;
   public GameObject player; 
   public float targetDistance; 
   public float alertRange = 40; 
   public GameObject enemy; 
   public float enemySpeed;
   public int attackTrigger; 
   public RaycastHit theShot; 

   public int attacking;
   public GameObject hurtIndicator;
   public int ranHurtSound;
   public AudioSource[] hurtNoise;


   void Update() { 
        transform.LookAt (player.transform); 
        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out theShot)) { 
            targetDistance = theShot.distance; 
        if (targetDistance < alertRange) { 
            enemySpeed = 0.04f;
        if (attackTrigger == 0) { 
            enemy.GetComponent<Animation>().Play("demon_walking"); 
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemySpeed); 
        }
        } else { 
            enemySpeed = 0;
            enemy.GetComponent<Animation>().Play("demon_idle"); 
        } 
        Physics.IgnoreLayerCollision(8, 9);

    }

        if (attackTrigger == 1) {
            if (attacking == 0) { 
                StartCoroutine(EnemyDamage());
            }
            enemySpeed = 0;
            enemy.GetComponent<Animation>().Play("demon_hornattack");
         }

   } 

    void OnTriggerEnter() { 
        attackTrigger = 1; 

    } 

    void OnTriggerExit() { 
        attackTrigger = 0;
    }

    IEnumerator EnemyDamage() { 
     attacking = 1; 
    GlobalHealth.healthAmount -= 20; 
    hurtIndicator.SetActive(true);
    yield return new WaitForSeconds(0.2f);
    hurtIndicator.SetActive(false);
    ranHurtSound = Random.Range(0, 3);
    hurtNoise[ranHurtSound].Play();
    yield return new WaitForSeconds(0.4f); 
    attacking = 0;
    }


}
