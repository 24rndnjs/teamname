using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public EnenmyDatabase enemydata;
    public float currenthp;
    public float space;
    public GameObject closetplayer;

    void Start()
    {
        currenthp = enemydata.hp;
    }


    void Update()
    {
        GameObject [] players = GameObject.FindGameObjectsWithTag("player");
        FindClosestPlayer(players);
        if (closetplayer != null)
        {

            Vector3 direction = closetplayer.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            transform.position = Vector2.MoveTowards(this.transform.position, closetplayer.transform.position, enemydata.speed * Time.deltaTime);
            float distance = Vector2.Distance(transform.position, closetplayer.transform.position);

        }
    }
    void FindClosestPlayer(GameObject[] players)
    {
        float minDistance = Mathf.Infinity;
        closetplayer = null;

        foreach (GameObject player in players)
        {
            float distance = Vector2.Distance(transform.position, player.transform.position);
            if (distance <= space && distance < minDistance)
            {
                minDistance = distance;
                closetplayer = player;
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(space, space, space));

    }
}
