using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadMainMenu());
    }
    IEnumerator LoadMainMenu(){ 
        yield return new WaitForSeconds(5); 
        SceneManager.LoadScene(3);
    }
}
