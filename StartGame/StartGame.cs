using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
 public GameObject startMusic; 
 public GameObject noMoreWalls; 
 public GameObject activateDemon1; 
 public GameObject activateDemon2; 
 public GameObject activateDemon3; 
 public GameObject activateDemon4; 

  void OnTriggerEnter(Collider other) { 
  
  startMusic.SetActive(true); 
  noMoreWalls.SetActive(false); 
  activateDemon1.SetActive(true);
  activateDemon2.SetActive(true);
  activateDemon3.SetActive(true);
  activateDemon4.SetActive(true);
    }
}
