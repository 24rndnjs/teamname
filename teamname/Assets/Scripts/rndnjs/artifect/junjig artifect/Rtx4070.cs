using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtx4070 : MonoBehaviour
{
    public Database player;
    public EnenmyDatabase enemy;
    public GameObject game;
    public junjigdatabase junjig;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            junjig.game += 1;
            player.HP *= 1.04f;
            player.ATK *= 1.04f;
            player.AtkSpeed *= 1.04f;
            player.CritChance *= 1.04f;
            player.CritDamage *= 1.04f;
            player.DEF *= 1.04f;
            player.DmgMultiplier *= 1.04f;

            enemy.hp *= 0.93f;
            
            enemy.speed *= 0.93f;
            enemy.attack *= 0.93f;

            Destroy(game);
        }
    }
}
