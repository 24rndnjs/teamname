using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stabilizer : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player=GetComponent<GameObject>();
        Invoke("character", 3);
    }

   void character()
    {
        player.transform.localScale *= 0.75f;
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            character();
            Destroy(player);
        }

    }
}
