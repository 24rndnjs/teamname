using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonster500 : MonoBehaviour
{
    public Database player;
    public GameObject game;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            player.CritChance *= 1.4f;
        }
    }
}
