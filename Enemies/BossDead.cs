using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson; 

public class BossDead : MonoBehaviour
{
   public int enemyHp = 500; 
   public bool enemyDeath = false; 
//    public GameObject enemyAi; 
   public GameObject enemy;
   public GameObject fadeOut;   
   public GameObject player;
   public GameObject gunshotSound; 
   public GameObject endOfGamePanel;


    void DamageEnemy (int playerDamage) { 
            enemyHp -= playerDamage;
    } 
    

    void Update()
    {
        if (enemyHp <= 0 && enemyDeath == false) { 
            gameObject.GetComponent<DemonBossFollow>().enabled = false; 
            enemy.GetComponent<Animation>().Play("demon_death");
            enemyDeath = true;
            // enemyAi.SetActive(false); 
            // enemy.GetComponent<LookAtPlayer>().enabled = false; 
            GlobalScore.scoreAmount += 30000; 
            GlobalEndOfLevel.enemyKillCount += 1;
           
            StartCoroutine(EndGame());
        }
    } 
    

   

    IEnumerator EndGame() { 
        player.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        gunshotSound.SetActive(false);
         fadeOut.SetActive(true); 
         yield return new WaitForSeconds(3);  
         endOfGamePanel.SetActive(true); 
         yield return new WaitForSeconds(15); 
        //  AmmoCounter.m1911Count = 0; 
        //  GlobalHealth.healthAmount = 100; 
        //  GlobalLives.lifeAmount = 3; 
        //  GlobalScore.scoreAmount = 0;
        //  SceneManager.LoadScene(2); 
        Application.Quit();
    } 

     

}
