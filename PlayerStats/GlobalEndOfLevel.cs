using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalEndOfLevel : MonoBehaviour
{
   public static int enemyKillCount; 
   public static int treasureCount;
   public GameObject enemyKillCountDisplay; 
   public GameObject treasureCountDisplay;
   public static int nextLevel = 4;
    // Update is called once per frame
    void Update()
    {
        enemyKillCountDisplay.GetComponent<Text>().text = "" + enemyKillCount;
        treasureCountDisplay.GetComponent<Text>().text = "" + treasureCount;
    }
}