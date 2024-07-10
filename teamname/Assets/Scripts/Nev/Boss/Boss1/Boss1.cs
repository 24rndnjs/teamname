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

    public GameObject stone;
    public GameObject student;
    public GameObject rock;
    public GameObject run;
    public GameObject spawnRange;

    private Database player;
    private BoxCollider2D range;
    private int patternNum;

    void Start()
    {
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
                    Pattern1();
                    patternNum++;
                    break;
                case 1:
                    Pattern2();
                    patternNum++;
                    break;
                default:
                    break;
            }
            patternNum++;
            yield return new WaitForSeconds(2);
        }
    }

    void Pattern1()
    {
        StartCoroutine(SPEED());
    }
    IEnumerator SPEED()
    {
        Debug.Log("SPEEEEEEED");

        player.moveSpeed += 10f;

        yield return new WaitForSeconds(3f);

        for (int i = 0; i < 25; ++i)
        {
            player.moveSpeed -= 0.4f;
            yield return new WaitForSeconds(0.25f);
        }

        yield break;
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
