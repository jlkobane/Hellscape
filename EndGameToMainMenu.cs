using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameToMainMenu : MonoBehaviour
{ 
    public GameObject fadeOut;  
    public AudioSource clickSound;

    public void MainMenuButton() {
        StartCoroutine(BackToMainMenu());
    }
    IEnumerator BackToMainMenu() {
        fadeOut.SetActive(true); 
        clickSound.Play();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
}
