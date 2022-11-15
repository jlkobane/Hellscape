using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class LevelRecycle : MonoBehaviour
{
    public GameObject youLost; 

    void Start()
    { 
        
        GlobalLives.lifeAmount -= 1;  
        if (GlobalLives.lifeAmount == 0) 
        { 
            youLost.SetActive(true);
            StartCoroutine(Defeat());
        } else { 
            if (GlobalEndOfLevel.nextLevel == 4) { 
                SceneManager.LoadScene(2);
                GlobalScore.scoreAmount = 0; 
                AmmoCounter.m1911Count = 0;
            } else { 
                SceneManager.LoadScene(GlobalEndOfLevel.nextLevel);
                
            }
        }
      
    }
    IEnumerator Defeat() { 
         yield return new WaitForSeconds(5);  
         GlobalLives.lifeAmount = 3;
         SceneManager.LoadScene(2);
    }
    
}
