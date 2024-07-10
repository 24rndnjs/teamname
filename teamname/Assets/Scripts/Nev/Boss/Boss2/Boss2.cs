using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2 : MonoBehaviour
{
    [SerializeField]
    float health = 100;
    [SerializeField]
    float moveSpeed = 10;
    [SerializeField]
    float attack = 10;

    [SerializeField]
    private GameObject shuttle;
    [SerializeField]
    private GameObject basketball;
    [SerializeField]
    private GameObject student;

    int patternNum;
    public GameObject spawnRange;
    BoxCollider2D range;

    void Start()
    {
        patternNum = 0;
        range = spawnRange.GetComponent<BoxCollider2D>();
        StartCoroutine(Pattern());
    }
    IEnumerator Pattern()
    {
        while(true)
        {
            switch (patternNum) {
                case 0:
                    Pattern1();
                    patternNum++;
                    break;
                case 1:
                    Pattern2();
                    patternNum++;
                    break;
                case 2:
                    if (moveSpeed < 11)
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
        StartCoroutine(Summon());

        IEnumerator Summon()
        {
            for(int i  = 0; i < 3; ++i)
            {
                Vector3 Pos = transform.position;
                Instantiate(shuttle, new Vector3(Pos.x + 0.5f, Pos.y, 0), Quaternion.Euler(0, 0, 45));
                Instantiate(shuttle, new Vector3(Pos.x - 0.5f, Pos.y, 0), Quaternion.Euler(0, 0, -45));
                Instantiate(shuttle, new Vector3(Pos.x, Pos.y, 0), Quaternion.identity);

                yield return new WaitForSeconds(0.5f);
            }
        }
    }
    void Pattern2()
    {
        Instantiate(basketball, RandomPos(), Quaternion.identity);
        Instantiate(basketball, RandomPos(), Quaternion.identity);
    }
    void Pattern3()
    {
        moveSpeed *= 1.25f;
    }
    void Pattern4()
    {
        Instantiate(student);   
    }

    Vector3 RandomPos()
    {
        Vector3 originPosition = spawnRange.transform.position;

        float ranX = range.bounds.size.x;
        float ranY = range.bounds.size.y;

        ranX = Random.Range((ranX / 2) * -1, ranX / 2);
        ranY = Random.Range((ranY / 2) * -1, ranY / 2);
        Vector3 RandomPostion = new Vector3(ranX, ranY, 0); 

        Vector3 respawnPosition = originPosition + RandomPostion;
        return respawnPosition;
    }
}
