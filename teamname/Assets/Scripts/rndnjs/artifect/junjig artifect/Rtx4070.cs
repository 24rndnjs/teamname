using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtx4070 : MonoBehaviour
{
    public Database player;
    public EnenmyDatabase enemy;
    public GameObject game;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        {
            player.HP *= 1.04f;
            player.ATK *= 1.04f;
            player.AtkSpeed *= 1.04f;
            player.CritChance *= 1.04f;
            player.CritDamage *= 1.04f;
            player.DEF *= 1.04f;
            player.DmgMultiplier *= 1.04f;

            enemy.hp /= 1.07f;
            
            enemy.speed /= 1.07f;
            enemy.attack /= 1.07f;

            Destroy(game);
        }
    }
}
