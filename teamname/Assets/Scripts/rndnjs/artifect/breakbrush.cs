using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakbrush : MonoBehaviour
{
    public Database player;
    public GameObject game;
    void Start()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            player.CritChance *= 1.15f;
            Destroy(game);
        }
    }
}
