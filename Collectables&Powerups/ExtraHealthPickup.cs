using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraHealthPickup : MonoBehaviour
{
  public AudioSource medkitPickUpSound; 

  void OnTriggerEnter(Collider other) { 
    GlobalHealth.healthAmount += 5;
    medkitPickUpSound.Play(); 
    GetComponent<BoxCollider>().enabled = false;
    this.gameObject.SetActive(false);
  } 

}
