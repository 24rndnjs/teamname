using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savefile : MonoBehaviour
{

    public EnenmyDatabase enemy;
    public GameObject game;
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            enemy.hp /= 1.05f;
            Destroy(game);
        }
    }
}
