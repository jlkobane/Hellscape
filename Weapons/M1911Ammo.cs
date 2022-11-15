using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class M1911Ammo : MonoBehaviour
{
  public AudioSource ammoPickUp; 
  public GameObject pickUpNotif;

  void OnTriggerEnter(Collider other) { 
    ammoPickUp.Play(); 
    AmmoCounter.m1911Count += 20;
    this.gameObject.SetActive(false); 
    pickUpNotif.SetActive(false);
    pickUpNotif.GetComponent<TMPro.TextMeshProUGUI>().text = "1911 Ammo Added"; 
    pickUpNotif.SetActive(true);
  } 

}
