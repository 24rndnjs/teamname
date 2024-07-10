using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuttle : MonoBehaviour
{
    private Rigidbody2D rigid;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float moveSpeed = 8;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }
    void Start()
    {
        StartCoroutine(Pattern());
    }   
    IEnumerator Pattern()
    {
        Vector2 velocity = player.transform.position - rigid.transform.position;
        rigid.velocity = velocity.normalized * moveSpeed;
        rigid.transform.LookAt2D((rigid.transform.position + (Vector3)velocity) * -1);
        yield break;
    }
}
