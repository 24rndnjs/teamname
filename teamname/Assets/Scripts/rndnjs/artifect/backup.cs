using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backup : MonoBehaviour
{
    public Database player;
    public GameObject game;
    public float currenthp;
    void Start()
    {
         currenthp = player.HP;
        player.HP = player.health;
    }

    void Update()
    {

    }
    void Resurrection()
    {
        if(player.HP<=0)
        {
            Debug.Log("ºÎÈ°");
            player.health = currenthp * 0.5f;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Destroy(game);
        }
    }
}
