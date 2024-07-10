using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public EnenmyDatabase enemydata;
    public float currenthp;
    public float space;
    public GameObject closestPlayer;
    private SpriteRenderer spriteRenderer;
    public Database player;

    void Start()
    {
        currenthp = enemydata.hp;
        spriteRenderer = GetComponent<SpriteRenderer>();
        player.HP = player.health;
    }

    void Update()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("player");
        FindClosestPlayer(players);
        if (closestPlayer != null)
        {
            Vector3 direction = closestPlayer.transform.position - transform.position;

            
            if (direction.x > 0)
            {
                spriteRenderer.flipX = true;
            }
            else if (direction.x < 0)
            {
                spriteRenderer.flipX = false;
            }

            transform.position = Vector2.MoveTowards(this.transform.position, closestPlayer.transform.position, enemydata.speed * Time.deltaTime);

            float distance = Vector2.Distance(transform.position, closestPlayer.transform.position);
            if(enemydata.hp<=0)
            {
                Die();
            }
        }
    }

    void FindClosestPlayer(GameObject[] players)
    {
        float minDistance = Mathf.Infinity;
        closestPlayer = null;

        foreach (GameObject player in players)
        {
            float distance = Vector2.Distance(transform.position, player.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closestPlayer = player;
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(space, space, space));
    }

    public void Takedamage(int damage)
    {
        int actualdamage = Mathf.Max(damage - enemydata.defense, 0);
        currenthp -= actualdamage;
        if (currenthp <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
     public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("player"))
            {
            player.health -= (enemydata.attack-player.DEF);
            }
        }

    
}
