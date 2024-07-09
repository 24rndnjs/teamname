using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public EnenmyDatabase enemydata;
    public float currenthp;
    public float space;
    public GameObject closestPlayer;
    private bool isFlipped = false;

    void Start()
    {
        currenthp = enemydata.hp;
    }

    void Update()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("player");
        FindClosestPlayer(players);
        if (closestPlayer != null)
        {
            Vector3 direction = closestPlayer.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            if (!isFlipped)
            {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                isFlipped = true;
            }

            transform.position = Vector2.MoveTowards(this.transform.position, closestPlayer.transform.position, enemydata.speed * Time.deltaTime);

            float distance = Vector2.Distance(transform.position, closestPlayer.transform.position);
            if (distance <= space)
            {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                isFlipped = false;
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
}
