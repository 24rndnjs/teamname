using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss4 : MonoBehaviour
{
    [SerializeField]
    float health = 100;
    [SerializeField]
    float moveSpeed = 10;
    [SerializeField]
    float attack = 10;

    public GameObject paper;
    public GameObject spawnRange;
    public Transform playerPos;
    public Database player;


    private int patternNum;
    private bool immortal = false;
    private BoxCollider2D range;
    private Rigidbody2D rigid;


    void Start()
    {
        patternNum = 0;
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
    void Pattern1()
    {
        StartCoroutine(IMMORTAL());

        IEnumerator IMMORTAL()
        {
            immortal = true;
            yield return new WaitForSeconds(3f);
            immortal = false;
            yield break;
        }
    }
    void Pattern2()
    {

    }
    void Pattern3()
    {
        StartCoroutine(Summon());

        IEnumerator Summon()
        {

            for(int i = 0; i < 3; ++i)
            {
                Transform myPos = this.transform;
                Instantiate(paper, new Vector3(myPos.position.x + 0.1f, myPos.position.y - 0.1f, 0), Quaternion.identity);
                Instantiate(paper, new Vector3(myPos.position.x + 0.2f, myPos.position.y, 0), Quaternion.identity);
                Instantiate(paper, new Vector3(myPos.position.x - 0.1f, myPos.position.y - 0.1f, 0), Quaternion.identity);
                Instantiate(paper, new Vector3(myPos.position.x - 0.2f, myPos.position.y, 0), Quaternion.identity);
                Instantiate(paper, new Vector3(myPos.position.x, myPos.position.y - 0.2f, 0), Quaternion.identity);

                yield return new WaitForSeconds(0.25f);
            }

            yield break;
        }
    }
}
