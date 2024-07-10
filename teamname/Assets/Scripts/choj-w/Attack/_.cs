using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ : MonoBehaviour
{
    public int enemyHealth;
    public int damageAmount;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            AttackEnemy();
        }
    }

    void AttackEnemy()
    {
        Debug.Log("АјАн!");

        enemyHealth -= damageAmount;
    }


}
