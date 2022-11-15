using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallHealthPickup : MonoBehaviour
{
  public AudioSource medkitPickUpSound; 

  void OnTriggerEnter(Collider other) { 
    if (GlobalHealth.healthAmount >= 93){

    GlobalHealth.healthAmount = 100;
    } else { 
    GlobalHealth.healthAmount += 8;

    }
    medkitPickUpSound.Play(); 
    GetComponent<BoxCollider>().enabled = false;
    this.gameObject.SetActive(false);
  } 

}
