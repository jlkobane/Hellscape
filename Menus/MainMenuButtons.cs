using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{ 
  public AudioSource clickSound; 
  public GameObject fadeOut; 
  public GameObject areYouSure;
  public GameObject yesButton; 
  public GameObject noButton; 
  public int loadScene; 
  public int loadLives; 
  public int loadScore; 
  public int loadAmmo; 
  public int loadHealth; 


  public void StartNewGame() { 
    StartCoroutine(NewGame());
  } 

    IEnumerator NewGame() {
        clickSound.Play();
        fadeOut.SetActive(true); 
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }

    public void QuitGame() { 
        Application.Quit();
    }

    public void StartReset() { 
        areYouSure.SetActive(true);
       
    } 

    public void YesReset() { 
        StartCoroutine(ResetGame());
    } 
    IEnumerator ResetGame() { 
        clickSound.Play();
        areYouSure.SetActive(false);
        fadeOut.SetActive(true); 
        yield return new WaitForSeconds(2);
        PlayerPrefs.SetInt("SceneLoaded", 0);
        PlayerPrefs.SetInt("SavedLives", 0);
        PlayerPrefs.SetInt("SavedScore", 0); 
        PlayerPrefs.SetInt("SavedAmmo", 0);
        PlayerPrefs.SetInt("SavedHealth", 0); 
        SceneManager.LoadScene(0);

    }
    public void NoReset() { 
        areYouSure.SetActive(false);
    } 

    public void LoadGame() { 
    loadScene = PlayerPrefs.GetInt("SceneLoaded");
    if (loadScene == 0) { 
        // no data so nothing happens
    } else { 

    StartCoroutine(LoadGameRoutine());
    }
  } 

    IEnumerator LoadGameRoutine() {
        
        loadLives = PlayerPrefs.GetInt("SavedLives"); 
        loadScore = PlayerPrefs.GetInt("SavedScore"); 
        loadAmmo = PlayerPrefs.GetInt("SavedAmmo"); 
        loadHealth = PlayerPrefs.GetInt("SavedHealth"); 
        clickSound.Play();
        fadeOut.SetActive(true); 
        yield return new WaitForSeconds(2);
        GlobalEndOfLevel.nextLevel = loadScene;
        GlobalLives.lifeAmount = loadLives; 
        GlobalScore.scoreAmount = loadScore; 
        AmmoCounter.m1911Count = loadAmmo; 
        GlobalHealth.healthAmount = loadHealth;
        SceneManager.LoadScene(loadScene);
    }

    public void Credits() { 
        SceneManager.LoadScene(4);
    }



}
