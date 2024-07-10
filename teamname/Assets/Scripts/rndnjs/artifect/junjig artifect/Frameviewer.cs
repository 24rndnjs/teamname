using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frameviewer : MonoBehaviour
{
    public Database player;
    public GameObject game;
    private int enemyCount = 0; // ���� ���� �����ϴ� ����
    public junjigdatabase junjig;

    void Start()
    {
        // �ʱ�ȭ �ʿ� �� �߰�
    }

    void Update()
    {
        // �ʿ� �� �߰�
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IncreaseAttackSpeed();
            junjig.ani += 1;
            Invoke("ResetAttackSpeed", 3f); // 3�� �Ŀ� ���� �ӵ��� ������� ����
            Destroy(game); // ȿ�� ���� �� ������Ʈ �ı�
        }
    }

    void IncreaseAttackSpeed()
    {
        // ȭ�� ���� ��� ���� ã��
        enemy[] enemies = FindObjectsOfType<enemy>();

        // ���� ����ŭ �÷��̾��� ���� �ӵ� ����
        enemyCount = enemies.Length;
        player.attackSpeed += enemyCount;

        Debug.Log("Player attack speed increased by: " + enemyCount);
        Debug.Log("New player attack speed: " + player.attackSpeed);
    }

    void ResetAttackSpeed()
    {
        // ���� ���� �ӵ��� ����
        player.attackSpeed -= enemyCount;

       
        enemyCount = 0; // ī���� �ʱ�ȭ
    }
}
