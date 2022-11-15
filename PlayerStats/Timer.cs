using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Timer : MonoBehaviour
{
    public int seconds = 0; 
    public int minutes = 0; 
    public bool countingTime = false; 
    public GameObject timeDisplay; 

    void Update()
    {
        if (countingTime == false) { 
            StartCoroutine(AddingSeconds());
        }
    } 

    IEnumerator AddingSeconds() { 
        countingTime = true;
        yield return new WaitForSeconds(1); 
        seconds += 1; 
        if (seconds == 60) { 
            seconds = 0; 
            minutes += 1;
        }

        if (seconds <= 9) { 
            if (minutes <= 9) {

            timeDisplay.GetComponent<Text>().text = "0" + minutes + ":0" + seconds;
            } else { 
            timeDisplay.GetComponent<Text>().text = "" + minutes + ":0" + seconds;

            }
        } else { 
            if (minutes <= 9) { 
                 timeDisplay.GetComponent<Text>().text = "0" + minutes + ":" + seconds;
            } else { 

            timeDisplay.GetComponent<Text>().text = "" + minutes + ":" + seconds;
            }

        }


        timeDisplay.GetComponent<Text>().text = "" + minutes + ":" + seconds;
        countingTime = false;
    }

}
