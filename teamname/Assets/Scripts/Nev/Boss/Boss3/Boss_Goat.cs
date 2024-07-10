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

    public GameObject game;
    int patternNum;
    public GameObject spawnRange;
    BoxCollider2D range;
    public Database player;

    void Start()
    {
        patternNum = 0;
        player.MoveSpeed = moveSpeed;
        range = spawnRange.GetComponent<BoxCollider2D>();
        StartCoroutine(Pattern());
    }
    void Update()
    {
        patternNum %= 4;
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
        }
    }   
    void Pattern1()
    {
        StartCoroutine(slow());

        IEnumerator slow()
        {

            player.moveSpeed *= 0.75f;

                yield return new WaitForSeconds(0.5f);
            
        }

    }
    void Pattern2()
    {

    }
    void Pattern3()
    {

    }
    void Pattern4()
    {

    }
}
