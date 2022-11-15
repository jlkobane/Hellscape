using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
   public int enemyHp = 100; 
   public bool enemyDeath = false; 
//    public GameObject enemyAi; 
   public GameObject enemy;

    void DamageEnemy (int playerDamage) { 
            enemyHp -= playerDamage;
    }

    void Update()
    {
        if (enemyHp <= 0 && enemyDeath == false) { 
            gameObject.GetComponent<DemonFollow>().enabled = false; 
            enemy.GetComponent<Animation>().Play("demon_death");
            enemyDeath = true;
            // enemyAi.SetActive(false); 
            // enemy.GetComponent<LookAtPlayer>().enabled = false; 
            GlobalScore.scoreAmount += 150; 
            GlobalEndOfLevel.enemyKillCount += 1;
            StartCoroutine(deadDemon());
        }
    }

    IEnumerator deadDemon() { 
        yield return new WaitForSeconds(5); 
        Destroy(gameObject);
    }

}
