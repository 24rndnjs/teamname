using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningNeon : MonoBehaviour
{
    private Rigidbody2D rigid;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject boss;
    [SerializeField]
    private float moveSpeed = 8;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        boss = GameObject.Find("øÏ¡ÿΩ‹(GOAT)");
    }
    void Start()
    {
        StartCoroutine(Throw());
        StartCoroutine(Spin());
    }
    IEnumerator Throw()
    {
        Vector2 playerVel = player.transform.position - rigid.transform.position;
        rigid.velocity = playerVel.normalized * moveSpeed;

        yield return new WaitForSeconds(1.0f);

        Vector2 bossVel = boss.transform.position - rigid.transform.position;
        rigid.velocity = bossVel.normalized * moveSpeed;

        yield return new WaitForSeconds(1.0f);

        Destroy(gameObject);
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
}
