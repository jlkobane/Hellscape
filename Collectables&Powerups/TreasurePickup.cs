using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreasurePickup : MonoBehaviour
{
  public AudioSource treasurePickUp; 
  public GameObject pickUpNotif;

  void OnTriggerEnter(Collider other) { 
    treasurePickUp.Play(); 
    GlobalScore.scoreAmount += 500; 
    GlobalEndOfLevel.treasureCount += 1;
    this.gameObject.SetActive(false); 
    pickUpNotif.SetActive(false);
    pickUpNotif.GetComponent<TMPro.TextMeshProUGUI>().text = "Dutchman Treasure Found!"; 
    pickUpNotif.SetActive(true);
  } 

}
