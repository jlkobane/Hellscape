using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson; 
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject fadeOut; 
    public GameObject endOfLevelPanel; 
    public GameObject player;
    public GameObject levelTimer; 

    void OnTriggerEnter (Collider other) {  
        levelTimer.SetActive(false);
        StartCoroutine(LevelFinished());
        player.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    } 

    IEnumerator LevelFinished() { 
        fadeOut.SetActive(true); 
        GlobalEndOfLevel.nextLevel += 1;
        PlayerPrefs.SetInt("SceneLoaded", GlobalEndOfLevel.nextLevel);
        PlayerPrefs.SetInt("SavedLives", GlobalLives.lifeAmount);
        PlayerPrefs.SetInt("SavedScore", GlobalScore.scoreAmount); 
        PlayerPrefs.SetInt("SavedAmmo", AmmoCounter.m1911Count);
        PlayerPrefs.SetInt("SavedHealth", GlobalHealth.healthAmount);





        yield return new WaitForSeconds(3); 
        endOfLevelPanel.SetActive(true); 
        yield return new WaitForSeconds(7); 
        GlobalScore.scoreAmount = 0;
        GlobalEndOfLevel.enemyKillCount = 0; 
        GlobalEndOfLevel.treasureCount = 0; 
        
        SceneManager.LoadScene(5);
    }
}
