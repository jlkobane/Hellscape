using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1911Fire : MonoBehaviour
{
    public GameObject m1911;
    public bool firing = false;
    public GameObject muzzleFlash; 
    public AudioSource m1911Shot;
    public float target; 
    public AudioSource noAmmo; 
    public float distanceFromEnemy; 
    public int playerDamage = 10; 


    void Update()
    {
        if (Input.GetButtonDown("Fire1")) { 
            if (AmmoCounter.m1911Count < 1) { 
                noAmmo.Play();
            } 
            else { 
            if (firing == false) {
                StartCoroutine(FireThe1911()); 
            }

            }
        }
    }

    IEnumerator FireThe1911() { 
        RaycastHit bullet;
        firing = true; 
        AmmoCounter.m1911Count -= 1;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out bullet)) { 
            distanceFromEnemy = bullet.distance;
            bullet.transform.SendMessage("DamageEnemy", playerDamage, SendMessageOptions.DontRequireReceiver);
        }
        target = PlayerCasting.distanceAway;
        m1911.GetComponent<Animator>().Play("Fire");
        m1911Shot.Play();
        muzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.07f); 
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.13f); 
         m1911.GetComponent<Animator>().Play("Idle");
        firing = false;
    }
}