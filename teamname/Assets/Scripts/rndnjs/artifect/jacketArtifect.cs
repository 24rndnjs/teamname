using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jacketArtifect : MonoBehaviour
{

    public Database player;
    public GameObject game;
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        {
            player.moveSpeed *= 1.1f;
            Destroy(game);
        }
    }
}
