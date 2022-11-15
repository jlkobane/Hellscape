using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class M1911Pickup : MonoBehaviour
{
    public GameObject real1911; 
    public GameObject fake1911; 
    public GameObject m1911GunShot; 
    public GameObject noAmmoAudio;
    public AudioSource m1911PickupSound; 
    public AudioSource demonicLaugh;
    public GameObject pickUpNotif; 
    public GameObject m1911Picture;

    void OnTriggerEnter(Collider other) {
        real1911.SetActive(true);
        fake1911.SetActive(false);
        m1911PickupSound.Play(); 
        m1911GunShot.SetActive(true); 
        noAmmoAudio.SetActive(true);
        GetComponent<BoxCollider>().enabled = false; 
        pickUpNotif.SetActive(false);
        pickUpNotif.GetComponent<TMPro.TextMeshProUGUI>().text = "1911 Added"; 
        pickUpNotif.SetActive(true);
        m1911Picture.SetActive(true);
        demonicLaugh.Play();
    }
}
