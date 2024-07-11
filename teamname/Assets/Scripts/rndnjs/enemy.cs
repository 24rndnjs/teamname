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

    private bool isHitBySword = false; // 검에 맞았는지 여부

    void Start()
    {
        currenthp = enemydata.hp;
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component is missing from the enemy object.");
        }
    }

    void Update()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        FindClosestPlayer(players);

        if (closestPlayer != null)
        {
            Vector3 direction = closestPlayer.transform.position - transform.position;

            // 스프라이트 방향 설정
            if (direction.x > 0)
            {
                spriteRenderer.flipX = true;
            }
            else if (direction.x < 0)
            {
                spriteRenderer.flipX = false;
            }

            // 플레이어를 향해 이동
            transform.position = Vector2.MoveTowards(transform.position, closestPlayer.transform.position, enemydata.speed * Time.deltaTime);

            // 체력 확인
            if (currenthp <= 0)
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

    public void Takedamage()
    {
        if (isHitBySword) return; // 이미 검에 맞았다면 무시

        currenthp -= player.ATK; // 현재 체력 감소
        isHitBySword = true; // 검에 맞았음을 표시

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
        if (collision.CompareTag("Player"))
        {
            Database playerDatabase = collision.GetComponent<Database>();
            if (playerDatabase != null)
            {
                playerDatabase.health -= (enemydata.attack - playerDatabase.DEF);
            }
        }
        if (collision.CompareTag("kal"))
        {
            Destroy(gameObject);
        }
    }
}
