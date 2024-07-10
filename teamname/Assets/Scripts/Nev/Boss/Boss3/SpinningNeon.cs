using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningNeon : MonoBehaviour
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
        StartCoroutine(Throw());
        StartCoroutine(Spin());
    }
    IEnumerator Spin()
    {
        float rotate = 0;
        while(true)
        {
            rotate %= 360;
            transform.rotation = Quaternion.Euler(0, 0, rotate);
            yield return new WaitForSeconds(0.01f);
            rotate += 10;
        }
    }
    IEnumerator Throw()
    {
        Vector2 velocity = player.transform.position - rigid.transform.position;
        rigid.velocity = velocity.normalized * moveSpeed;

        yield return new WaitForSeconds(1.0f);

        rigid.velocity = velocity.normalized * moveSpeed * -1;
        yield break;
    }
}
