using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Goat : MonoBehaviour
{
    [SerializeField]
    float health = 100;
    [SerializeField]
    float moveSpeed = 10;
    [SerializeField]
    float attack = 10;

    public GameObject spawnRange;
    public Transform playerPos;
    public Database player;
    public EnenmyDatabase eeee;
    private int patternNum;
    private bool immortal = false;
    private BoxCollider2D range;
    private Rigidbody2D rigid;
    private Animator animator; // Animator 컴포넌트 추가

    void Start()
    {
        patternNum = 0;
        range = spawnRange.GetComponent<BoxCollider2D>();
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // Animator 초기화

        StartCoroutine(Pattern());
    }

    IEnumerator Pattern()
    {
        while (true)
        {
            switch (patternNum)
            {
                case 0:
                    Pattern1();
                    patternNum++;
                    break;
                case 1:
                    Pattern2();
                    patternNum++;
                    break;
                case 2:
                    Pattern3();
                    patternNum++;
                    break;
                case 3:
                    Pattern4();
                    patternNum++;
                    break;
                default:
                    break;
            }
            yield return new WaitForSeconds(2);
            patternNum %= 4;
        }
    }

    void Pattern1()
    {
        StartCoroutine(Slow());
    }

    IEnumerator Slow()
    {
        Debug.Log("Slow");

        player.moveSpeed -= 0.25f;

        for (int i = 0; i < 25; ++i)
        {
            player.moveSpeed += 0.1f;
            yield return new WaitForSeconds(0.25f);
        }

        yield break;
    }

    void Pattern2()
    {
        StartCoroutine(Joint());

        IEnumerator Joint()
        {
            Vector2 velocity = playerPos.transform.position - rigid.transform.position;
            rigid.velocity = velocity.normalized * moveSpeed;

            yield return new WaitForSeconds(0.025f);

            rigid.velocity = new Vector2(0, 0);

            yield break;
        }
    }

    void Pattern3()
    {
        StartCoroutine(Dash());

        IEnumerator Dash()
        {
            for (int i = 0; i < 3; ++i)
            {
                Vector2 velocity = playerPos.transform.position - rigid.transform.position;
                rigid.velocity = velocity.normalized * moveSpeed;

                yield return new WaitForSeconds(0.5f);
            }
            rigid.velocity = new Vector2(0, 0);
            yield break;
        }
    }

    void Pattern4()
    {
        StartCoroutine(IMMORTAL());

        IEnumerator IMMORTAL()
        {
            immortal = true;
            yield return new WaitForSeconds(10f);
            immortal = false;
            yield break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (patternNum == 1)
        {
            if (collision.CompareTag("Player"))
            {
                StartCoroutine(Slow());
            }
        }
        if(collision.CompareTag("kal"))
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        if (!immortal)
        {
            eeee.hp -= player.ATK;
            if (eeee.hp <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        animator.SetBool("isdie", true); // isdie 파라미터를 true로 설정
        // 추가로 죽을 때 필요한 로직을 이곳에 추가
    }
}
