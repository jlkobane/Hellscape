using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealthPickup : MonoBehaviour
{
  public AudioSource medkitPickUpSound; 

  void OnTriggerEnter(Collider other) { 
    GlobalHealth.healthAmount = 100;
    medkitPickUpSound.Play(); 
    GetComponent<BoxCollider>().enabled = false;
    this.gameObject.SetActive(false);
  } 

}
