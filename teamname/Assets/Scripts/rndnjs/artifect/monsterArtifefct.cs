using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterArtifefct : MonoBehaviour
{
    public Database player;
    public float currenthp;
    public GameObject game;
    void Start()
    {
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            player.HP *= 1.1f;
            Destroy(game);
        }
    }
}
