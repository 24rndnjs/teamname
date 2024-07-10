using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    [SerializeField]
    private float health = 100;
    [SerializeField]
    private float moveSpeed = 10;
    [SerializeField]
    private float attack = 10;

    [SerializeField]
    private GameObject stone;
    [SerializeField]
    private GameObject student;
    [SerializeField]
    private GameObject rock;
    [SerializeField]
    private GameObject run;
    [SerializeField]
    private GameObject spawnRange;

    private Database player;
    private BoxCollider2D range;
    private int patternNum;

    void Start()
    {
        player.MoveSpeed = moveSpeed;
        patternNum = 0;
        range = spawnRange.GetComponent<BoxCollider2D>();
        StartCoroutine(Pattern());
        InvokeRepeating("Passive", 0f, 7f); 
    }

    void Update()
    {
        patternNum %= 2;
    }

    IEnumerator Pattern()
    {
        while (true)
        {
            switch (patternNum)
            {
                case 0:
                    StartCoroutine(Pattern1());
                    break;
                case 1:
                    Pattern2();
                    break;
                default:
                    break;
            }
            patternNum++;
            yield return new WaitForSeconds(2);
        }
    }

    IEnumerator Pattern1()
    {
        player.MoveSpeed *= 10;
        yield return new WaitForSeconds(5f);
        player.MoveSpeed = moveSpeed; // 원래 속도로 복구
    }

    void Pattern2()
    {
        Instantiate(rock, RandomPos(), Quaternion.identity);
    }

    Vector3 RandomPos()
    {
        Vector3 originPosition = spawnRange.transform.position;
        float ranX = Random.Range(-range.bounds.size.x / 2, range.bounds.size.x / 2);
        float ranY = Random.Range(-range.bounds.size.y / 2, range.bounds.size.y / 2);
        return originPosition + new Vector3(ranX, ranY, 0);
    }

    void Passive()
    {
        Instantiate(run, RandomPos(), Quaternion.identity);
    }
}
