using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public GameObject healthDisplay; 
    public static int healthAmount; 
    public int playerHealth; 

    void Start() { 
        healthAmount = 100;
    }

    void Update()
    { 
        if (healthAmount <= 0) { 
            SceneManager.LoadScene(1);
        }
        playerHealth = healthAmount; 
        healthDisplay.GetComponent<Text>().text = "HP: " + healthAmount + "%";
    }
}
