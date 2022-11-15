using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreDisplay; 
    public static int scoreAmount = 0; 
    public int playerscore; 
    public GameObject endOfLevelScore;

    

    void Update()
    {
        playerscore = scoreAmount; 
        scoreDisplay.GetComponent<Text>().text = "Score: " + scoreAmount; 
        endOfLevelScore.GetComponent<Text>().text = "" + scoreAmount;
    }
}
