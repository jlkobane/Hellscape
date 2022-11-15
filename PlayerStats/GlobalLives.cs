using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GlobalLives : MonoBehaviour
{
    public GameObject lifeDisplay; 
    public static int lifeAmount = 3; 
    public int playerlives; 

    

    void Update()
    {
        playerlives = lifeAmount; 
        lifeDisplay.GetComponent<Text>().text = "Resurrections: " + lifeAmount; 
    }
}
