using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson; 

public class EndGameObject : MonoBehaviour
{
   public GameObject fadeOut; 
    public GameObject endOfGamePanel; 
    public GameObject player; 

    void OnTriggerEnter (Collider other) {  
        StartCoroutine(GameComplete());
        player.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    } 

    IEnumerator GameComplete() { 
        fadeOut.SetActive(true); 
         yield return new WaitForSeconds(3);  
         endOfGamePanel.SetActive(true); 
         yield return new WaitForSeconds(15); 
         Application.Quit();
    }


}
