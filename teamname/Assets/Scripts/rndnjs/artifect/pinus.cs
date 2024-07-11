using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinus : MonoBehaviour
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
            float healAmount = player.health * 0.5f;

            
            player.HP = Mathf.Min(player.HP + healAmount, player.health);
            Destroy(game);
        }
    }
}
