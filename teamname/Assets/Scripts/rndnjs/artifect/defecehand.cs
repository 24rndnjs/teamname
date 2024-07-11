using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defecehand : MonoBehaviour
{
    public Database player;
    public GameObject game;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            player.AtkSpeed *= 1.17f;
            Destroy(game);
        }
    }
}
