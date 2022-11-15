using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreditsToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ToMainMenu());
    }
    IEnumerator ToMainMenu() { 
        yield return new WaitForSeconds(7); 
        SceneManager.LoadScene(3);
    }
   
}
