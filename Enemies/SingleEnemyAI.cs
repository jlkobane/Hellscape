// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SingleEnemyAI : MonoBehaviour
// {
//     public string hitTag;
//     // public bool lookingToPlayer = false;
//     public GameObject roboSoldier; 
//     // public AudioSource enemyFireSound; 
//     public bool attacking = false;
//     public float enemyFireRate = 0.499f; 
//     public int ranHurtSound; 
//     public AudioSource[] hurtNoise; 
//     public GameObject hurtIndicator; 
//     void Update()
//     {
//         // RaycastHit hit; 
//         // if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit)) { 
//         //    hitTag = hit.transform.tag; 
//         //    lookingToPlayer = true;
//         // } 
//         if (hitTag == "Player" && attacking == false) { 
//             StartCoroutine(EnemyFire());
//         } 
//         // if (hitTag != "Player") { 
//         //     roboSoldier.GetComponent<Animator>().Play("Idle_Guard_AR"); 
//         //     lookingToPlayer = false;
//         // } 

//         IEnumerator EnemyFire() { 
//             attacking = true; 
//             // roboSoldier.GetComponent<Animator>().Play("Shoot_SingleShot_AR", -1, 0); 
//             // roboSoldier.GetComponent<Animator>().Play("Shoot_SingleShot_AR"); 
//             // enemyFireSound.Play();
//             // lookingToPlayer = true; 
//             GlobalHealth.healthAmount -= 6;
//             hurtIndicator.SetActive(true);
//             yield return new WaitForSeconds(0.2f);
//             hurtIndicator.SetActive(false);
//             ranHurtSound = Random.Range(0, 3);
//                 hurtNoise[ranHurtSound].Play();
//             yield return new WaitForSeconds(enemyFireRate); 
//             attacking = false;
//         }
//     }
// }
 











        //    Physics.IgnoreCollision(enemy.GetComponent<Collider>(), GetComponent<Collider>());
