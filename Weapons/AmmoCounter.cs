using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{

    public GameObject ammoText;
    public static int m1911Count;
   
    void Update()
    {
        ammoText.GetComponent<Text>().text = "ROUNDS: " + m1911Count;
    }
}
