using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonster500 : MonoBehaviour
{
    public Database player;
    public GameObject game;
    public junjigdatabase junjig;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            junjig.ani += 1;
            junjig.comic += 1;
            junjig.film += 1;
            junjig.game += 1;
            player.CritChance *= 1.4f;
            Destroy(game);
        }
    }
}
