using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MHandCuff : MonoBehaviour
{
    public Database player;
    public GameObject game;
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        {
            player.MoveSpeed /= 1.25f;
            player.ATK *= 1.5f;
        }
    }
}
