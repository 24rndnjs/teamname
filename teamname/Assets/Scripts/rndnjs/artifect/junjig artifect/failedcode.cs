using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failedcode : MonoBehaviour
{
    public Database player; // �÷��̾� �����ͺ��̽�
    public GameObject game; // ���� ������Ʈ
    public junjigdatabase junjig;
    private float originalAttack; // ���� ���ݷ� ����

    void Start()
    {
        // ���� ���ݷ� ����
        originalAttack = player.attack;
    }

    // Ʈ���� �浹 ó�� �޼���
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            junjig.game += 1;
            // ���ݷ� ���� ���� (1% ~ 99%)
            float randomIncreasePercentage = Random.Range(0.01f, 0.99f);
            player.attack = originalAttack * (1 + randomIncreasePercentage);

            // �浹 �� ������ �������� �ִ� ���� (�ʿ� �� �߰�)

            // ���� ���ݷ����� �ʱ�ȭ (���⼭�� �ٷ� �ʱ�ȭ, ���� ���� �� �ʱ�ȭ�� ���ϸ� ���� ���� �ʿ�)
            player.attack = originalAttack;
        }
    }
}
