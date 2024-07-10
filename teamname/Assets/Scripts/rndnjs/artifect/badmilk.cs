using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badmilk : MonoBehaviour
{
    SpriteRenderer player;
    public GameObject game;
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }
    void mystert()
    {
        player.flipX = true;
        player.flipY=true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Destroy(game);
            Invoke("mystert", 2f);
        }
    }
}
