using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peetonchite : MonoBehaviour
{
    public Database player;
    public GameObject game;
    private int attackCount = 0; // �� ���� Ƚ�� ī����
    private const int maxStacks = 6; // �ִ� ��ø Ƚ��
    private const float speedIncreasePercentage = 1.1f; // �̵� �ӵ� ���� ���� (10%)

    void Start()
    {
        player.MoveSpeed = player.moveSpeed; // �÷��̾��� �⺻ �̵� �ӵ��� �ʱ�ȭ
    }

    void Update()
    {
        // ���� ���� ������Ʈ (�ʿ� �� �߰�)
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // �� ������Ʈ �ı�
            IncreaseMoveSpeed(); // �̵� �ӵ� ����
        }
    }

    void IncreaseMoveSpeed()
    {
        if (attackCount < maxStacks)
        {
            player.MoveSpeed *= speedIncreasePercentage; // �̵� �ӵ� 10% ����
            attackCount++; // ���� Ƚ�� ����
            Debug.Log("Player MoveSpeed increased to: " + player.MoveSpeed); // ����� �α׷� �̵� �ӵ� Ȯ��
        }
    }
}
