using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newshoes : MonoBehaviour
{
    public Database player;
    public GameObject gameobject;
    private bool isMoving = false;
    private bool isAttacking = false;

    void Update()
    {
        // �̵� ����
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        
       
        
        if (isMoving==true )
        {
            IncreaseCritChance();
        }
    }

    void IncreaseCritChance()
    {
        player.CritChance *= 1.3f; // ġ��Ÿ Ȯ�� 30% ����
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Destroy(gameobject);
        }
    }
}
