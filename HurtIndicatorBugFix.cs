using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtIndicatorBugFix : MonoBehaviour
{
   public bool turnIndicatorOff = false; 

    void Update()
    {
        if (turnIndicatorOff == false) { 
            turnIndicatorOff = true; 
            StartCoroutine(IndicatorOff());
        }
    } 

    IEnumerator IndicatorOff() { 
        yield return new WaitForSeconds(0.2f); 
        turnIndicatorOff = false;
        this.gameObject.SetActive(false);

    }
}
