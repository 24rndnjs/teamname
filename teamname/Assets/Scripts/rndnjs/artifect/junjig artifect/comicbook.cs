using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comicbook : MonoBehaviour
{
    public Database player;
    public GameObject game;
    public junjigdatabase junjig;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        {
            
        }
    }
}
