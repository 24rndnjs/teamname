using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPT : MonoBehaviour
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
        if (collision.CompareTag("Player"))
        {
            player.ATK *= (player.HP / player.DEF);
            Destroy(game);
        }


    }
}
