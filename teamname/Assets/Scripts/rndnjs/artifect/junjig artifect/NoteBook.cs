using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBook : MonoBehaviour
{
    public Database player;
    public GameObject gameobject;
    private bool isMoving = false;
    private bool isAttacking = false;
    public junjigdatabase junjig;

    void Update()
    {
        // 이동 감지
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }




        if (isMoving == false)
        {
            Attack();
        }
    }

    void Attack()
    {
        player.ATK *= 1.25f; 
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            junjig.ani += 1;
            junjig.game += 1;
            junjig.comic += 1;
            junjig.film += 1;
            Destroy(gameobject);
        }
    }
}
