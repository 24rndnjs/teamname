using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_GoatPAGE2 : MonoBehaviour
{
    [SerializeField]
    float health = 100;
    [SerializeField]
    float moveSpeed = 10;
    [SerializeField]
    float attack = 10;

    public GameObject neonStick;
    public GameObject spawnRange;
    public Transform playerPos;
    //public Database player;

    private int patternNum;
    private bool immortal = false;
    private BoxCollider2D range;
    private Rigidbody2D rigid;


    void Start()
    {
        patternNum = 0;
        //player.MoveSpeed = moveSpeed;
        range = spawnRange.GetComponent<BoxCollider2D>();
        rigid = GetComponent<Rigidbody2D>();

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
                default:
                    break;
            }
            yield return new WaitForSeconds(2);
            patternNum %= 3;
        }
    }

    void TakeDamage()
    {
        StartCoroutine(DOTDMG());

        IEnumerator DOTDMG()
        {
            for (float i = 0; i < 10; i += 0.1f)
            {
                health -= 0.2f;
                yield return new WaitForSeconds(0.1f);
            }
            yield break;
        }
    }
    void Pattern1()
    {
        StartCoroutine(Swing());

        IEnumerator Swing()
        {
            Vector2 velocity = playerPos.transform.position - rigid.transform.position;
            rigid.velocity = velocity.normalized * moveSpeed;

            yield return new WaitForSeconds(0.025f);

            rigid.velocity = new Vector2(0, 0);

            yield break;
        }
    }
    void Pattern2()
    {

    }
    void Pattern3()
    {

    }
}
